﻿using System;

namespace sc
{
    internal static class NtAPI
    {
        //https://raw.githubusercontent.com/tyranid/WindowsRpcClients/0ccb35c9684cbe54f4eb6673fdfaf06393c9f7ea/Win10_20H1/services.exe/367abb81-9844-35f1-ad32-98f038001003_2.0.cs
        #region Marshal Helpers
        internal class _Marshal_Helper : NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer
        {
            public void Write_0(Struct_0 p0)
            {
                WriteStruct<Struct_0>(p0);
            }
            public void Write_1(Struct_1 p0)
            {
                WriteStruct<Struct_1>(p0);
            }
            public void Write_2(Struct_2 p0)
            {
                WriteStruct<Struct_2>(p0);
            }
            public void Write_3(Struct_3 p0)
            {
                WriteStruct<Struct_3>(p0);
            }
            public void Write_4(Struct_4 p0)
            {
                WriteStruct<Struct_4>(p0);
            }
            public void Write_5(Struct_5 p0)
            {
                WriteStruct<Struct_5>(p0);
            }
            public void Write_6(Struct_6 p0)
            {
                WriteStruct<Struct_6>(p0);
            }
            public void Write_7(Struct_7 p0)
            {
                WriteStruct<Struct_7>(p0);
            }
            public void Write_8(Union_8 p0, long p1)
            {
                WriteUnion<Union_8>(p0, p1);
            }
            public void Write_9(Struct_9 p0)
            {
                WriteStruct<Struct_9>(p0);
            }
            public void Write_10(Struct_10 p0)
            {
                WriteStruct<Struct_10>(p0);
            }
            public void Write_11(Struct_11 p0)
            {
                WriteStruct<Struct_11>(p0);
            }
            public void Write_12(Struct_12 p0)
            {
                WriteStruct<Struct_12>(p0);
            }
            public void Write_13(Struct_13 p0)
            {
                WriteStruct<Struct_13>(p0);
            }
            public void Write_14(Struct_14 p0)
            {
                WriteStruct<Struct_14>(p0);
            }
            public void Write_15(Struct_15 p0)
            {
                WriteStruct<Struct_15>(p0);
            }
            public void Write_16(Struct_17 p0)
            {
                WriteStruct<Struct_17>(p0);
            }
            public void Write_17(Struct_18 p0)
            {
                WriteStruct<Struct_18>(p0);
            }
            public void Write_18(Struct_19 p0)
            {
                WriteStruct<Struct_19>(p0);
            }
            public void Write_19(Struct_20 p0)
            {
                WriteStruct<Struct_20>(p0);
            }
            public void Write_20(Union_21 p0, long p1)
            {
                WriteUnion<Union_21>(p0, p1);
            }
            public void Write_21(Struct_22 p0)
            {
                WriteStruct<Struct_22>(p0);
            }
            public void Write_22(Struct_23 p0)
            {
                WriteStruct<Struct_23>(p0);
            }
            public void Write_23(Union_24 p0, long p1)
            {
                WriteUnion<Union_24>(p0, p1);
            }
            public void Write_24(Struct_25 p0)
            {
                WriteStruct<Struct_25>(p0);
            }
            public void Write_25(Struct_26 p0)
            {
                WriteStruct<Struct_26>(p0);
            }
            public void Write_26(Union_27 p0, long p1)
            {
                WriteUnion<Union_27>(p0, p1);
            }
            public void Write_27(Struct_28 p0)
            {
                WriteStruct<Struct_28>(p0);
            }
            public void Write_28(Struct_29 p0)
            {
                WriteStruct<Struct_29>(p0);
            }
            public void Write_29(Struct_30 p0)
            {
                WriteStruct<Struct_30>(p0);
            }
            public void Write_30(Struct_31 p0)
            {
                WriteStruct<Struct_31>(p0);
            }
            public void Write_31(Struct_32 p0)
            {
                WriteStruct<Struct_32>(p0);
            }
            public void Write_32(Union_33 p0, long p1)
            {
                WriteUnion<Union_33>(p0, p1);
            }
            public void Write_33(Struct_34 p0)
            {
                WriteStruct<Struct_34>(p0);
            }
            public void Write_34(Struct_35 p0)
            {
                WriteStruct<Struct_35>(p0);
            }
            public void Write_35(Struct_36 p0)
            {
                WriteStruct<Struct_36>(p0);
            }
            public void Write_36(Struct_37 p0)
            {
                WriteStruct<Struct_37>(p0);
            }
            public void Write_37(Union_38 p0, long p1)
            {
                WriteUnion<Union_38>(p0, p1);
            }
            public void Write_38(Struct_39 p0)
            {
                WriteStruct<Struct_39>(p0);
            }
            public void Write_39(Union_40 p0, long p1)
            {
                WriteUnion<Union_40>(p0, p1);
            }
            public void Write_40(Struct_41 p0)
            {
                WriteStruct<Struct_41>(p0);
            }
            public void Write_41(Union_42 p0, long p1)
            {
                WriteUnion<Union_42>(p0, p1);
            }
            public void Write_42(Struct_43 p0)
            {
                WriteStruct<Struct_43>(p0);
            }
            public void Write_43(Union_44 p0, long p1)
            {
                WriteUnion<Union_44>(p0, p1);
            }
            public void Write_44(Union_45 p0, long p1)
            {
                WriteUnion<Union_45>(p0, p1);
            }
            public void Write_45(Struct_46 p0)
            {
                WriteStruct<Struct_46>(p0);
            }
            public void Write_46(Struct_11[] p0, long p1)
            {
                WriteConformantStructArray<Struct_11>(p0, p1);
            }
            public void Write_47(sbyte[] p0, long p1)
            {
                WriteConformantArray<sbyte>(p0, p1);
            }
            public void Write_48(Struct_15[] p0, long p1)
            {
                WriteConformantStructArray<Struct_15>(p0, p1);
            }
            public void Write_49(Struct_17[] p0, long p1)
            {
                WriteConformantStructArray<Struct_17>(p0, p1);
            }
            public void Write_50(sbyte[] p0, long p1)
            {
                WriteConformantArray<sbyte>(p0, p1);
            }
            public void Write_51(Struct_31[] p0, long p1)
            {
                WriteConformantStructArray<Struct_31>(p0, p1);
            }
            public void Write_52(sbyte[] p0)
            {
                WriteFixedPrimitiveArray<sbyte>(p0, 16);
            }
            public void Write_53(Struct_32[] p0, long p1)
            {
                WriteConformantStructArray<Struct_32>(p0, p1);
            }
            public void Write_54(sbyte[] p0, long p1)
            {
                WriteConformantArray<sbyte>(p0, p1);
            }
            public void Write_55(sbyte[] p0, long p1)
            {
                WriteConformantArray<sbyte>(p0, p1);
            }
            public void Write_56(sbyte[] p0, long p1)
            {
                WriteConformantArray<sbyte>(p0, p1);
            }
            public void Write_57(sbyte[] p0, long p1)
            {
                WriteConformantArray<sbyte>(p0, p1);
            }
            public void Write_58(sbyte[] p0, long p1)
            {
                WriteConformantArray<sbyte>(p0, p1);
            }
            public void Write_59(sbyte[] p0, long p1)
            {
                WriteConformantArray<sbyte>(p0, p1);
            }
            public void Write_60(sbyte[] p0, long p1)
            {
                WriteConformantArray<sbyte>(p0, p1);
            }
            public void Write_61(Struct_3[] p0, long p1)
            {
                WriteConformantStructArray<Struct_3>(p0, p1);
            }
            public void Write_62(string p0, long p1)
            {
                WriteConformantVaryingString(p0, p1);
            }
            public void Write_63(string p0, long p1)
            {
                WriteConformantVaryingString(p0, p1);
            }
            public void Write_64(Struct_6[] p0, long p1)
            {
                WriteConformantStructArray<Struct_6>(p0, p1);
            }
            public void Write_65(string p0, long p1)
            {
                WriteConformantVaryingAnsiString(p0, p1);
            }
            public void Write_66(string p0, long p1)
            {
                WriteConformantVaryingAnsiString(p0, p1);
            }
            public void Write_67(sbyte[] p0, long p1)
            {
                WriteConformantArray<sbyte>(p0, p1);
            }
            public void Write_68(sbyte[] p0, long p1)
            {
                WriteConformantArray<sbyte>(p0, p1);
            }
            public void Write_69(sbyte[] p0, long p1)
            {
                WriteConformantArray<sbyte>(p0, p1);
            }
            public void Write_70(sbyte[] p0, long p1)
            {
                WriteConformantArray<sbyte>(p0, p1);
            }
            public void Write_71(NtApiDotNet.NtKey p0)
            {
                WriteSystemHandle<NtApiDotNet.NtKey>(p0);
            }
            public void Write_72(char[] p0, long p1)
            {
                WriteConformantArray<char>(p0, p1);
            }
            public void Write_73(NtApiDotNet.NtToken p0)
            {
                WriteSystemHandle<NtApiDotNet.NtToken>(p0);
            }
        }
        internal class _Unmarshal_Helper : NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer
        {
            public _Unmarshal_Helper(NtApiDotNet.Win32.Rpc.RpcClientResponse r) :
                    base(r.NdrBuffer, r.Handles, r.DataRepresentation)
            {
            }
            public _Unmarshal_Helper(byte[] ba) :
                    base(ba)
            {
            }
            public Struct_0 Read_0()
            {
                return ReadStruct<Struct_0>();
            }
            public Struct_1 Read_1()
            {
                return ReadStruct<Struct_1>();
            }
            public Struct_2 Read_2()
            {
                return ReadStruct<Struct_2>();
            }
            public Struct_3 Read_3()
            {
                return ReadStruct<Struct_3>();
            }
            public Struct_4 Read_4()
            {
                return ReadStruct<Struct_4>();
            }
            public Struct_5 Read_5()
            {
                return ReadStruct<Struct_5>();
            }
            public Struct_6 Read_6()
            {
                return ReadStruct<Struct_6>();
            }
            public Struct_7 Read_7()
            {
                return ReadStruct<Struct_7>();
            }
            public Union_8 Read_8()
            {
                return ReadStruct<Union_8>();
            }
            public Struct_9 Read_9()
            {
                return ReadStruct<Struct_9>();
            }
            public Struct_10 Read_10()
            {
                return ReadStruct<Struct_10>();
            }
            public Struct_11 Read_11()
            {
                return ReadStruct<Struct_11>();
            }
            public Struct_12 Read_12()
            {
                return ReadStruct<Struct_12>();
            }
            public Struct_13 Read_13()
            {
                return ReadStruct<Struct_13>();
            }
            public Struct_14 Read_14()
            {
                return ReadStruct<Struct_14>();
            }
            public Struct_15 Read_15()
            {
                return ReadStruct<Struct_15>();
            }
            public Struct_17 Read_16()
            {
                return ReadStruct<Struct_17>();
            }
            public Struct_18 Read_17()
            {
                return ReadStruct<Struct_18>();
            }
            public Struct_19 Read_18()
            {
                return ReadStruct<Struct_19>();
            }
            public Struct_20 Read_19()
            {
                return ReadStruct<Struct_20>();
            }
            public Union_21 Read_20()
            {
                return ReadStruct<Union_21>();
            }
            public Struct_22 Read_21()
            {
                return ReadStruct<Struct_22>();
            }
            public Struct_23 Read_22()
            {
                return ReadStruct<Struct_23>();
            }
            public Union_24 Read_23()
            {
                return ReadStruct<Union_24>();
            }
            public Struct_25 Read_24()
            {
                return ReadStruct<Struct_25>();
            }
            public Struct_26 Read_25()
            {
                return ReadStruct<Struct_26>();
            }
            public Union_27 Read_26()
            {
                return ReadStruct<Union_27>();
            }
            public Struct_28 Read_27()
            {
                return ReadStruct<Struct_28>();
            }
            public Struct_29 Read_28()
            {
                return ReadStruct<Struct_29>();
            }
            public Struct_30 Read_29()
            {
                return ReadStruct<Struct_30>();
            }
            public Struct_31 Read_30()
            {
                return ReadStruct<Struct_31>();
            }
            public Struct_32 Read_31()
            {
                return ReadStruct<Struct_32>();
            }
            public Union_33 Read_32()
            {
                return ReadStruct<Union_33>();
            }
            public Struct_34 Read_33()
            {
                return ReadStruct<Struct_34>();
            }
            public Struct_35 Read_34()
            {
                return ReadStruct<Struct_35>();
            }
            public Struct_36 Read_35()
            {
                return ReadStruct<Struct_36>();
            }
            public Struct_37 Read_36()
            {
                return ReadStruct<Struct_37>();
            }
            public Union_38 Read_37()
            {
                return ReadStruct<Union_38>();
            }
            public Struct_39 Read_38()
            {
                return ReadStruct<Struct_39>();
            }
            public Union_40 Read_39()
            {
                return ReadStruct<Union_40>();
            }
            public Struct_41 Read_40()
            {
                return ReadStruct<Struct_41>();
            }
            public Union_42 Read_41()
            {
                return ReadStruct<Union_42>();
            }
            public Struct_43 Read_42()
            {
                return ReadStruct<Struct_43>();
            }
            public Union_44 Read_43()
            {
                return ReadStruct<Union_44>();
            }
            public Union_45 Read_44()
            {
                return ReadStruct<Union_45>();
            }
            public Struct_46 Read_45()
            {
                return ReadStruct<Struct_46>();
            }
            public Struct_11[] Read_46()
            {
                return ReadConformantStructArray<Struct_11>();
            }
            public sbyte[] Read_47()
            {
                return ReadConformantArray<sbyte>();
            }
            public Struct_15[] Read_48()
            {
                return ReadConformantStructArray<Struct_15>();
            }
            public Struct_17[] Read_49()
            {
                return ReadConformantStructArray<Struct_17>();
            }
            public sbyte[] Read_50()
            {
                return ReadConformantArray<sbyte>();
            }
            public Struct_31[] Read_51()
            {
                return ReadConformantStructArray<Struct_31>();
            }
            public sbyte[] Read_52()
            {
                return ReadFixedPrimitiveArray<sbyte>(16);
            }
            public Struct_32[] Read_53()
            {
                return ReadConformantStructArray<Struct_32>();
            }
            public sbyte[] Read_54()
            {
                return ReadConformantArray<sbyte>();
            }
            public sbyte[] Read_55()
            {
                return ReadConformantArray<sbyte>();
            }
            public sbyte[] Read_56()
            {
                return ReadConformantArray<sbyte>();
            }
            public sbyte[] Read_57()
            {
                return ReadConformantArray<sbyte>();
            }
            public sbyte[] Read_58()
            {
                return ReadConformantArray<sbyte>();
            }
            public sbyte[] Read_59()
            {
                return ReadConformantArray<sbyte>();
            }
            public sbyte[] Read_60()
            {
                return ReadConformantArray<sbyte>();
            }
            public Struct_3[] Read_61()
            {
                return ReadConformantStructArray<Struct_3>();
            }
            public Struct_6[] Read_62()
            {
                return ReadConformantStructArray<Struct_6>();
            }
            public sbyte[] Read_63()
            {
                return ReadConformantArray<sbyte>();
            }
            public sbyte[] Read_64()
            {
                return ReadConformantArray<sbyte>();
            }
            public sbyte[] Read_65()
            {
                return ReadConformantArray<sbyte>();
            }
            public sbyte[] Read_66()
            {
                return ReadConformantArray<sbyte>();
            }
            public NtApiDotNet.NtKey Read_67()
            {
                return ReadSystemHandle<NtApiDotNet.NtKey>();
            }
            public char[] Read_68()
            {
                return ReadConformantArray<char>();
            }
            public NtApiDotNet.NtToken Read_69()
            {
                return ReadSystemHandle<NtApiDotNet.NtToken>();
            }
        }
        #endregion
        #region Complex Types
        public struct Struct_0 : NtApiDotNet.Ndr.Marshal.INdrStructure
        {
            void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
            {
                Marshal(((_Marshal_Helper)(m)));
            }
            private void Marshal(_Marshal_Helper m)
            {
                m.WriteInt32(Member0);
                m.WriteInt32(Member4);
                m.WriteInt32(Member8);
                m.WriteInt32(MemberC);
                m.WriteInt32(Member10);
                m.WriteInt32(Member14);
                m.WriteInt32(Member18);
            }
            void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
            {
                Unmarshal(((_Unmarshal_Helper)(u)));
            }
            private void Unmarshal(_Unmarshal_Helper u)
            {
                Member0 = u.ReadInt32();
                Member4 = u.ReadInt32();
                Member8 = u.ReadInt32();
                MemberC = u.ReadInt32();
                Member10 = u.ReadInt32();
                Member14 = u.ReadInt32();
                Member18 = u.ReadInt32();
            }
            int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
            {
                return 4;
            }
            public int Member0;
            public int Member4;
            public int Member8;
            public int MemberC;
            public int Member10;
            public int Member14;
            public int Member18;
            public static Struct_0 CreateDefault()
            {
                return new Struct_0();
            }
            public Struct_0(int Member0, int Member4, int Member8, int MemberC, int Member10, int Member14, int Member18)
            {
                this.Member0 = Member0;
                this.Member4 = Member4;
                this.Member8 = Member8;
                this.MemberC = MemberC;
                this.Member10 = Member10;
                this.Member14 = Member14;
                this.Member18 = Member18;
            }
        }
        public struct Struct_1 : NtApiDotNet.Ndr.Marshal.INdrStructure
        {
            void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
            {
                Marshal(((_Marshal_Helper)(m)));
            }
            private void Marshal(_Marshal_Helper m)
            {
                m.WriteInt32(Member0);
                m.WriteInt32(Member4);
                m.WriteInt32(Member8);
                m.WriteEmbeddedPointer<string>(Member10, new System.Action<string>(m.WriteTerminatedString));
                m.WriteEmbeddedPointer<string>(Member18, new System.Action<string>(m.WriteTerminatedString));
                m.WriteInt32(Member20);
                m.WriteEmbeddedPointer<string>(Member28, new System.Action<string>(m.WriteTerminatedString));
                m.WriteEmbeddedPointer<string>(Member30, new System.Action<string>(m.WriteTerminatedString));
                m.WriteEmbeddedPointer<string>(Member38, new System.Action<string>(m.WriteTerminatedString));
            }
            void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
            {
                Unmarshal(((_Unmarshal_Helper)(u)));
            }
            private void Unmarshal(_Unmarshal_Helper u)
            {
                Member0 = u.ReadInt32();
                Member4 = u.ReadInt32();
                Member8 = u.ReadInt32();
                Member10 = u.ReadEmbeddedPointer<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
                Member18 = u.ReadEmbeddedPointer<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
                Member20 = u.ReadInt32();
                Member28 = u.ReadEmbeddedPointer<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
                Member30 = u.ReadEmbeddedPointer<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
                Member38 = u.ReadEmbeddedPointer<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            }
            int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
            {
                return 4;
            }
            public int Member0;
            public int Member4;
            public int Member8;
            public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<string> Member10;
            public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<string> Member18;
            public int Member20;
            public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<string> Member28;
            public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<string> Member30;
            public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<string> Member38;
            public static Struct_1 CreateDefault()
            {
                return new Struct_1();
            }
            public Struct_1(int Member0, int Member4, int Member8, string Member10, string Member18, int Member20, string Member28, string Member30, string Member38)
            {
                this.Member0 = Member0;
                this.Member4 = Member4;
                this.Member8 = Member8;
                this.Member10 = Member10;
                this.Member18 = Member18;
                this.Member20 = Member20;
                this.Member28 = Member28;
                this.Member30 = Member30;
                this.Member38 = Member38;
            }
        }
        public struct Struct_2 : NtApiDotNet.Ndr.Marshal.INdrStructure
        {
            void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
            {
                Marshal(((_Marshal_Helper)(m)));
            }
            private void Marshal(_Marshal_Helper m)
            {
                m.WriteInt32(Member0);
                m.WriteEmbeddedPointer<string>(Member8, new System.Action<string>(m.WriteTerminatedString));
                m.WriteInt32(Member10);
            }
            void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
            {
                Unmarshal(((_Unmarshal_Helper)(u)));
            }
            private void Unmarshal(_Unmarshal_Helper u)
            {
                Member0 = u.ReadInt32();
                Member8 = u.ReadEmbeddedPointer<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
                Member10 = u.ReadInt32();
            }
            int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
            {
                return 4;
            }
            public int Member0;
            public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<string> Member8;
            public int Member10;
            public static Struct_2 CreateDefault()
            {
                return new Struct_2();
            }
            public Struct_2(int Member0, string Member8, int Member10)
            {
                this.Member0 = Member0;
                this.Member8 = Member8;
                this.Member10 = Member10;
            }
        }
        public struct Struct_3 : NtApiDotNet.Ndr.Marshal.INdrStructure
        {
            void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
            {
                Marshal(((_Marshal_Helper)(m)));
            }
            private void Marshal(_Marshal_Helper m)
            {
                m.WriteEmbeddedPointer<string>(Member0, new System.Action<string>(m.WriteTerminatedString));
            }
            void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
            {
                Unmarshal(((_Unmarshal_Helper)(u)));
            }
            private void Unmarshal(_Unmarshal_Helper u)
            {
                Member0 = u.ReadEmbeddedPointer<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            }
            int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
            {
                return 4;
            }
            public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<string> Member0;
            public static Struct_3 CreateDefault()
            {
                return new Struct_3();
            }
            public Struct_3(string Member0)
            {
                this.Member0 = Member0;
            }
        }
        public struct Struct_4 : NtApiDotNet.Ndr.Marshal.INdrStructure
        {
            void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
            {
                Marshal(((_Marshal_Helper)(m)));
            }
            private void Marshal(_Marshal_Helper m)
            {
                m.WriteInt32(Member0);
                m.WriteInt32(Member4);
                m.WriteInt32(Member8);
                m.WriteEmbeddedPointer<string>(Member10, new System.Action<string>(m.WriteTerminatedAnsiString));
                m.WriteEmbeddedPointer<string>(Member18, new System.Action<string>(m.WriteTerminatedAnsiString));
                m.WriteInt32(Member20);
                m.WriteEmbeddedPointer<string>(Member28, new System.Action<string>(m.WriteTerminatedAnsiString));
                m.WriteEmbeddedPointer<string>(Member30, new System.Action<string>(m.WriteTerminatedAnsiString));
                m.WriteEmbeddedPointer<string>(Member38, new System.Action<string>(m.WriteTerminatedAnsiString));
            }
            void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
            {
                Unmarshal(((_Unmarshal_Helper)(u)));
            }
            private void Unmarshal(_Unmarshal_Helper u)
            {
                Member0 = u.ReadInt32();
                Member4 = u.ReadInt32();
                Member8 = u.ReadInt32();
                Member10 = u.ReadEmbeddedPointer<string>(new System.Func<string>(u.ReadConformantVaryingAnsiString), false);
                Member18 = u.ReadEmbeddedPointer<string>(new System.Func<string>(u.ReadConformantVaryingAnsiString), false);
                Member20 = u.ReadInt32();
                Member28 = u.ReadEmbeddedPointer<string>(new System.Func<string>(u.ReadConformantVaryingAnsiString), false);
                Member30 = u.ReadEmbeddedPointer<string>(new System.Func<string>(u.ReadConformantVaryingAnsiString), false);
                Member38 = u.ReadEmbeddedPointer<string>(new System.Func<string>(u.ReadConformantVaryingAnsiString), false);
            }
            int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
            {
                return 4;
            }
            public int Member0;
            public int Member4;
            public int Member8;
            public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<string> Member10;
            public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<string> Member18;
            public int Member20;
            public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<string> Member28;
            public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<string> Member30;
            public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<string> Member38;
            public static Struct_4 CreateDefault()
            {
                return new Struct_4();
            }
            public Struct_4(int Member0, int Member4, int Member8, string Member10, string Member18, int Member20, string Member28, string Member30, string Member38)
            {
                this.Member0 = Member0;
                this.Member4 = Member4;
                this.Member8 = Member8;
                this.Member10 = Member10;
                this.Member18 = Member18;
                this.Member20 = Member20;
                this.Member28 = Member28;
                this.Member30 = Member30;
                this.Member38 = Member38;
            }
        }
        public struct Struct_5 : NtApiDotNet.Ndr.Marshal.INdrStructure
        {
            void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
            {
                Marshal(((_Marshal_Helper)(m)));
            }
            private void Marshal(_Marshal_Helper m)
            {
                m.WriteInt32(Member0);
                m.WriteEmbeddedPointer<string>(Member8, new System.Action<string>(m.WriteTerminatedAnsiString));
                m.WriteInt32(Member10);
            }
            void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
            {
                Unmarshal(((_Unmarshal_Helper)(u)));
            }
            private void Unmarshal(_Unmarshal_Helper u)
            {
                Member0 = u.ReadInt32();
                Member8 = u.ReadEmbeddedPointer<string>(new System.Func<string>(u.ReadConformantVaryingAnsiString), false);
                Member10 = u.ReadInt32();
            }
            int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
            {
                return 4;
            }
            public int Member0;
            public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<string> Member8;
            public int Member10;
            public static Struct_5 CreateDefault()
            {
                return new Struct_5();
            }
            public Struct_5(int Member0, string Member8, int Member10)
            {
                this.Member0 = Member0;
                this.Member8 = Member8;
                this.Member10 = Member10;
            }
        }
        public struct Struct_6 : NtApiDotNet.Ndr.Marshal.INdrStructure
        {
            void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
            {
                Marshal(((_Marshal_Helper)(m)));
            }
            private void Marshal(_Marshal_Helper m)
            {
                m.WriteEmbeddedPointer<string>(Member0, new System.Action<string>(m.WriteTerminatedAnsiString));
            }
            void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
            {
                Unmarshal(((_Unmarshal_Helper)(u)));
            }
            private void Unmarshal(_Unmarshal_Helper u)
            {
                Member0 = u.ReadEmbeddedPointer<string>(new System.Func<string>(u.ReadConformantVaryingAnsiString), false);
            }
            int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
            {
                return 4;
            }
            public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<string> Member0;
            public static Struct_6 CreateDefault()
            {
                return new Struct_6();
            }
            public Struct_6(string Member0)
            {
                this.Member0 = Member0;
            }
        }
        public struct Struct_7 : NtApiDotNet.Ndr.Marshal.INdrStructure
        {
            void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
            {
                Marshal(((_Marshal_Helper)(m)));
            }
            private void Marshal(_Marshal_Helper m)
            {
                m.WriteInt32(Member0);
                m.Write_8(Member8, Member0);
            }
            void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
            {
                Unmarshal(((_Unmarshal_Helper)(u)));
            }
            private void Unmarshal(_Unmarshal_Helper u)
            {
                Member0 = u.ReadInt32();
                Member8 = u.Read_8();
            }
            int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
            {
                return 4;
            }
            public int Member0;
            public Union_8 Member8;
            public static Struct_7 CreateDefault()
            {
                return new Struct_7();
            }
            public Struct_7(int Member0, Union_8 Member8)
            {
                this.Member0 = Member0;
                this.Member8 = Member8;
            }
        }
        public struct Union_8 : NtApiDotNet.Ndr.Marshal.INdrNonEncapsulatedUnion
        {
            void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
            {
                throw new System.NotImplementedException();
            }
            void NtApiDotNet.Ndr.Marshal.INdrNonEncapsulatedUnion.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m, long l)
            {
                Selector = ((uint)(l));
                Marshal(((_Marshal_Helper)(m)));
            }
            private void Marshal(_Marshal_Helper m)
            {
                m.WriteUInt32(Selector);
                if ((Selector == 1))
                {
                    m.WriteEmbeddedPointer<Struct_9>(Arm_1, new System.Action<Struct_9>(m.Write_9));
                    goto done;
                }
                if ((Selector == 2))
                {
                    m.WriteEmbeddedPointer<Struct_10>(Arm_2, new System.Action<Struct_10>(m.Write_10));
                    goto done;
                }
                if ((Selector == 3))
                {
                    m.WriteEmbeddedPointer<Struct_12>(Arm_3, new System.Action<Struct_12>(m.Write_12));
                    goto done;
                }
                if ((Selector == 4))
                {
                    m.WriteEmbeddedPointer<Struct_12>(Arm_4, new System.Action<Struct_12>(m.Write_12));
                    goto done;
                }
                if ((Selector == 5))
                {
                    m.WriteEmbeddedPointer<Struct_12>(Arm_5, new System.Action<Struct_12>(m.Write_12));
                    goto done;
                }
                if ((Selector == 6))
                {
                    m.WriteEmbeddedPointer<Struct_13>(Arm_6, new System.Action<Struct_13>(m.Write_13));
                    goto done;
                }
                if ((Selector == 7))
                {
                    m.WriteEmbeddedPointer<Struct_12>(Arm_7, new System.Action<Struct_12>(m.Write_12));
                    goto done;
                }
                if ((Selector == 8))
                {
                    m.WriteEmbeddedPointer<Struct_14>(Arm_8, new System.Action<Struct_14>(m.Write_14));
                    goto done;
                }
                if ((Selector == 9))
                {
                    m.WriteEmbeddedPointer<Struct_18>(Arm_9, new System.Action<Struct_18>(m.Write_17));
                    goto done;
                }
                if ((Selector == 11))
                {
                    m.WriteEmbeddedPointer<Struct_19>(Arm_11, new System.Action<Struct_19>(m.Write_18));
                    goto done;
                }
                if ((Selector == 12))
                {
                    m.WriteEmbeddedPointer<Struct_12>(Arm_12, new System.Action<Struct_12>(m.Write_12));
                    goto done;
                }
                throw new System.ArgumentException("No matching union selector when marshaling Union_8");
                done:
                return;
            }
            void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
            {
                Unmarshal(((_Unmarshal_Helper)(u)));
            }
            private void Unmarshal(_Unmarshal_Helper u)
            {
                Selector = u.ReadUInt32();
                if ((Selector == 1))
                {
                    Arm_1 = u.ReadEmbeddedPointer<Struct_9>(new System.Func<Struct_9>(u.Read_9), false);
                    goto done;
                }
                if ((Selector == 2))
                {
                    Arm_2 = u.ReadEmbeddedPointer<Struct_10>(new System.Func<Struct_10>(u.Read_10), false);
                    goto done;
                }
                if ((Selector == 3))
                {
                    Arm_3 = u.ReadEmbeddedPointer<Struct_12>(new System.Func<Struct_12>(u.Read_12), false);
                    goto done;
                }
                if ((Selector == 4))
                {
                    Arm_4 = u.ReadEmbeddedPointer<Struct_12>(new System.Func<Struct_12>(u.Read_12), false);
                    goto done;
                }
                if ((Selector == 5))
                {
                    Arm_5 = u.ReadEmbeddedPointer<Struct_12>(new System.Func<Struct_12>(u.Read_12), false);
                    goto done;
                }
                if ((Selector == 6))
                {
                    Arm_6 = u.ReadEmbeddedPointer<Struct_13>(new System.Func<Struct_13>(u.Read_13), false);
                    goto done;
                }
                if ((Selector == 7))
                {
                    Arm_7 = u.ReadEmbeddedPointer<Struct_12>(new System.Func<Struct_12>(u.Read_12), false);
                    goto done;
                }
                if ((Selector == 8))
                {
                    Arm_8 = u.ReadEmbeddedPointer<Struct_14>(new System.Func<Struct_14>(u.Read_14), false);
                    goto done;
                }
                if ((Selector == 9))
                {
                    Arm_9 = u.ReadEmbeddedPointer<Struct_18>(new System.Func<Struct_18>(u.Read_17), false);
                    goto done;
                }
                if ((Selector == 11))
                {
                    Arm_11 = u.ReadEmbeddedPointer<Struct_19>(new System.Func<Struct_19>(u.Read_18), false);
                    goto done;
                }
                if ((Selector == 12))
                {
                    Arm_12 = u.ReadEmbeddedPointer<Struct_12>(new System.Func<Struct_12>(u.Read_12), false);
                    goto done;
                }
                throw new System.ArgumentException("No matching union selector when marshaling Union_8");
                done:
                return;
            }
            int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
            {
                return 4;
            }
            private uint Selector;
            public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<Struct_9> Arm_1;
            public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<Struct_10> Arm_2;
            public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<Struct_12> Arm_3;
            public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<Struct_12> Arm_4;
            public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<Struct_12> Arm_5;
            public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<Struct_13> Arm_6;
            public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<Struct_12> Arm_7;
            public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<Struct_14> Arm_8;
            public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<Struct_18> Arm_9;
            public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<Struct_19> Arm_11;
            public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<Struct_12> Arm_12;
            public static Union_8 CreateDefault()
            {
                return new Union_8();
            }
            public Union_8(uint Selector, System.Nullable<Struct_9> Arm_1, System.Nullable<Struct_10> Arm_2, System.Nullable<Struct_12> Arm_3, System.Nullable<Struct_12> Arm_4, System.Nullable<Struct_12> Arm_5, System.Nullable<Struct_13> Arm_6, System.Nullable<Struct_12> Arm_7, System.Nullable<Struct_14> Arm_8, System.Nullable<Struct_18> Arm_9, System.Nullable<Struct_19> Arm_11, System.Nullable<Struct_12> Arm_12)
            {
                this.Selector = Selector;
                this.Arm_1 = Arm_1;
                this.Arm_2 = Arm_2;
                this.Arm_3 = Arm_3;
                this.Arm_4 = Arm_4;
                this.Arm_5 = Arm_5;
                this.Arm_6 = Arm_6;
                this.Arm_7 = Arm_7;
                this.Arm_8 = Arm_8;
                this.Arm_9 = Arm_9;
                this.Arm_11 = Arm_11;
                this.Arm_12 = Arm_12;
            }
        }
        public struct Struct_9 : NtApiDotNet.Ndr.Marshal.INdrStructure
        {
            void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
            {
                Marshal(((_Marshal_Helper)(m)));
            }
            private void Marshal(_Marshal_Helper m)
            {
                m.WriteEmbeddedPointer<string>(Member0, new System.Action<string>(m.WriteTerminatedAnsiString));
            }
            void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
            {
                Unmarshal(((_Unmarshal_Helper)(u)));
            }
            private void Unmarshal(_Unmarshal_Helper u)
            {
                Member0 = u.ReadEmbeddedPointer<string>(new System.Func<string>(u.ReadConformantVaryingAnsiString), false);
            }
            int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
            {
                return 4;
            }
            public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<string> Member0;
            public static Struct_9 CreateDefault()
            {
                return new Struct_9();
            }
            public Struct_9(string Member0)
            {
                this.Member0 = Member0;
            }
        }
        public struct Struct_10 : NtApiDotNet.Ndr.Marshal.INdrStructure
        {
            void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
            {
                Marshal(((_Marshal_Helper)(m)));
            }
            private void Marshal(_Marshal_Helper m)
            {
                m.WriteInt32(Member0);
                m.WriteEmbeddedPointer<string>(Member8, new System.Action<string>(m.WriteTerminatedAnsiString));
                m.WriteEmbeddedPointer<string>(Member10, new System.Action<string>(m.WriteTerminatedAnsiString));
                m.WriteInt32(Member18);
                m.WriteEmbeddedPointer<Struct_11[], long>(Member20, new System.Action<Struct_11[], long>(m.Write_46), Member18);
            }
            void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
            {
                Unmarshal(((_Unmarshal_Helper)(u)));
            }
            private void Unmarshal(_Unmarshal_Helper u)
            {
                Member0 = u.ReadInt32();
                Member8 = u.ReadEmbeddedPointer<string>(new System.Func<string>(u.ReadConformantVaryingAnsiString), false);
                Member10 = u.ReadEmbeddedPointer<string>(new System.Func<string>(u.ReadConformantVaryingAnsiString), false);
                Member18 = u.ReadInt32();
                Member20 = u.ReadEmbeddedPointer<Struct_11[]>(new System.Func<Struct_11[]>(u.Read_46), false);
            }
            int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
            {
                return 4;
            }
            public int Member0;
            public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<string> Member8;
            public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<string> Member10;
            public int Member18;
            public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<Struct_11[]> Member20;
            public static Struct_10 CreateDefault()
            {
                return new Struct_10();
            }
            public Struct_10(int Member0, string Member8, string Member10, int Member18, Struct_11[] Member20)
            {
                this.Member0 = Member0;
                this.Member8 = Member8;
                this.Member10 = Member10;
                this.Member18 = Member18;
                this.Member20 = Member20;
            }
        }
        public struct Struct_11 : NtApiDotNet.Ndr.Marshal.INdrStructure
        {
            void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
            {
                Marshal(((_Marshal_Helper)(m)));
            }
            private void Marshal(_Marshal_Helper m)
            {
                m.WriteInt32(Member0);
                m.WriteInt32(Member4);
            }
            void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
            {
                Unmarshal(((_Unmarshal_Helper)(u)));
            }
            private void Unmarshal(_Unmarshal_Helper u)
            {
                Member0 = u.ReadInt32();
                Member4 = u.ReadInt32();
            }
            int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
            {
                return 4;
            }
            public int Member0;
            public int Member4;
            public static Struct_11 CreateDefault()
            {
                return new Struct_11();
            }
            public Struct_11(int Member0, int Member4)
            {
                this.Member0 = Member0;
                this.Member4 = Member4;
            }
        }
        public struct Struct_12 : NtApiDotNet.Ndr.Marshal.INdrStructure
        {
            void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
            {
                Marshal(((_Marshal_Helper)(m)));
            }
            private void Marshal(_Marshal_Helper m)
            {
                m.WriteInt32(Member0);
            }
            void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
            {
                Unmarshal(((_Unmarshal_Helper)(u)));
            }
            private void Unmarshal(_Unmarshal_Helper u)
            {
                Member0 = u.ReadInt32();
            }
            int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
            {
                return 4;
            }
            public int Member0;
            public static Struct_12 CreateDefault()
            {
                return new Struct_12();
            }
            public Struct_12(int Member0)
            {
                this.Member0 = Member0;
            }
        }
        public struct Struct_13 : NtApiDotNet.Ndr.Marshal.INdrStructure
        {
            void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
            {
                Marshal(((_Marshal_Helper)(m)));
            }
            private void Marshal(_Marshal_Helper m)
            {
                m.WriteInt32(Member0);
                m.WriteEmbeddedPointer<sbyte[], long>(Member8, new System.Action<sbyte[], long>(m.Write_47), Member0);
            }
            void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
            {
                Unmarshal(((_Unmarshal_Helper)(u)));
            }
            private void Unmarshal(_Unmarshal_Helper u)
            {
                Member0 = u.ReadInt32();
                Member8 = u.ReadEmbeddedPointer<sbyte[]>(new System.Func<sbyte[]>(u.Read_47), false);
            }
            int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
            {
                return 4;
            }
            public int Member0;
            public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<sbyte[]> Member8;
            public static Struct_13 CreateDefault()
            {
                return new Struct_13();
            }
            public Struct_13(int Member0, sbyte[] Member8)
            {
                this.Member0 = Member0;
                this.Member8 = Member8;
            }
        }
        public struct Struct_14 : NtApiDotNet.Ndr.Marshal.INdrStructure
        {
            void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
            {
                Marshal(((_Marshal_Helper)(m)));
            }
            private void Marshal(_Marshal_Helper m)
            {
                m.WriteInt32(Member0);
                m.WriteEmbeddedPointer<Struct_15[], long>(Member8, new System.Action<Struct_15[], long>(m.Write_48), Member0);
                m.WriteEmbeddedPointer<sbyte>(Member10, new System.Action<sbyte>(m.WriteSByte));
            }
            void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
            {
                Unmarshal(((_Unmarshal_Helper)(u)));
            }
            private void Unmarshal(_Unmarshal_Helper u)
            {
                Member0 = u.ReadInt32();
                Member8 = u.ReadEmbeddedPointer<Struct_15[]>(new System.Func<Struct_15[]>(u.Read_48), false);
                Member10 = u.ReadEmbeddedPointer<sbyte>(new System.Func<sbyte>(u.ReadSByte), false);
            }
            int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
            {
                return 4;
            }
            public int Member0;
            public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<Struct_15[]> Member8;
            public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<sbyte> Member10;
            public static Struct_14 CreateDefault()
            {
                return new Struct_14();
            }
            public Struct_14(int Member0, Struct_15[] Member8, System.Nullable<sbyte> Member10)
            {
                this.Member0 = Member0;
                this.Member8 = Member8;
                this.Member10 = Member10;
            }
        }
        public struct Struct_15 : NtApiDotNet.Ndr.Marshal.INdrStructure
        {
            void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
            {
                Marshal(((_Marshal_Helper)(m)));
            }
            private void Marshal(_Marshal_Helper m)
            {
                m.WriteInt32(Member0);
                m.WriteInt32(Member4);
                m.WriteEmbeddedPointer<System.Guid>(Member8, new System.Action<System.Guid>(m.WriteGuid));
                m.WriteInt32(Member10);
                m.WriteEmbeddedPointer<Struct_17[], long>(Member18, new System.Action<Struct_17[], long>(m.Write_49), Member10);
            }
            void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
            {
                Unmarshal(((_Unmarshal_Helper)(u)));
            }
            private void Unmarshal(_Unmarshal_Helper u)
            {
                Member0 = u.ReadInt32();
                Member4 = u.ReadInt32();
                Member8 = u.ReadEmbeddedPointer<System.Guid>(new System.Func<System.Guid>(u.ReadGuid), false);
                Member10 = u.ReadInt32();
                Member18 = u.ReadEmbeddedPointer<Struct_17[]>(new System.Func<Struct_17[]>(u.Read_49), false);
            }
            int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
            {
                return 4;
            }
            public int Member0;
            public int Member4;
            public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<System.Guid> Member8;
            public int Member10;
            public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<Struct_17[]> Member18;
            public static Struct_15 CreateDefault()
            {
                return new Struct_15();
            }
            public Struct_15(int Member0, int Member4, System.Nullable<System.Guid> Member8, int Member10, Struct_17[] Member18)
            {
                this.Member0 = Member0;
                this.Member4 = Member4;
                this.Member8 = Member8;
                this.Member10 = Member10;
                this.Member18 = Member18;
            }
        }
        public struct Struct_17 : NtApiDotNet.Ndr.Marshal.INdrStructure
        {
            void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
            {
                Marshal(((_Marshal_Helper)(m)));
            }
            private void Marshal(_Marshal_Helper m)
            {
                m.WriteInt32(Member0);
                m.WriteInt32(Member4);
                m.WriteEmbeddedPointer<sbyte[], long>(Member8, new System.Action<sbyte[], long>(m.Write_50), Member4);
            }
            void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
            {
                Unmarshal(((_Unmarshal_Helper)(u)));
            }
            private void Unmarshal(_Unmarshal_Helper u)
            {
                Member0 = u.ReadInt32();
                Member4 = u.ReadInt32();
                Member8 = u.ReadEmbeddedPointer<sbyte[]>(new System.Func<sbyte[]>(u.Read_50), false);
            }
            int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
            {
                return 4;
            }
            public int Member0;
            public int Member4;
            public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<sbyte[]> Member8;
            public static Struct_17 CreateDefault()
            {
                return new Struct_17();
            }
            public Struct_17(int Member0, int Member4, sbyte[] Member8)
            {
                this.Member0 = Member0;
                this.Member4 = Member4;
                this.Member8 = Member8;
            }
        }
        public struct Struct_18 : NtApiDotNet.Ndr.Marshal.INdrStructure
        {
            void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
            {
                Marshal(((_Marshal_Helper)(m)));
            }
            private void Marshal(_Marshal_Helper m)
            {
                m.WriteInt16(Member0);
                m.WriteSByte(Member2);
            }
            void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
            {
                Unmarshal(((_Unmarshal_Helper)(u)));
            }
            private void Unmarshal(_Unmarshal_Helper u)
            {
                Member0 = u.ReadInt16();
                Member2 = u.ReadSByte();
            }
            int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
            {
                return 2;
            }
            public short Member0;
            public sbyte Member2;
            public static Struct_18 CreateDefault()
            {
                return new Struct_18();
            }
            public Struct_18(short Member0, sbyte Member2)
            {
                this.Member0 = Member0;
                this.Member2 = Member2;
            }
        }
        public struct Struct_19 : NtApiDotNet.Ndr.Marshal.INdrStructure
        {
            void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
            {
                Marshal(((_Marshal_Helper)(m)));
            }
            private void Marshal(_Marshal_Helper m)
            {
                m.WriteSByte(Member0);
            }
            void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
            {
                Unmarshal(((_Unmarshal_Helper)(u)));
            }
            private void Unmarshal(_Unmarshal_Helper u)
            {
                Member0 = u.ReadSByte();
            }
            int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
            {
                return 1;
            }
            public sbyte Member0;
            public static Struct_19 CreateDefault()
            {
                return new Struct_19();
            }
            public Struct_19(sbyte Member0)
            {
                this.Member0 = Member0;
            }
        }
        public struct Struct_20 : NtApiDotNet.Ndr.Marshal.INdrStructure
        {
            void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
            {
                Marshal(((_Marshal_Helper)(m)));
            }
            private void Marshal(_Marshal_Helper m)
            {
                m.WriteInt32(Member0);
                m.Write_20(Member8, Member0);
            }
            void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
            {
                Unmarshal(((_Unmarshal_Helper)(u)));
            }
            private void Unmarshal(_Unmarshal_Helper u)
            {
                Member0 = u.ReadInt32();
                Member8 = u.Read_20();
            }
            int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
            {
                return 4;
            }
            public int Member0;
            public Union_21 Member8;
            public static Struct_20 CreateDefault()
            {
                return new Struct_20();
            }
            public Struct_20(int Member0, Union_21 Member8)
            {
                this.Member0 = Member0;
                this.Member8 = Member8;
            }
        }
        public struct Union_21 : NtApiDotNet.Ndr.Marshal.INdrNonEncapsulatedUnion
        {
            void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
            {
                throw new System.NotImplementedException();
            }
            void NtApiDotNet.Ndr.Marshal.INdrNonEncapsulatedUnion.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m, long l)
            {
                Selector = ((uint)(l));
                Marshal(((_Marshal_Helper)(m)));
            }
            private void Marshal(_Marshal_Helper m)
            {
                m.WriteUInt32(Selector);
                if ((Selector == 1))
                {
                    m.WriteEmbeddedPointer<Struct_22>(Arm_1, new System.Action<Struct_22>(m.Write_21));
                    goto done;
                }
                if ((Selector == 2))
                {
                    m.WriteEmbeddedPointer<Struct_23>(Arm_2, new System.Action<Struct_23>(m.Write_22));
                    goto done;
                }
                if ((Selector == 3))
                {
                    m.WriteEmbeddedPointer<Struct_12>(Arm_3, new System.Action<Struct_12>(m.Write_12));
                    goto done;
                }
                if ((Selector == 4))
                {
                    m.WriteEmbeddedPointer<Struct_12>(Arm_4, new System.Action<Struct_12>(m.Write_12));
                    goto done;
                }
                if ((Selector == 5))
                {
                    m.WriteEmbeddedPointer<Struct_12>(Arm_5, new System.Action<Struct_12>(m.Write_12));
                    goto done;
                }
                if ((Selector == 6))
                {
                    m.WriteEmbeddedPointer<Struct_13>(Arm_6, new System.Action<Struct_13>(m.Write_13));
                    goto done;
                }
                if ((Selector == 7))
                {
                    m.WriteEmbeddedPointer<Struct_12>(Arm_7, new System.Action<Struct_12>(m.Write_12));
                    goto done;
                }
                if ((Selector == 8))
                {
                    m.WriteEmbeddedPointer<Struct_14>(Arm_8, new System.Action<Struct_14>(m.Write_14));
                    goto done;
                }
                if ((Selector == 9))
                {
                    m.WriteEmbeddedPointer<Struct_18>(Arm_9, new System.Action<Struct_18>(m.Write_17));
                    goto done;
                }
                if ((Selector == 11))
                {
                    m.WriteEmbeddedPointer<Struct_19>(Arm_11, new System.Action<Struct_19>(m.Write_18));
                    goto done;
                }
                if ((Selector == 12))
                {
                    m.WriteEmbeddedPointer<Struct_12>(Arm_12, new System.Action<Struct_12>(m.Write_12));
                    goto done;
                }
                throw new System.ArgumentException("No matching union selector when marshaling Union_21");
                done:
                return;
            }
            void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
            {
                Unmarshal(((_Unmarshal_Helper)(u)));
            }
            private void Unmarshal(_Unmarshal_Helper u)
            {
                Selector = u.ReadUInt32();
                if ((Selector == 1))
                {
                    Arm_1 = u.ReadEmbeddedPointer<Struct_22>(new System.Func<Struct_22>(u.Read_21), false);
                    goto done;
                }
                if ((Selector == 2))
                {
                    Arm_2 = u.ReadEmbeddedPointer<Struct_23>(new System.Func<Struct_23>(u.Read_22), false);
                    goto done;
                }
                if ((Selector == 3))
                {
                    Arm_3 = u.ReadEmbeddedPointer<Struct_12>(new System.Func<Struct_12>(u.Read_12), false);
                    goto done;
                }
                if ((Selector == 4))
                {
                    Arm_4 = u.ReadEmbeddedPointer<Struct_12>(new System.Func<Struct_12>(u.Read_12), false);
                    goto done;
                }
                if ((Selector == 5))
                {
                    Arm_5 = u.ReadEmbeddedPointer<Struct_12>(new System.Func<Struct_12>(u.Read_12), false);
                    goto done;
                }
                if ((Selector == 6))
                {
                    Arm_6 = u.ReadEmbeddedPointer<Struct_13>(new System.Func<Struct_13>(u.Read_13), false);
                    goto done;
                }
                if ((Selector == 7))
                {
                    Arm_7 = u.ReadEmbeddedPointer<Struct_12>(new System.Func<Struct_12>(u.Read_12), false);
                    goto done;
                }
                if ((Selector == 8))
                {
                    Arm_8 = u.ReadEmbeddedPointer<Struct_14>(new System.Func<Struct_14>(u.Read_14), false);
                    goto done;
                }
                if ((Selector == 9))
                {
                    Arm_9 = u.ReadEmbeddedPointer<Struct_18>(new System.Func<Struct_18>(u.Read_17), false);
                    goto done;
                }
                if ((Selector == 11))
                {
                    Arm_11 = u.ReadEmbeddedPointer<Struct_19>(new System.Func<Struct_19>(u.Read_18), false);
                    goto done;
                }
                if ((Selector == 12))
                {
                    Arm_12 = u.ReadEmbeddedPointer<Struct_12>(new System.Func<Struct_12>(u.Read_12), false);
                    goto done;
                }
                throw new System.ArgumentException("No matching union selector when marshaling Union_21");
                done:
                return;
            }
            int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
            {
                return 4;
            }
            private uint Selector;
            public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<Struct_22> Arm_1;
            public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<Struct_23> Arm_2;
            public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<Struct_12> Arm_3;
            public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<Struct_12> Arm_4;
            public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<Struct_12> Arm_5;
            public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<Struct_13> Arm_6;
            public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<Struct_12> Arm_7;
            public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<Struct_14> Arm_8;
            public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<Struct_18> Arm_9;
            public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<Struct_19> Arm_11;
            public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<Struct_12> Arm_12;
            public static Union_21 CreateDefault()
            {
                return new Union_21();
            }
            public Union_21(uint Selector, System.Nullable<Struct_22> Arm_1, System.Nullable<Struct_23> Arm_2, System.Nullable<Struct_12> Arm_3, System.Nullable<Struct_12> Arm_4, System.Nullable<Struct_12> Arm_5, System.Nullable<Struct_13> Arm_6, System.Nullable<Struct_12> Arm_7, System.Nullable<Struct_14> Arm_8, System.Nullable<Struct_18> Arm_9, System.Nullable<Struct_19> Arm_11, System.Nullable<Struct_12> Arm_12)
            {
                this.Selector = Selector;
                this.Arm_1 = Arm_1;
                this.Arm_2 = Arm_2;
                this.Arm_3 = Arm_3;
                this.Arm_4 = Arm_4;
                this.Arm_5 = Arm_5;
                this.Arm_6 = Arm_6;
                this.Arm_7 = Arm_7;
                this.Arm_8 = Arm_8;
                this.Arm_9 = Arm_9;
                this.Arm_11 = Arm_11;
                this.Arm_12 = Arm_12;
            }
        }
        public struct Struct_22 : NtApiDotNet.Ndr.Marshal.INdrStructure
        {
            void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
            {
                Marshal(((_Marshal_Helper)(m)));
            }
            private void Marshal(_Marshal_Helper m)
            {
                m.WriteEmbeddedPointer<string>(Member0, new System.Action<string>(m.WriteTerminatedString));
            }
            void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
            {
                Unmarshal(((_Unmarshal_Helper)(u)));
            }
            private void Unmarshal(_Unmarshal_Helper u)
            {
                Member0 = u.ReadEmbeddedPointer<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            }
            int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
            {
                return 4;
            }
            public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<string> Member0;
            public static Struct_22 CreateDefault()
            {
                return new Struct_22();
            }
            public Struct_22(string Member0)
            {
                this.Member0 = Member0;
            }
        }
        public struct Struct_23 : NtApiDotNet.Ndr.Marshal.INdrStructure
        {
            void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
            {
                Marshal(((_Marshal_Helper)(m)));
            }
            private void Marshal(_Marshal_Helper m)
            {
                m.WriteInt32(Member0);
                m.WriteEmbeddedPointer<string>(Member8, new System.Action<string>(m.WriteTerminatedString));
                m.WriteEmbeddedPointer<string>(Member10, new System.Action<string>(m.WriteTerminatedString));
                m.WriteInt32(Member18);
                m.WriteEmbeddedPointer<Struct_11[], long>(Member20, new System.Action<Struct_11[], long>(m.Write_46), Member18);
            }
            void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
            {
                Unmarshal(((_Unmarshal_Helper)(u)));
            }
            private void Unmarshal(_Unmarshal_Helper u)
            {
                Member0 = u.ReadInt32();
                Member8 = u.ReadEmbeddedPointer<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
                Member10 = u.ReadEmbeddedPointer<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
                Member18 = u.ReadInt32();
                Member20 = u.ReadEmbeddedPointer<Struct_11[]>(new System.Func<Struct_11[]>(u.Read_46), false);
            }
            int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
            {
                return 4;
            }
            public int Member0;
            public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<string> Member8;
            public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<string> Member10;
            public int Member18;
            public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<Struct_11[]> Member20;
            public static Struct_23 CreateDefault()
            {
                return new Struct_23();
            }
            public Struct_23(int Member0, string Member8, string Member10, int Member18, Struct_11[] Member20)
            {
                this.Member0 = Member0;
                this.Member8 = Member8;
                this.Member10 = Member10;
                this.Member18 = Member18;
                this.Member20 = Member20;
            }
        }
        public struct Union_24 : NtApiDotNet.Ndr.Marshal.INdrNonEncapsulatedUnion
        {
            void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
            {
                throw new System.NotImplementedException();
            }
            void NtApiDotNet.Ndr.Marshal.INdrNonEncapsulatedUnion.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m, long l)
            {
                Selector = ((uint)(l));
                Marshal(((_Marshal_Helper)(m)));
            }
            private void Marshal(_Marshal_Helper m)
            {
                m.WriteUInt32(Selector);
                if ((Selector == 1))
                {
                    m.WriteEmbeddedPointer<Struct_25>(Arm_1, new System.Action<Struct_25>(m.Write_24));
                    goto done;
                }
                if ((Selector == 2))
                {
                    m.WriteEmbeddedPointer<Struct_26>(Arm_2, new System.Action<Struct_26>(m.Write_25));
                    goto done;
                }
                if ((Selector == 3))
                {
                    m.WriteEmbeddedPointer<Struct_12>(Arm_3, new System.Action<Struct_12>(m.Write_12));
                    goto done;
                }
                throw new System.ArgumentException("No matching union selector when marshaling Union_24");
                done:
                return;
            }
            void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
            {
                Unmarshal(((_Unmarshal_Helper)(u)));
            }
            private void Unmarshal(_Unmarshal_Helper u)
            {
                Selector = u.ReadUInt32();
                if ((Selector == 1))
                {
                    Arm_1 = u.ReadEmbeddedPointer<Struct_25>(new System.Func<Struct_25>(u.Read_24), false);
                    goto done;
                }
                if ((Selector == 2))
                {
                    Arm_2 = u.ReadEmbeddedPointer<Struct_26>(new System.Func<Struct_26>(u.Read_25), false);
                    goto done;
                }
                if ((Selector == 3))
                {
                    Arm_3 = u.ReadEmbeddedPointer<Struct_12>(new System.Func<Struct_12>(u.Read_12), false);
                    goto done;
                }
                throw new System.ArgumentException("No matching union selector when marshaling Union_24");
                done:
                return;
            }
            int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
            {
                return 4;
            }
            private uint Selector;
            public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<Struct_25> Arm_1;
            public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<Struct_26> Arm_2;
            public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<Struct_12> Arm_3;
            public static Union_24 CreateDefault()
            {
                return new Union_24();
            }
            public Union_24(uint Selector, System.Nullable<Struct_25> Arm_1, System.Nullable<Struct_26> Arm_2, System.Nullable<Struct_12> Arm_3)
            {
                this.Selector = Selector;
                this.Arm_1 = Arm_1;
                this.Arm_2 = Arm_2;
                this.Arm_3 = Arm_3;
            }
        }
        public struct Struct_25 : NtApiDotNet.Ndr.Marshal.INdrStructure
        {
            void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
            {
                Marshal(((_Marshal_Helper)(m)));
            }
            private void Marshal(_Marshal_Helper m)
            {
                m.WriteInt32(Member0);
                m.WriteInt32(Member4);
            }
            void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
            {
                Unmarshal(((_Unmarshal_Helper)(u)));
            }
            private void Unmarshal(_Unmarshal_Helper u)
            {
                Member0 = u.ReadInt32();
                Member4 = u.ReadInt32();
            }
            int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
            {
                return 4;
            }
            public int Member0;
            public int Member4;
            public static Struct_25 CreateDefault()
            {
                return new Struct_25();
            }
            public Struct_25(int Member0, int Member4)
            {
                this.Member0 = Member0;
                this.Member4 = Member4;
            }
        }
        public struct Struct_26 : NtApiDotNet.Ndr.Marshal.INdrStructure
        {
            void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
            {
                Marshal(((_Marshal_Helper)(m)));
            }
            private void Marshal(_Marshal_Helper m)
            {
                m.WriteInt32(Member0);
                m.WriteEmbeddedPointer<string>(Member8, new System.Action<string>(m.WriteTerminatedString));
            }
            void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
            {
                Unmarshal(((_Unmarshal_Helper)(u)));
            }
            private void Unmarshal(_Unmarshal_Helper u)
            {
                Member0 = u.ReadInt32();
                Member8 = u.ReadEmbeddedPointer<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            }
            int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
            {
                return 4;
            }
            public int Member0;
            public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<string> Member8;
            public static Struct_26 CreateDefault()
            {
                return new Struct_26();
            }
            public Struct_26(int Member0, string Member8)
            {
                this.Member0 = Member0;
                this.Member8 = Member8;
            }
        }
        public struct Union_27 : NtApiDotNet.Ndr.Marshal.INdrNonEncapsulatedUnion
        {
            void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
            {
                throw new System.NotImplementedException();
            }
            void NtApiDotNet.Ndr.Marshal.INdrNonEncapsulatedUnion.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m, long l)
            {
                Selector = ((uint)(l));
                Marshal(((_Marshal_Helper)(m)));
            }
            private void Marshal(_Marshal_Helper m)
            {
                m.WriteUInt32(Selector);
                if ((Selector == 1))
                {
                    m.WriteEmbeddedPointer<Struct_28>(Arm_1, new System.Action<Struct_28>(m.Write_27));
                    goto done;
                }
                if ((Selector == 2))
                {
                    m.WriteEmbeddedPointer<Struct_29>(Arm_2, new System.Action<Struct_29>(m.Write_28));
                    goto done;
                }
                if ((Selector == 3))
                {
                    m.WriteEmbeddedPointer<Struct_30>(Arm_3, new System.Action<Struct_30>(m.Write_29));
                    goto done;
                }
                throw new System.ArgumentException("No matching union selector when marshaling Union_27");
                done:
                return;
            }
            void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
            {
                Unmarshal(((_Unmarshal_Helper)(u)));
            }
            private void Unmarshal(_Unmarshal_Helper u)
            {
                Selector = u.ReadUInt32();
                if ((Selector == 1))
                {
                    Arm_1 = u.ReadEmbeddedPointer<Struct_28>(new System.Func<Struct_28>(u.Read_27), false);
                    goto done;
                }
                if ((Selector == 2))
                {
                    Arm_2 = u.ReadEmbeddedPointer<Struct_29>(new System.Func<Struct_29>(u.Read_28), false);
                    goto done;
                }
                if ((Selector == 3))
                {
                    Arm_3 = u.ReadEmbeddedPointer<Struct_30>(new System.Func<Struct_30>(u.Read_29), false);
                    goto done;
                }
                throw new System.ArgumentException("No matching union selector when marshaling Union_27");
                done:
                return;
            }
            int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
            {
                return 4;
            }
            private uint Selector;
            public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<Struct_28> Arm_1;
            public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<Struct_29> Arm_2;
            public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<Struct_30> Arm_3;
            public static Union_27 CreateDefault()
            {
                return new Union_27();
            }
            public Union_27(uint Selector, System.Nullable<Struct_28> Arm_1, System.Nullable<Struct_29> Arm_2, System.Nullable<Struct_30> Arm_3)
            {
                this.Selector = Selector;
                this.Arm_1 = Arm_1;
                this.Arm_2 = Arm_2;
                this.Arm_3 = Arm_3;
            }
        }
        public struct Struct_28 : NtApiDotNet.Ndr.Marshal.INdrStructure
        {
            void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
            {
                Marshal(((_Marshal_Helper)(m)));
            }
            private void Marshal(_Marshal_Helper m)
            {
                m.WriteInt32(Member0);
                m.WriteEmbeddedPointer<string>(Member8, new System.Action<string>(m.WriteTerminatedString));
            }
            void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
            {
                Unmarshal(((_Unmarshal_Helper)(u)));
            }
            private void Unmarshal(_Unmarshal_Helper u)
            {
                Member0 = u.ReadInt32();
                Member8 = u.ReadEmbeddedPointer<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            }
            int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
            {
                return 4;
            }
            public int Member0;
            public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<string> Member8;
            public static Struct_28 CreateDefault()
            {
                return new Struct_28();
            }
            public Struct_28(int Member0, string Member8)
            {
                this.Member0 = Member0;
                this.Member8 = Member8;
            }
        }
        public struct Struct_29 : NtApiDotNet.Ndr.Marshal.INdrStructure
        {
            void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
            {
                Marshal(((_Marshal_Helper)(m)));
            }
            private void Marshal(_Marshal_Helper m)
            {
                m.WriteInt32(Member0);
                m.WriteEmbeddedPointer<string>(Member8, new System.Action<string>(m.WriteTerminatedString));
            }
            void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
            {
                Unmarshal(((_Unmarshal_Helper)(u)));
            }
            private void Unmarshal(_Unmarshal_Helper u)
            {
                Member0 = u.ReadInt32();
                Member8 = u.ReadEmbeddedPointer<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            }
            int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
            {
                return 4;
            }
            public int Member0;
            public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<string> Member8;
            public static Struct_29 CreateDefault()
            {
                return new Struct_29();
            }
            public Struct_29(int Member0, string Member8)
            {
                this.Member0 = Member0;
                this.Member8 = Member8;
            }
        }
        public struct Struct_30 : NtApiDotNet.Ndr.Marshal.INdrStructure
        {
            void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
            {
                Marshal(((_Marshal_Helper)(m)));
            }
            private void Marshal(_Marshal_Helper m)
            {
                m.WriteInt32(Member0);
                m.WriteEmbeddedPointer<Struct_31[], long>(Member8, new System.Action<Struct_31[], long>(m.Write_51), Member0);
            }
            void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
            {
                Unmarshal(((_Unmarshal_Helper)(u)));
            }
            private void Unmarshal(_Unmarshal_Helper u)
            {
                Member0 = u.ReadInt32();
                Member8 = u.ReadEmbeddedPointer<Struct_31[]>(new System.Func<Struct_31[]>(u.Read_51), false);
            }
            int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
            {
                return 4;
            }
            public int Member0;
            public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<Struct_31[]> Member8;
            public static Struct_30 CreateDefault()
            {
                return new Struct_30();
            }
            public Struct_30(int Member0, Struct_31[] Member8)
            {
                this.Member0 = Member0;
                this.Member8 = Member8;
            }
        }
        public struct Struct_31 : NtApiDotNet.Ndr.Marshal.INdrStructure
        {
            void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
            {
                Marshal(((_Marshal_Helper)(m)));
            }
            private void Marshal(_Marshal_Helper m)
            {
                m.WriteInt32(Member0);
                m.WriteInt32(Member4);
                m.WriteEmbeddedPointer<string>(Member8, new System.Action<string>(m.WriteTerminatedString));
                m.WriteEmbeddedPointer<string>(Member10, new System.Action<string>(m.WriteTerminatedString));
            }
            void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
            {
                Unmarshal(((_Unmarshal_Helper)(u)));
            }
            private void Unmarshal(_Unmarshal_Helper u)
            {
                Member0 = u.ReadInt32();
                Member4 = u.ReadInt32();
                Member8 = u.ReadEmbeddedPointer<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
                Member10 = u.ReadEmbeddedPointer<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            }
            int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
            {
                return 4;
            }
            public int Member0;
            public int Member4;
            public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<string> Member8;
            public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<string> Member10;
            public static Struct_31 CreateDefault()
            {
                return new Struct_31();
            }
            public Struct_31(int Member0, int Member4, string Member8, string Member10)
            {
                this.Member0 = Member0;
                this.Member4 = Member4;
                this.Member8 = Member8;
                this.Member10 = Member10;
            }
        }
        public struct Struct_32 : NtApiDotNet.Ndr.Marshal.INdrStructure
        {
            void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
            {
                Marshal(((_Marshal_Helper)(m)));
            }
            private void Marshal(_Marshal_Helper m)
            {
                m.WriteInt32(Member0);
                m.Write_32(Member8, Member0);
            }
            void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
            {
                Unmarshal(((_Unmarshal_Helper)(u)));
            }
            private void Unmarshal(_Unmarshal_Helper u)
            {
                Member0 = u.ReadInt32();
                Member8 = u.Read_32();
            }
            int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
            {
                return 4;
            }
            public int Member0;
            public Union_33 Member8;
            public static Struct_32 CreateDefault()
            {
                return new Struct_32();
            }
            public Struct_32(int Member0, Union_33 Member8)
            {
                this.Member0 = Member0;
                this.Member8 = Member8;
            }
        }
        public struct Union_33 : NtApiDotNet.Ndr.Marshal.INdrNonEncapsulatedUnion
        {
            void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
            {
                throw new System.NotImplementedException();
            }
            void NtApiDotNet.Ndr.Marshal.INdrNonEncapsulatedUnion.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m, long l)
            {
                Selector = ((uint)(l));
                Marshal(((_Marshal_Helper)(m)));
            }
            private void Marshal(_Marshal_Helper m)
            {
                m.WriteUInt32(Selector);
                if ((Selector == 1))
                {
                    m.WriteEmbeddedPointer<Struct_34>(Arm_1, new System.Action<Struct_34>(m.Write_33));
                    goto done;
                }
                if ((Selector == 2))
                {
                    m.WriteEmbeddedPointer<Struct_36>(Arm_2, new System.Action<Struct_36>(m.Write_35));
                    goto done;
                }
                throw new System.ArgumentException("No matching union selector when marshaling Union_33");
                done:
                return;
            }
            void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
            {
                Unmarshal(((_Unmarshal_Helper)(u)));
            }
            private void Unmarshal(_Unmarshal_Helper u)
            {
                Selector = u.ReadUInt32();
                if ((Selector == 1))
                {
                    Arm_1 = u.ReadEmbeddedPointer<Struct_34>(new System.Func<Struct_34>(u.Read_33), false);
                    goto done;
                }
                if ((Selector == 2))
                {
                    Arm_2 = u.ReadEmbeddedPointer<Struct_36>(new System.Func<Struct_36>(u.Read_35), false);
                    goto done;
                }
                throw new System.ArgumentException("No matching union selector when marshaling Union_33");
                done:
                return;
            }
            int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
            {
                return 4;
            }
            private uint Selector;
            public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<Struct_34> Arm_1;
            public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<Struct_36> Arm_2;
            public static Union_33 CreateDefault()
            {
                return new Union_33();
            }
            public Union_33(uint Selector, System.Nullable<Struct_34> Arm_1, System.Nullable<Struct_36> Arm_2)
            {
                this.Selector = Selector;
                this.Arm_1 = Arm_1;
                this.Arm_2 = Arm_2;
            }
        }
        public struct Struct_34 : NtApiDotNet.Ndr.Marshal.INdrStructure
        {
            void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
            {
                Marshal(((_Marshal_Helper)(m)));
            }
            private void Marshal(_Marshal_Helper m)
            {
                m.WriteInt64(Member0);
                m.WriteInt32(Member8);
                m.Write_52(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(MemberC, "MemberC"));
                m.Write_52(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member1C, "Member1C"));
                m.Write_34(Member2C);
                m.WriteInt32(Member50);
                m.WriteInt32(Member54);
            }
            void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
            {
                Unmarshal(((_Unmarshal_Helper)(u)));
            }
            private void Unmarshal(_Unmarshal_Helper u)
            {
                Member0 = u.ReadInt64();
                Member8 = u.ReadInt32();
                MemberC = u.Read_52();
                Member1C = u.Read_52();
                Member2C = u.Read_34();
                Member50 = u.ReadInt32();
                Member54 = u.ReadInt32();
            }
            int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
            {
                return 8;
            }
            public long Member0;
            public int Member8;
            public sbyte[] MemberC;
            public sbyte[] Member1C;
            public Struct_35 Member2C;
            public int Member50;
            public int Member54;
            public static Struct_34 CreateDefault()
            {
                Struct_34 ret = new Struct_34();
                ret.MemberC = new sbyte[16];
                ret.Member1C = new sbyte[16];
                return ret;
            }
            public Struct_34(long Member0, int Member8, sbyte[] MemberC, sbyte[] Member1C, Struct_35 Member2C, int Member50, int Member54)
            {
                this.Member0 = Member0;
                this.Member8 = Member8;
                this.MemberC = MemberC;
                this.Member1C = Member1C;
                this.Member2C = Member2C;
                this.Member50 = Member50;
                this.Member54 = Member54;
            }
        }
        public struct Struct_35 : NtApiDotNet.Ndr.Marshal.INdrStructure
        {
            void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
            {
                Marshal(((_Marshal_Helper)(m)));
            }
            private void Marshal(_Marshal_Helper m)
            {
                m.WriteInt32(Member0);
                m.WriteInt32(Member4);
                m.WriteInt32(Member8);
                m.WriteInt32(MemberC);
                m.WriteInt32(Member10);
                m.WriteInt32(Member14);
                m.WriteInt32(Member18);
                m.WriteInt32(Member1C);
                m.WriteInt32(Member20);
            }
            void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
            {
                Unmarshal(((_Unmarshal_Helper)(u)));
            }
            private void Unmarshal(_Unmarshal_Helper u)
            {
                Member0 = u.ReadInt32();
                Member4 = u.ReadInt32();
                Member8 = u.ReadInt32();
                MemberC = u.ReadInt32();
                Member10 = u.ReadInt32();
                Member14 = u.ReadInt32();
                Member18 = u.ReadInt32();
                Member1C = u.ReadInt32();
                Member20 = u.ReadInt32();
            }
            int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
            {
                return 4;
            }
            public int Member0;
            public int Member4;
            public int Member8;
            public int MemberC;
            public int Member10;
            public int Member14;
            public int Member18;
            public int Member1C;
            public int Member20;
            public static Struct_35 CreateDefault()
            {
                return new Struct_35();
            }
            public Struct_35(int Member0, int Member4, int Member8, int MemberC, int Member10, int Member14, int Member18, int Member1C, int Member20)
            {
                this.Member0 = Member0;
                this.Member4 = Member4;
                this.Member8 = Member8;
                this.MemberC = MemberC;
                this.Member10 = Member10;
                this.Member14 = Member14;
                this.Member18 = Member18;
                this.Member1C = Member1C;
                this.Member20 = Member20;
            }
        }
        public struct Struct_36 : NtApiDotNet.Ndr.Marshal.INdrStructure
        {
            void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
            {
                Marshal(((_Marshal_Helper)(m)));
            }
            private void Marshal(_Marshal_Helper m)
            {
                m.WriteInt64(Member0);
                m.WriteInt32(Member8);
                m.Write_52(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(MemberC, "MemberC"));
                m.Write_52(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member1C, "Member1C"));
                m.Write_34(Member2C);
                m.WriteInt32(Member50);
                m.WriteInt32(Member54);
                m.WriteInt32(Member58);
                m.WriteEmbeddedPointer<string>(Member60, new System.Action<string>(m.WriteTerminatedString));
            }
            void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
            {
                Unmarshal(((_Unmarshal_Helper)(u)));
            }
            private void Unmarshal(_Unmarshal_Helper u)
            {
                Member0 = u.ReadInt64();
                Member8 = u.ReadInt32();
                MemberC = u.Read_52();
                Member1C = u.Read_52();
                Member2C = u.Read_34();
                Member50 = u.ReadInt32();
                Member54 = u.ReadInt32();
                Member58 = u.ReadInt32();
                Member60 = u.ReadEmbeddedPointer<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            }
            int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
            {
                return 8;
            }
            public long Member0;
            public int Member8;
            public sbyte[] MemberC;
            public sbyte[] Member1C;
            public Struct_35 Member2C;
            public int Member50;
            public int Member54;
            public int Member58;
            public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<string> Member60;
            public static Struct_36 CreateDefault()
            {
                Struct_36 ret = new Struct_36();
                ret.MemberC = new sbyte[16];
                ret.Member1C = new sbyte[16];
                return ret;
            }
            public Struct_36(long Member0, int Member8, sbyte[] MemberC, sbyte[] Member1C, Struct_35 Member2C, int Member50, int Member54, int Member58, string Member60)
            {
                this.Member0 = Member0;
                this.Member8 = Member8;
                this.MemberC = MemberC;
                this.Member1C = Member1C;
                this.Member2C = Member2C;
                this.Member50 = Member50;
                this.Member54 = Member54;
                this.Member58 = Member58;
                this.Member60 = Member60;
            }
        }
        public struct Struct_37 : NtApiDotNet.Ndr.Marshal.INdrConformantStructure
        {
            void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
            {
                Marshal(((_Marshal_Helper)(m)));
            }
            private void Marshal(_Marshal_Helper m)
            {
                m.WriteInt32(Member0);
                m.Write_53(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member8, "Member8"), Member0);
            }
            void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
            {
                Unmarshal(((_Unmarshal_Helper)(u)));
            }
            private void Unmarshal(_Unmarshal_Helper u)
            {
                Member0 = u.ReadInt32();
                Member8 = u.Read_53();
            }
            int NtApiDotNet.Ndr.Marshal.INdrConformantStructure.GetConformantDimensions()
            {
                return 1;
            }
            int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
            {
                return 4;
            }
            public int Member0;
            public Struct_32[] Member8;
            public static Struct_37 CreateDefault()
            {
                Struct_37 ret = new Struct_37();
                ret.Member8 = new Struct_32[0];
                return ret;
            }
            public Struct_37(int Member0, Struct_32[] Member8)
            {
                this.Member0 = Member0;
                this.Member8 = Member8;
            }
        }
        public struct Union_38 : NtApiDotNet.Ndr.Marshal.INdrNonEncapsulatedUnion
        {
            void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
            {
                throw new System.NotImplementedException();
            }
            void NtApiDotNet.Ndr.Marshal.INdrNonEncapsulatedUnion.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m, long l)
            {
                Selector = ((uint)(l));
                Marshal(((_Marshal_Helper)(m)));
            }
            private void Marshal(_Marshal_Helper m)
            {
                m.WriteUInt32(Selector);
                if ((Selector == 1))
                {
                    m.WriteEmbeddedPointer<Struct_39>(Arm_1, new System.Action<Struct_39>(m.Write_38));
                    goto done;
                }
                throw new System.ArgumentException("No matching union selector when marshaling Union_38");
                done:
                return;
            }
            void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
            {
                Unmarshal(((_Unmarshal_Helper)(u)));
            }
            private void Unmarshal(_Unmarshal_Helper u)
            {
                Selector = u.ReadUInt32();
                if ((Selector == 1))
                {
                    Arm_1 = u.ReadEmbeddedPointer<Struct_39>(new System.Func<Struct_39>(u.Read_38), false);
                    goto done;
                }
                throw new System.ArgumentException("No matching union selector when marshaling Union_38");
                done:
                return;
            }
            int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
            {
                return 4;
            }
            private uint Selector;
            public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<Struct_39> Arm_1;
            public static Union_38 CreateDefault()
            {
                return new Union_38();
            }
            public Union_38(uint Selector, System.Nullable<Struct_39> Arm_1)
            {
                this.Selector = Selector;
                this.Arm_1 = Arm_1;
            }
        }
        public struct Struct_39 : NtApiDotNet.Ndr.Marshal.INdrStructure
        {
            void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
            {
                Marshal(((_Marshal_Helper)(m)));
            }
            private void Marshal(_Marshal_Helper m)
            {
                m.WriteInt32(Member0);
                m.WriteEmbeddedPointer<string>(Member8, new System.Action<string>(m.WriteTerminatedAnsiString));
            }
            void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
            {
                Unmarshal(((_Unmarshal_Helper)(u)));
            }
            private void Unmarshal(_Unmarshal_Helper u)
            {
                Member0 = u.ReadInt32();
                Member8 = u.ReadEmbeddedPointer<string>(new System.Func<string>(u.ReadConformantVaryingAnsiString), false);
            }
            int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
            {
                return 4;
            }
            public int Member0;
            public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<string> Member8;
            public static Struct_39 CreateDefault()
            {
                return new Struct_39();
            }
            public Struct_39(int Member0, string Member8)
            {
                this.Member0 = Member0;
                this.Member8 = Member8;
            }
        }
        public struct Union_40 : NtApiDotNet.Ndr.Marshal.INdrNonEncapsulatedUnion
        {
            void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
            {
                throw new System.NotImplementedException();
            }
            void NtApiDotNet.Ndr.Marshal.INdrNonEncapsulatedUnion.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m, long l)
            {
                Selector = ((uint)(l));
                Marshal(((_Marshal_Helper)(m)));
            }
            private void Marshal(_Marshal_Helper m)
            {
                m.WriteUInt32(Selector);
                if ((Selector == 1))
                {
                    m.WriteEmbeddedPointer<Struct_41>(Arm_1, new System.Action<Struct_41>(m.Write_40));
                    goto done;
                }
                throw new System.ArgumentException("No matching union selector when marshaling Union_40");
                done:
                return;
            }
            void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
            {
                Unmarshal(((_Unmarshal_Helper)(u)));
            }
            private void Unmarshal(_Unmarshal_Helper u)
            {
                Selector = u.ReadUInt32();
                if ((Selector == 1))
                {
                    Arm_1 = u.ReadEmbeddedPointer<Struct_41>(new System.Func<Struct_41>(u.Read_40), false);
                    goto done;
                }
                throw new System.ArgumentException("No matching union selector when marshaling Union_40");
                done:
                return;
            }
            int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
            {
                return 4;
            }
            private uint Selector;
            public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<Struct_41> Arm_1;
            public static Union_40 CreateDefault()
            {
                return new Union_40();
            }
            public Union_40(uint Selector, System.Nullable<Struct_41> Arm_1)
            {
                this.Selector = Selector;
                this.Arm_1 = Arm_1;
            }
        }
        public struct Struct_41 : NtApiDotNet.Ndr.Marshal.INdrStructure
        {
            void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
            {
                Marshal(((_Marshal_Helper)(m)));
            }
            private void Marshal(_Marshal_Helper m)
            {
                m.Write_34(Member0);
            }
            void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
            {
                Unmarshal(((_Unmarshal_Helper)(u)));
            }
            private void Unmarshal(_Unmarshal_Helper u)
            {
                Member0 = u.Read_34();
            }
            int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
            {
                return 4;
            }
            public Struct_35 Member0;
            public static Struct_41 CreateDefault()
            {
                return new Struct_41();
            }
            public Struct_41(Struct_35 Member0)
            {
                this.Member0 = Member0;
            }
        }
        public struct Union_42 : NtApiDotNet.Ndr.Marshal.INdrNonEncapsulatedUnion
        {
            void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
            {
                throw new System.NotImplementedException();
            }
            void NtApiDotNet.Ndr.Marshal.INdrNonEncapsulatedUnion.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m, long l)
            {
                Selector = ((uint)(l));
                Marshal(((_Marshal_Helper)(m)));
            }
            private void Marshal(_Marshal_Helper m)
            {
                m.WriteUInt32(Selector);
                if ((Selector == 1))
                {
                    m.WriteEmbeddedPointer<Struct_43>(Arm_1, new System.Action<Struct_43>(m.Write_42));
                    goto done;
                }
                throw new System.ArgumentException("No matching union selector when marshaling Union_42");
                done:
                return;
            }
            void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
            {
                Unmarshal(((_Unmarshal_Helper)(u)));
            }
            private void Unmarshal(_Unmarshal_Helper u)
            {
                Selector = u.ReadUInt32();
                if ((Selector == 1))
                {
                    Arm_1 = u.ReadEmbeddedPointer<Struct_43>(new System.Func<Struct_43>(u.Read_42), false);
                    goto done;
                }
                throw new System.ArgumentException("No matching union selector when marshaling Union_42");
                done:
                return;
            }
            int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
            {
                return 4;
            }
            private uint Selector;
            public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<Struct_43> Arm_1;
            public static Union_42 CreateDefault()
            {
                return new Union_42();
            }
            public Union_42(uint Selector, System.Nullable<Struct_43> Arm_1)
            {
                this.Selector = Selector;
                this.Arm_1 = Arm_1;
            }
        }
        public struct Struct_43 : NtApiDotNet.Ndr.Marshal.INdrStructure
        {
            void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
            {
                Marshal(((_Marshal_Helper)(m)));
            }
            private void Marshal(_Marshal_Helper m)
            {
                m.WriteInt32(Member0);
                m.WriteEmbeddedPointer<string>(Member8, new System.Action<string>(m.WriteTerminatedString));
            }
            void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
            {
                Unmarshal(((_Unmarshal_Helper)(u)));
            }
            private void Unmarshal(_Unmarshal_Helper u)
            {
                Member0 = u.ReadInt32();
                Member8 = u.ReadEmbeddedPointer<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            }
            int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
            {
                return 4;
            }
            public int Member0;
            public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<string> Member8;
            public static Struct_43 CreateDefault()
            {
                return new Struct_43();
            }
            public Struct_43(int Member0, string Member8)
            {
                this.Member0 = Member0;
                this.Member8 = Member8;
            }
        }
        public struct Union_44 : NtApiDotNet.Ndr.Marshal.INdrNonEncapsulatedUnion
        {
            void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
            {
                throw new System.NotImplementedException();
            }
            void NtApiDotNet.Ndr.Marshal.INdrNonEncapsulatedUnion.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m, long l)
            {
                Selector = ((uint)(l));
                Marshal(((_Marshal_Helper)(m)));
            }
            private void Marshal(_Marshal_Helper m)
            {
                m.WriteUInt32(Selector);
                if ((Selector == 1))
                {
                    m.WriteEmbeddedPointer<Struct_41>(Arm_1, new System.Action<Struct_41>(m.Write_40));
                    goto done;
                }
                throw new System.ArgumentException("No matching union selector when marshaling Union_44");
                done:
                return;
            }
            void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
            {
                Unmarshal(((_Unmarshal_Helper)(u)));
            }
            private void Unmarshal(_Unmarshal_Helper u)
            {
                Selector = u.ReadUInt32();
                if ((Selector == 1))
                {
                    Arm_1 = u.ReadEmbeddedPointer<Struct_41>(new System.Func<Struct_41>(u.Read_40), false);
                    goto done;
                }
                throw new System.ArgumentException("No matching union selector when marshaling Union_44");
                done:
                return;
            }
            int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
            {
                return 4;
            }
            private uint Selector;
            public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<Struct_41> Arm_1;
            public static Union_44 CreateDefault()
            {
                return new Union_44();
            }
            public Union_44(uint Selector, System.Nullable<Struct_41> Arm_1)
            {
                this.Selector = Selector;
                this.Arm_1 = Arm_1;
            }
        }
        public struct Union_45 : NtApiDotNet.Ndr.Marshal.INdrNonEncapsulatedUnion
        {
            void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
            {
                throw new System.NotImplementedException();
            }
            void NtApiDotNet.Ndr.Marshal.INdrNonEncapsulatedUnion.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m, long l)
            {
                Selector = ((uint)(l));
                Marshal(((_Marshal_Helper)(m)));
            }
            private void Marshal(_Marshal_Helper m)
            {
                m.WriteUInt32(Selector);
                if ((Selector == 1))
                {
                    m.WriteEmbeddedPointer<Struct_46>(Arm_1, new System.Action<Struct_46>(m.Write_45));
                    goto done;
                }
                if ((Selector == 2))
                {
                    m.WriteEmbeddedPointer<long>(Arm_2, new System.Action<long>(m.WriteInt64));
                    goto done;
                }
                if ((Selector == 3))
                {
                    m.WriteEmbeddedPointer<long>(Arm_3, new System.Action<long>(m.WriteInt64));
                    goto done;
                }
                if ((Selector == 4))
                {
                    m.WriteEmbeddedPointer<long>(Arm_4, new System.Action<long>(m.WriteInt64));
                    goto done;
                }
                throw new System.ArgumentException("No matching union selector when marshaling Union_45");
                done:
                return;
            }
            void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
            {
                Unmarshal(((_Unmarshal_Helper)(u)));
            }
            private void Unmarshal(_Unmarshal_Helper u)
            {
                Selector = u.ReadUInt32();
                if ((Selector == 1))
                {
                    Arm_1 = u.ReadEmbeddedPointer<Struct_46>(new System.Func<Struct_46>(u.Read_45), false);
                    goto done;
                }
                if ((Selector == 2))
                {
                    Arm_2 = u.ReadEmbeddedPointer<long>(new System.Func<long>(u.ReadInt64), false);
                    goto done;
                }
                if ((Selector == 3))
                {
                    Arm_3 = u.ReadEmbeddedPointer<long>(new System.Func<long>(u.ReadInt64), false);
                    goto done;
                }
                if ((Selector == 4))
                {
                    Arm_4 = u.ReadEmbeddedPointer<long>(new System.Func<long>(u.ReadInt64), false);
                    goto done;
                }
                throw new System.ArgumentException("No matching union selector when marshaling Union_45");
                done:
                return;
            }
            int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
            {
                return 4;
            }
            private uint Selector;
            public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<Struct_46> Arm_1;
            public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<long> Arm_2;
            public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<long> Arm_3;
            public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<long> Arm_4;
            public static Union_45 CreateDefault()
            {
                return new Union_45();
            }
            public Union_45(uint Selector, System.Nullable<Struct_46> Arm_1, System.Nullable<long> Arm_2, System.Nullable<long> Arm_3, System.Nullable<long> Arm_4)
            {
                this.Selector = Selector;
                this.Arm_1 = Arm_1;
                this.Arm_2 = Arm_2;
                this.Arm_3 = Arm_3;
                this.Arm_4 = Arm_4;
            }
        }
        public struct Struct_46 : NtApiDotNet.Ndr.Marshal.INdrStructure
        {
            void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
            {
                Marshal(((_Marshal_Helper)(m)));
            }
            private void Marshal(_Marshal_Helper m)
            {
                m.WriteEmbeddedPointer<string>(Member0, new System.Action<string>(m.WriteTerminatedString));
                m.WriteEmbeddedPointer<string>(Member8, new System.Action<string>(m.WriteTerminatedString));
                m.WriteEmbeddedPointer<string>(Member10, new System.Action<string>(m.WriteTerminatedString));
            }
            void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
            {
                Unmarshal(((_Unmarshal_Helper)(u)));
            }
            private void Unmarshal(_Unmarshal_Helper u)
            {
                Member0 = u.ReadEmbeddedPointer<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
                Member8 = u.ReadEmbeddedPointer<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
                Member10 = u.ReadEmbeddedPointer<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            }
            int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
            {
                return 4;
            }
            public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<string> Member0;
            public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<string> Member8;
            public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<string> Member10;
            public static Struct_46 CreateDefault()
            {
                return new Struct_46();
            }
            public Struct_46(string Member0, string Member8, string Member10)
            {
                this.Member0 = Member0;
                this.Member8 = Member8;
                this.Member10 = Member10;
            }
        }
        #endregion
        #region Client Implementation
        public sealed class Client : NtApiDotNet.Win32.Rpc.RpcClientBase
        {
            public Client() :
                    base("367abb81-9844-35f1-ad32-98f038001003", 2, 0)
            {
            }
            private _Unmarshal_Helper SendReceive(int p, _Marshal_Helper m)
            {
                return new _Unmarshal_Helper(SendReceive(p, m.DataRepresentation, m.ToArray(), m.Handles));
            }
            public int RCloseServiceHandle(ref NtApiDotNet.Ndr.Marshal.NdrContextHandle p0)
            {
                _Marshal_Helper m = new _Marshal_Helper();
                m.WriteContextHandle(p0);
                _Unmarshal_Helper u = SendReceive(0, m);
                p0 = u.ReadContextHandle();
                return u.ReadInt32();
            }
            public int RControlService(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, out Struct_0 p2)
            {
                _Marshal_Helper m = new _Marshal_Helper();
                m.WriteContextHandle(p0);
                m.WriteInt32(p1);
                _Unmarshal_Helper u = SendReceive(1, m);
                p2 = u.Read_0();
                return u.ReadInt32();
            }
            public int RDeleteService(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0)
            {
                _Marshal_Helper m = new _Marshal_Helper();
                m.WriteContextHandle(p0);
                _Unmarshal_Helper u = SendReceive(2, m);
                return u.ReadInt32();
            }
            public int RLockServiceDatabase(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, out NtApiDotNet.Ndr.Marshal.NdrContextHandle p1)
            {
                _Marshal_Helper m = new _Marshal_Helper();
                m.WriteContextHandle(p0);
                _Unmarshal_Helper u = SendReceive(3, m);
                p1 = u.ReadContextHandle();
                return u.ReadInt32();
            }
            public int RQueryServiceObjectSecurity(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, out sbyte[] p2, int p3, out int p4)
            {
                _Marshal_Helper m = new _Marshal_Helper();
                m.WriteContextHandle(p0);
                m.WriteInt32(p1);
                m.WriteInt32(p3);
                _Unmarshal_Helper u = SendReceive(4, m);
                p2 = u.Read_54();
                p4 = u.ReadInt32();
                return u.ReadInt32();
            }
            public int RSetServiceObjectSecurity(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, sbyte[] p2, int p3)
            {
                _Marshal_Helper m = new _Marshal_Helper();
                m.WriteContextHandle(p0);
                m.WriteInt32(p1);
                m.Write_55(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p2, "p2"), p3);
                m.WriteInt32(p3);
                _Unmarshal_Helper u = SendReceive(5, m);
                return u.ReadInt32();
            }
            public int RQueryServiceStatus(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, out Struct_0 p1)
            {
                _Marshal_Helper m = new _Marshal_Helper();
                m.WriteContextHandle(p0);
                _Unmarshal_Helper u = SendReceive(6, m);
                p1 = u.Read_0();
                return u.ReadInt32();
            }
            public int RSetServiceStatus(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, Struct_0 p1)
            {
                _Marshal_Helper m = new _Marshal_Helper();
                m.WriteContextHandle(p0);
                m.Write_0(p1);
                _Unmarshal_Helper u = SendReceive(7, m);
                return u.ReadInt32();
            }
            public int RUnlockServiceDatabase(ref NtApiDotNet.Ndr.Marshal.NdrContextHandle p0)
            {
                _Marshal_Helper m = new _Marshal_Helper();
                m.WriteContextHandle(p0);
                _Unmarshal_Helper u = SendReceive(8, m);
                p0 = u.ReadContextHandle();
                return u.ReadInt32();
            }
            public int RNotifyBootConfigStatus(string p0, int p1)
            {
                _Marshal_Helper m = new _Marshal_Helper();
                m.WriteReferent(p0, new System.Action<string>(m.WriteTerminatedString));
                m.WriteInt32(p1);
                _Unmarshal_Helper u = SendReceive(9, m);
                return u.ReadInt32();
            }
            public int RI_ScSetServiceBitsW(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, int p2, int p3, string p4)
            {
                _Marshal_Helper m = new _Marshal_Helper();
                m.WriteContextHandle(p0);
                m.WriteInt32(p1);
                m.WriteInt32(p2);
                m.WriteInt32(p3);
                m.WriteReferent(p4, new System.Action<string>(m.WriteTerminatedString));
                _Unmarshal_Helper u = SendReceive(10, m);
                return u.ReadInt32();
            }
            public int RChangeServiceConfigW(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, int p2, int p3, string p4, string p5, ref System.Nullable<int> p6, sbyte[] p7, int p8, string p9, sbyte[] p10, int p11, string p12)
            {
                _Marshal_Helper m = new _Marshal_Helper();
                m.WriteContextHandle(p0);
                m.WriteInt32(p1);
                m.WriteInt32(p2);
                m.WriteInt32(p3);
                m.WriteReferent(p4, new System.Action<string>(m.WriteTerminatedString));
                m.WriteReferent(p5, new System.Action<string>(m.WriteTerminatedString));
                m.WriteReferent(p6, new System.Action<int>(m.WriteInt32));
                m.WriteReferent(p7, new System.Action<sbyte[], long>(m.Write_56), p8);
                m.WriteInt32(p8);
                m.WriteReferent(p9, new System.Action<string>(m.WriteTerminatedString));
                m.WriteReferent(p10, new System.Action<sbyte[], long>(m.Write_57), p11);
                m.WriteInt32(p11);
                m.WriteReferent(p12, new System.Action<string>(m.WriteTerminatedString));
                _Unmarshal_Helper u = SendReceive(11, m);
                p6 = u.ReadReferentValue<int>(new System.Func<int>(u.ReadInt32), false);
                return u.ReadInt32();
            }
            public int RCreateServiceW(
                        NtApiDotNet.Ndr.Marshal.NdrContextHandle p0,
                        string p1,
                        string p2,
                        int p3,
                        int p4,
                        int p5,
                        int p6,
                        string p7,
                        string p8,
                        ref System.Nullable<int> p9,
                        sbyte[] p10,
                        int p11,
                        string p12,
                        sbyte[] p13,
                        int p14,
                        out NtApiDotNet.Ndr.Marshal.NdrContextHandle p15)
            {
                _Marshal_Helper m = new _Marshal_Helper();
                m.WriteContextHandle(p0);
                m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"));
                m.WriteReferent(p2, new System.Action<string>(m.WriteTerminatedString));
                m.WriteInt32(p3);
                m.WriteInt32(p4);
                m.WriteInt32(p5);
                m.WriteInt32(p6);
                m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p7, "p7"));
                m.WriteReferent(p8, new System.Action<string>(m.WriteTerminatedString));
                m.WriteReferent(p9, new System.Action<int>(m.WriteInt32));
                m.WriteReferent(p10, new System.Action<sbyte[], long>(m.Write_58), p11);
                m.WriteInt32(p11);
                m.WriteReferent(p12, new System.Action<string>(m.WriteTerminatedString));
                m.WriteReferent(p13, new System.Action<sbyte[], long>(m.Write_59), p14);
                m.WriteInt32(p14);
                _Unmarshal_Helper u = SendReceive(12, m);
                p9 = u.ReadReferentValue<int>(new System.Func<int>(u.ReadInt32), false);
                p15 = u.ReadContextHandle();
                return u.ReadInt32();
            }
            public int REnumDependentServicesW(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, out sbyte[] p2, int p3, out int p4, out int p5)
            {
                _Marshal_Helper m = new _Marshal_Helper();
                m.WriteContextHandle(p0);
                m.WriteInt32(p1);
                m.WriteInt32(p3);
                _Unmarshal_Helper u = SendReceive(13, m);
                p2 = u.Read_54();
                p4 = u.ReadInt32();
                p5 = u.ReadInt32();
                return u.ReadInt32();
            }
            public int REnumServicesStatusW(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, int p2, out sbyte[] p3, int p4, out int p5, out int p6, ref System.Nullable<int> p7)
            {
                _Marshal_Helper m = new _Marshal_Helper();
                m.WriteContextHandle(p0);
                m.WriteInt32(p1);
                m.WriteInt32(p2);
                m.WriteInt32(p4);
                m.WriteReferent(p7, new System.Action<int>(m.WriteInt32));
                _Unmarshal_Helper u = SendReceive(14, m);
                p3 = u.Read_60();
                p5 = u.ReadInt32();
                p6 = u.ReadInt32();
                p7 = u.ReadReferentValue<int>(new System.Func<int>(u.ReadInt32), false);
                return u.ReadInt32();
            }
            public int ROpenSCManagerW(string p0, string p1, int p2, out NtApiDotNet.Ndr.Marshal.NdrContextHandle p3)
            {
                _Marshal_Helper m = new _Marshal_Helper();
                m.WriteReferent(p0, new System.Action<string>(m.WriteTerminatedString));
                m.WriteReferent(p1, new System.Action<string>(m.WriteTerminatedString));
                m.WriteInt32(p2);
                _Unmarshal_Helper u = SendReceive(15, m);
                p3 = u.ReadContextHandle();
                return u.ReadInt32();
            }
            public int ROpenServiceW(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, string p1, int p2, out NtApiDotNet.Ndr.Marshal.NdrContextHandle p3)
            {
                _Marshal_Helper m = new _Marshal_Helper();
                m.WriteContextHandle(p0);
                m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"));
                m.WriteInt32(p2);
                _Unmarshal_Helper u = SendReceive(16, m);
                p3 = u.ReadContextHandle();
                return u.ReadInt32();
            }
            public int RQueryServiceConfigW(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, out Struct_1 p1, int p2, out int p3)
            {
                _Marshal_Helper m = new _Marshal_Helper();
                m.WriteContextHandle(p0);
                m.WriteInt32(p2);
                _Unmarshal_Helper u = SendReceive(17, m);
                p1 = u.Read_1();
                p3 = u.ReadInt32();
                return u.ReadInt32();
            }
            public int RQueryServiceLockStatusW(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, out Struct_2 p1, int p2, out int p3)
            {
                _Marshal_Helper m = new _Marshal_Helper();
                m.WriteContextHandle(p0);
                m.WriteInt32(p2);
                _Unmarshal_Helper u = SendReceive(18, m);
                p1 = u.Read_2();
                p3 = u.ReadInt32();
                return u.ReadInt32();
            }
            public int RStartServiceW(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, Struct_3[] p2)
            {
                _Marshal_Helper m = new _Marshal_Helper();
                m.WriteContextHandle(p0);
                m.WriteInt32(p1);
                m.WriteReferent(p2, new System.Action<Struct_3[], long>(m.Write_61), p1);
                _Unmarshal_Helper u = SendReceive(19, m);
                return u.ReadInt32();
            }
            public int RGetServiceDisplayNameW(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, string p1, out string p2, ref int p3)
            {
                _Marshal_Helper m = new _Marshal_Helper();
                m.WriteContextHandle(p0);
                m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"));
                m.WriteInt32(p3);
                _Unmarshal_Helper u = SendReceive(20, m);
                p2 = u.ReadConformantVaryingString();
                p3 = u.ReadInt32();
                return u.ReadInt32();
            }
            public int RGetServiceKeyNameW(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, string p1, out string p2, ref int p3)
            {
                _Marshal_Helper m = new _Marshal_Helper();
                m.WriteContextHandle(p0);
                m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"));
                m.WriteInt32(p3);
                _Unmarshal_Helper u = SendReceive(21, m);
                p2 = u.ReadConformantVaryingString();
                p3 = u.ReadInt32();
                return u.ReadInt32();
            }
            public int GetStatusInternal(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, int p2, int p3, ref string p4)
            {
                _Marshal_Helper m = new _Marshal_Helper();
                m.WriteContextHandle(p0);
                m.WriteInt32(p1);
                m.WriteInt32(p2);
                m.WriteInt32(p3);
                m.WriteReferent(p4, new System.Action<string>(m.WriteTerminatedAnsiString));
                _Unmarshal_Helper u = SendReceive(22, m);
                p4 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingAnsiString), false);
                return u.ReadInt32();
            }
            public int RChangeServiceConfigA(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, int p2, int p3, string p4, string p5, ref System.Nullable<int> p6, sbyte[] p7, int p8, string p9, sbyte[] p10, int p11, string p12)
            {
                _Marshal_Helper m = new _Marshal_Helper();
                m.WriteContextHandle(p0);
                m.WriteInt32(p1);
                m.WriteInt32(p2);
                m.WriteInt32(p3);
                m.WriteReferent(p4, new System.Action<string>(m.WriteTerminatedAnsiString));
                m.WriteReferent(p5, new System.Action<string>(m.WriteTerminatedAnsiString));
                m.WriteReferent(p6, new System.Action<int>(m.WriteInt32));
                m.WriteReferent(p7, new System.Action<sbyte[], long>(m.Write_56), p8);
                m.WriteInt32(p8);
                m.WriteReferent(p9, new System.Action<string>(m.WriteTerminatedAnsiString));
                m.WriteReferent(p10, new System.Action<sbyte[], long>(m.Write_57), p11);
                m.WriteInt32(p11);
                m.WriteReferent(p12, new System.Action<string>(m.WriteTerminatedAnsiString));
                _Unmarshal_Helper u = SendReceive(23, m);
                p6 = u.ReadReferentValue<int>(new System.Func<int>(u.ReadInt32), false);
                return u.ReadInt32();
            }
            public int RCreateServiceA(
                        NtApiDotNet.Ndr.Marshal.NdrContextHandle p0,
                        string p1,
                        string p2,
                        int p3,
                        int p4,
                        int p5,
                        int p6,
                        string p7,
                        string p8,
                        ref System.Nullable<int> p9,
                        sbyte[] p10,
                        int p11,
                        string p12,
                        sbyte[] p13,
                        int p14,
                        out NtApiDotNet.Ndr.Marshal.NdrContextHandle p15)
            {
                _Marshal_Helper m = new _Marshal_Helper();
                m.WriteContextHandle(p0);
                m.WriteTerminatedAnsiString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"));
                m.WriteReferent(p2, new System.Action<string>(m.WriteTerminatedAnsiString));
                m.WriteInt32(p3);
                m.WriteInt32(p4);
                m.WriteInt32(p5);
                m.WriteInt32(p6);
                m.WriteTerminatedAnsiString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p7, "p7"));
                m.WriteReferent(p8, new System.Action<string>(m.WriteTerminatedAnsiString));
                m.WriteReferent(p9, new System.Action<int>(m.WriteInt32));
                m.WriteReferent(p10, new System.Action<sbyte[], long>(m.Write_58), p11);
                m.WriteInt32(p11);
                m.WriteReferent(p12, new System.Action<string>(m.WriteTerminatedAnsiString));
                m.WriteReferent(p13, new System.Action<sbyte[], long>(m.Write_59), p14);
                m.WriteInt32(p14);
                _Unmarshal_Helper u = SendReceive(24, m);
                p9 = u.ReadReferentValue<int>(new System.Func<int>(u.ReadInt32), false);
                p15 = u.ReadContextHandle();
                return u.ReadInt32();
            }
            public int REnumDependentServicesA(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, out sbyte[] p2, int p3, out int p4, out int p5)
            {
                _Marshal_Helper m = new _Marshal_Helper();
                m.WriteContextHandle(p0);
                m.WriteInt32(p1);
                m.WriteInt32(p3);
                _Unmarshal_Helper u = SendReceive(25, m);
                p2 = u.Read_54();
                p4 = u.ReadInt32();
                p5 = u.ReadInt32();
                return u.ReadInt32();
            }
            public int REnumServicesStatusA(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, int p2, out sbyte[] p3, int p4, out int p5, out int p6, ref System.Nullable<int> p7)
            {
                _Marshal_Helper m = new _Marshal_Helper();
                m.WriteContextHandle(p0);
                m.WriteInt32(p1);
                m.WriteInt32(p2);
                m.WriteInt32(p4);
                m.WriteReferent(p7, new System.Action<int>(m.WriteInt32));
                _Unmarshal_Helper u = SendReceive(26, m);
                p3 = u.Read_60();
                p5 = u.ReadInt32();
                p6 = u.ReadInt32();
                p7 = u.ReadReferentValue<int>(new System.Func<int>(u.ReadInt32), false);
                return u.ReadInt32();
            }
            public int ROpenSCManagerA(string p0, string p1, int p2, out NtApiDotNet.Ndr.Marshal.NdrContextHandle p3)
            {
                _Marshal_Helper m = new _Marshal_Helper();
                m.WriteReferent(p0, new System.Action<string>(m.WriteTerminatedAnsiString));
                m.WriteReferent(p1, new System.Action<string>(m.WriteTerminatedAnsiString));
                m.WriteInt32(p2);
                _Unmarshal_Helper u = SendReceive(27, m);
                p3 = u.ReadContextHandle();
                return u.ReadInt32();
            }
            public int ROpenServiceA(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, string p1, int p2, out NtApiDotNet.Ndr.Marshal.NdrContextHandle p3)
            {
                _Marshal_Helper m = new _Marshal_Helper();
                m.WriteContextHandle(p0);
                m.WriteTerminatedAnsiString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"));
                m.WriteInt32(p2);
                _Unmarshal_Helper u = SendReceive(28, m);
                p3 = u.ReadContextHandle();
                return u.ReadInt32();
            }
            public int RQueryServiceConfigA(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, out Struct_4 p1, int p2, out int p3)
            {
                _Marshal_Helper m = new _Marshal_Helper();
                m.WriteContextHandle(p0);
                m.WriteInt32(p2);
                _Unmarshal_Helper u = SendReceive(29, m);
                p1 = u.Read_4();
                p3 = u.ReadInt32();
                return u.ReadInt32();
            }
            public int RQueryServiceLockStatusA(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, out Struct_5 p1, int p2, out int p3)
            {
                _Marshal_Helper m = new _Marshal_Helper();
                m.WriteContextHandle(p0);
                m.WriteInt32(p2);
                _Unmarshal_Helper u = SendReceive(30, m);
                p1 = u.Read_5();
                p3 = u.ReadInt32();
                return u.ReadInt32();
            }
            public int RStartServiceA(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, Struct_6[] p2)
            {
                _Marshal_Helper m = new _Marshal_Helper();
                m.WriteContextHandle(p0);
                m.WriteInt32(p1);
                m.WriteReferent(p2, new System.Action<Struct_6[], long>(m.Write_64), p1);
                _Unmarshal_Helper u = SendReceive(31, m);
                return u.ReadInt32();
            }
            public int RGetServiceDisplayNameA(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, string p1, out string p2, ref int p3)
            {
                _Marshal_Helper m = new _Marshal_Helper();
                m.WriteContextHandle(p0);
                m.WriteTerminatedAnsiString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"));
                m.WriteInt32(p3);
                _Unmarshal_Helper u = SendReceive(32, m);
                p2 = u.ReadConformantVaryingAnsiString();
                p3 = u.ReadInt32();
                return u.ReadInt32();
            }
            public int RGetServiceKeyNameA(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, string p1, out string p2, ref int p3)
            {
                _Marshal_Helper m = new _Marshal_Helper();
                m.WriteContextHandle(p0);
                m.WriteTerminatedAnsiString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"));
                m.WriteInt32(p3);
                _Unmarshal_Helper u = SendReceive(33, m);
                p2 = u.ReadConformantVaryingAnsiString();
                p3 = u.ReadInt32();
                return u.ReadInt32();
            }
            public int GetStatusInternal_34(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, string p1, out int p2)
            {
                _Marshal_Helper m = new _Marshal_Helper();
                m.WriteContextHandle(p0);
                m.WriteReferent(p1, new System.Action<string>(m.WriteTerminatedString));
                _Unmarshal_Helper u = SendReceive(34, m);
                p2 = u.ReadInt32();
                return u.ReadInt32();
            }
            public int REnumServiceGroupW(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, int p2, out sbyte[] p3, int p4, out int p5, out int p6, ref System.Nullable<int> p7, string p8)
            {
                _Marshal_Helper m = new _Marshal_Helper();
                m.WriteContextHandle(p0);
                m.WriteInt32(p1);
                m.WriteInt32(p2);
                m.WriteInt32(p4);
                m.WriteReferent(p7, new System.Action<int>(m.WriteInt32));
                m.WriteReferent(p8, new System.Action<string>(m.WriteTerminatedString));
                _Unmarshal_Helper u = SendReceive(35, m);
                p3 = u.Read_60();
                p5 = u.ReadInt32();
                p6 = u.ReadInt32();
                p7 = u.ReadReferentValue<int>(new System.Func<int>(u.ReadInt32), false);
                return u.ReadInt32();
            }
            public int RChangeServiceConfig2A(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, Struct_7 p1)
            {
                _Marshal_Helper m = new _Marshal_Helper();
                m.WriteContextHandle(p0);
                m.Write_7(p1);
                _Unmarshal_Helper u = SendReceive(36, m);
                return u.ReadInt32();
            }
            public int RChangeServiceConfig2W(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, Struct_20 p1)
            {
                _Marshal_Helper m = new _Marshal_Helper();
                m.WriteContextHandle(p0);
                m.Write_19(p1);
                _Unmarshal_Helper u = SendReceive(37, m);
                return u.ReadInt32();
            }
            public int RQueryServiceConfig2A(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, out sbyte[] p2, int p3, out int p4)
            {
                _Marshal_Helper m = new _Marshal_Helper();
                m.WriteContextHandle(p0);
                m.WriteInt32(p1);
                m.WriteInt32(p3);
                _Unmarshal_Helper u = SendReceive(38, m);
                p2 = u.Read_63();
                p4 = u.ReadInt32();
                return u.ReadInt32();
            }
            public int RQueryServiceConfig2W(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, out sbyte[] p2, int p3, out int p4)
            {
                _Marshal_Helper m = new _Marshal_Helper();
                m.WriteContextHandle(p0);
                m.WriteInt32(p1);
                m.WriteInt32(p3);
                _Unmarshal_Helper u = SendReceive(39, m);
                p2 = u.Read_63();
                p4 = u.ReadInt32();
                return u.ReadInt32();
            }
            public int RQueryServiceStatusEx(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, out sbyte[] p2, int p3, out int p4)
            {
                _Marshal_Helper m = new _Marshal_Helper();
                m.WriteContextHandle(p0);
                m.WriteInt32(p1);
                m.WriteInt32(p3);
                _Unmarshal_Helper u = SendReceive(40, m);
                p2 = u.Read_63();
                p4 = u.ReadInt32();
                return u.ReadInt32();
            }
            public int REnumServicesStatusExA(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, int p2, int p3, out sbyte[] p4, int p5, out int p6, out int p7, ref System.Nullable<int> p8, string p9)
            {
                _Marshal_Helper m = new _Marshal_Helper();
                m.WriteContextHandle(p0);
                m.WriteInt32(p1);
                m.WriteInt32(p2);
                m.WriteInt32(p3);
                m.WriteInt32(p5);
                m.WriteReferent(p8, new System.Action<int>(m.WriteInt32));
                m.WriteReferent(p9, new System.Action<string>(m.WriteTerminatedAnsiString));
                _Unmarshal_Helper u = SendReceive(41, m);
                p4 = u.Read_64();
                p6 = u.ReadInt32();
                p7 = u.ReadInt32();
                p8 = u.ReadReferentValue<int>(new System.Func<int>(u.ReadInt32), false);
                return u.ReadInt32();
            }
            public int REnumServicesStatusExW(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, int p2, int p3, out sbyte[] p4, int p5, out int p6, out int p7, ref System.Nullable<int> p8, string p9)
            {
                _Marshal_Helper m = new _Marshal_Helper();
                m.WriteContextHandle(p0);
                m.WriteInt32(p1);
                m.WriteInt32(p2);
                m.WriteInt32(p3);
                m.WriteInt32(p5);
                m.WriteReferent(p8, new System.Action<int>(m.WriteInt32));
                m.WriteReferent(p9, new System.Action<string>(m.WriteTerminatedString));
                _Unmarshal_Helper u = SendReceive(42, m);
                p4 = u.Read_64();
                p6 = u.ReadInt32();
                p7 = u.ReadInt32();
                p8 = u.ReadReferentValue<int>(new System.Func<int>(u.ReadInt32), false);
                return u.ReadInt32();
            }
            public int RI_ScBroadcastServiceControlMessage(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, int p2, int p3, sbyte[] p4)
            {
                _Marshal_Helper m = new _Marshal_Helper();
                m.WriteContextHandle(p0);
                m.WriteInt32(p1);
                m.WriteInt32(p2);
                m.WriteInt32(p3);
                m.WriteReferent(p4, new System.Action<sbyte[], long>(m.Write_69), p3);
                _Unmarshal_Helper u = SendReceive(43, m);
                return u.ReadInt32();
            }
            public int RCreateServiceWOW64A(
                        NtApiDotNet.Ndr.Marshal.NdrContextHandle p0,
                        string p1,
                        string p2,
                        int p3,
                        int p4,
                        int p5,
                        int p6,
                        string p7,
                        string p8,
                        ref System.Nullable<int> p9,
                        sbyte[] p10,
                        int p11,
                        string p12,
                        sbyte[] p13,
                        int p14,
                        out NtApiDotNet.Ndr.Marshal.NdrContextHandle p15)
            {
                _Marshal_Helper m = new _Marshal_Helper();
                m.WriteContextHandle(p0);
                m.WriteTerminatedAnsiString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"));
                m.WriteReferent(p2, new System.Action<string>(m.WriteTerminatedAnsiString));
                m.WriteInt32(p3);
                m.WriteInt32(p4);
                m.WriteInt32(p5);
                m.WriteInt32(p6);
                m.WriteTerminatedAnsiString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p7, "p7"));
                m.WriteReferent(p8, new System.Action<string>(m.WriteTerminatedAnsiString));
                m.WriteReferent(p9, new System.Action<int>(m.WriteInt32));
                m.WriteReferent(p10, new System.Action<sbyte[], long>(m.Write_58), p11);
                m.WriteInt32(p11);
                m.WriteReferent(p12, new System.Action<string>(m.WriteTerminatedAnsiString));
                m.WriteReferent(p13, new System.Action<sbyte[], long>(m.Write_59), p14);
                m.WriteInt32(p14);
                _Unmarshal_Helper u = SendReceive(44, m);
                p9 = u.ReadReferentValue<int>(new System.Func<int>(u.ReadInt32), false);
                p15 = u.ReadContextHandle();
                return u.ReadInt32();
            }
            public int RCreateServiceWOW64W(
                        NtApiDotNet.Ndr.Marshal.NdrContextHandle p0,
                        string p1,
                        string p2,
                        int p3,
                        int p4,
                        int p5,
                        int p6,
                        string p7,
                        string p8,
                        ref System.Nullable<int> p9,
                        sbyte[] p10,
                        int p11,
                        string p12,
                        sbyte[] p13,
                        int p14,
                        out NtApiDotNet.Ndr.Marshal.NdrContextHandle p15)
            {
                _Marshal_Helper m = new _Marshal_Helper();
                m.WriteContextHandle(p0);
                m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"));
                m.WriteReferent(p2, new System.Action<string>(m.WriteTerminatedString));
                m.WriteInt32(p3);
                m.WriteInt32(p4);
                m.WriteInt32(p5);
                m.WriteInt32(p6);
                m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p7, "p7"));
                m.WriteReferent(p8, new System.Action<string>(m.WriteTerminatedString));
                m.WriteReferent(p9, new System.Action<int>(m.WriteInt32));
                m.WriteReferent(p10, new System.Action<sbyte[], long>(m.Write_58), p11);
                m.WriteInt32(p11);
                m.WriteReferent(p12, new System.Action<string>(m.WriteTerminatedString));
                m.WriteReferent(p13, new System.Action<sbyte[], long>(m.Write_59), p14);
                m.WriteInt32(p14);
                _Unmarshal_Helper u = SendReceive(45, m);
                p9 = u.ReadReferentValue<int>(new System.Func<int>(u.ReadInt32), false);
                p15 = u.ReadContextHandle();
                return u.ReadInt32();
            }
            public int RI_ScQueryServiceTagInfo(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, Union_24 p2, out Union_27 p3)
            {
                _Marshal_Helper m = new _Marshal_Helper();
                m.WriteContextHandle(p0);
                m.WriteInt32(p1);
                m.Write_23(p2, p1);
                _Unmarshal_Helper u = SendReceive(46, m);
                p3 = u.Read_26();
                return u.ReadInt32();
            }
            public int RNotifyServiceStatusChange(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, Struct_32 p1, System.Guid p2, out System.Guid p3, out int p4, out NtApiDotNet.Ndr.Marshal.NdrContextHandle p5)
            {
                _Marshal_Helper m = new _Marshal_Helper();
                m.WriteContextHandle(p0);
                m.Write_31(p1);
                m.WriteGuid(p2);
                _Unmarshal_Helper u = SendReceive(47, m);
                p3 = u.ReadGuid();
                p4 = u.ReadInt32();
                p5 = u.ReadContextHandle();
                return u.ReadInt32();
            }
            // async
            public uint RGetNotifyResults(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, out System.Nullable<Struct_37> p1)
            {
                _Marshal_Helper m = new _Marshal_Helper();
                m.WriteContextHandle(p0);
                _Unmarshal_Helper u = SendReceive(48, m);
                p1 = u.ReadReferentValue<Struct_37>(new System.Func<Struct_37>(u.Read_36), false);
                return u.ReadUInt32();
            }
            public int RCloseNotifyHandle(ref NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, out int p1)
            {
                _Marshal_Helper m = new _Marshal_Helper();
                m.WriteContextHandle(p0);
                _Unmarshal_Helper u = SendReceive(49, m);
                p0 = u.ReadContextHandle();
                p1 = u.ReadInt32();
                return u.ReadInt32();
            }
            public int RControlServiceExA(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, int p2, Union_38 p3, out Union_40 p4)
            {
                _Marshal_Helper m = new _Marshal_Helper();
                m.WriteContextHandle(p0);
                m.WriteInt32(p1);
                m.WriteInt32(p2);
                m.Write_37(p3, p2);
                _Unmarshal_Helper u = SendReceive(50, m);
                p4 = u.Read_39();
                return u.ReadInt32();
            }
            public int RControlServiceExW(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, int p2, Union_42 p3, out Union_44 p4)
            {
                _Marshal_Helper m = new _Marshal_Helper();
                m.WriteContextHandle(p0);
                m.WriteInt32(p1);
                m.WriteInt32(p2);
                m.Write_41(p3, p2);
                _Unmarshal_Helper u = SendReceive(51, m);
                p4 = u.Read_43();
                return u.ReadInt32();
            }
            public int RI_ScSendPnPMessage(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, long p1, int p2, int p3, int p4, sbyte[] p5, out int p6)
            {
                _Marshal_Helper m = new _Marshal_Helper();
                m.WriteContextHandle(p0);
                m.WriteInt64(p1);
                m.WriteInt32(p2);
                m.WriteInt32(p3);
                m.WriteInt32(p4);
                m.WriteReferent(p5, new System.Action<sbyte[], long>(m.Write_70), p4);
                _Unmarshal_Helper u = SendReceive(52, m);
                p6 = u.ReadInt32();
                return u.ReadInt32();
            }
            public int RI_ScValidatePnPService(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, string p1, out long p2)
            {
                _Marshal_Helper m = new _Marshal_Helper();
                m.WriteContextHandle(p0);
                m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"));
                _Unmarshal_Helper u = SendReceive(53, m);
                p2 = u.ReadInt64();
                return u.ReadInt32();
            }
            public int RI_ScOpenServiceStatusHandle(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, string p1, long p2, out NtApiDotNet.Ndr.Marshal.NdrContextHandle p3)
            {
                _Marshal_Helper m = new _Marshal_Helper();
                m.WriteContextHandle(p0);
                m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"));
                m.WriteInt64(p2);
                _Unmarshal_Helper u = SendReceive(54, m);
                p3 = u.ReadContextHandle();
                return u.ReadInt32();
            }
            public int RI_ScQueryServiceConfig(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, out Union_45 p2)
            {
                _Marshal_Helper m = new _Marshal_Helper();
                m.WriteContextHandle(p0);
                m.WriteInt32(p1);
                _Unmarshal_Helper u = SendReceive(55, m);
                p2 = u.Read_44();
                return u.ReadInt32();
            }
            public int RQueryServiceConfigEx(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, out Struct_20 p2)
            {
                _Marshal_Helper m = new _Marshal_Helper();
                m.WriteContextHandle(p0);
                m.WriteInt32(p1);
                _Unmarshal_Helper u = SendReceive(56, m);
                p2 = u.Read_19();
                return u.ReadInt32();
            }
            public int RI_ScRegisterPreshutdownRestart(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, string p1, int p2)
            {
                _Marshal_Helper m = new _Marshal_Helper();
                m.WriteContextHandle(p0);
                m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"));
                m.WriteInt32(p2);
                _Unmarshal_Helper u = SendReceive(57, m);
                return u.ReadInt32();
            }
            public int RI_ScReparseServiceDatabase(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1)
            {
                _Marshal_Helper m = new _Marshal_Helper();
                m.WriteContextHandle(p0);
                m.WriteInt32(p1);
                _Unmarshal_Helper u = SendReceive(58, m);
                return u.ReadInt32();
            }
            public int RQueryUserServiceName(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, string p1, string p2, int p3, out string p4)
            {
                _Marshal_Helper m = new _Marshal_Helper();
                m.WriteContextHandle(p0);
                m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"));
                m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p2, "p2"));
                m.WriteInt32(p3);
                _Unmarshal_Helper u = SendReceive(59, m);
                p4 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
                return u.ReadInt32();
            }
            public int RCreateWowService(
                        NtApiDotNet.Ndr.Marshal.NdrContextHandle p0,
                        string p1,
                        string p2,
                        int p3,
                        int p4,
                        int p5,
                        int p6,
                        string p7,
                        string p8,
                        ref System.Nullable<int> p9,
                        sbyte[] p10,
                        int p11,
                        string p12,
                        sbyte[] p13,
                        int p14,
                        short p15,
                        out NtApiDotNet.Ndr.Marshal.NdrContextHandle p16)
            {
                _Marshal_Helper m = new _Marshal_Helper();
                m.WriteContextHandle(p0);
                m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"));
                m.WriteReferent(p2, new System.Action<string>(m.WriteTerminatedString));
                m.WriteInt32(p3);
                m.WriteInt32(p4);
                m.WriteInt32(p5);
                m.WriteInt32(p6);
                m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p7, "p7"));
                m.WriteReferent(p8, new System.Action<string>(m.WriteTerminatedString));
                m.WriteReferent(p9, new System.Action<int>(m.WriteInt32));
                m.WriteReferent(p10, new System.Action<sbyte[], long>(m.Write_58), p11);
                m.WriteInt32(p11);
                m.WriteReferent(p12, new System.Action<string>(m.WriteTerminatedString));
                m.WriteReferent(p13, new System.Action<sbyte[], long>(m.Write_59), p14);
                m.WriteInt32(p14);
                m.WriteInt16(p15);
                _Unmarshal_Helper u = SendReceive(60, m);
                p9 = u.ReadReferentValue<int>(new System.Func<int>(u.ReadInt32), false);
                p16 = u.ReadContextHandle();
                return u.ReadInt32();
            }
            public int RGetServiceRegistryStateKey(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, int p2, out NtApiDotNet.NtKey p3)
            {
                _Marshal_Helper m = new _Marshal_Helper();
                m.WriteContextHandle(p0);
                m.WriteInt32(p1);
                m.WriteInt32(p2);
                _Unmarshal_Helper u = SendReceive(61, m);
                p3 = u.Read_67();
                return u.ReadInt32();
            }
            public int RGetServiceDirectory(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, ref char[] p2, int p3, out int p4)
            {
                _Marshal_Helper m = new _Marshal_Helper();
                m.WriteContextHandle(p0);
                m.WriteInt32(p1);
                m.WriteReferent(p2, new System.Action<char[], long>(m.Write_72), p3);
                m.WriteInt32(p3);
                _Unmarshal_Helper u = SendReceive(62, m);
                p2 = u.ReadReferent<char[]>(new System.Func<char[]>(u.Read_68), false);
                p4 = u.ReadInt32();
                return u.ReadInt32();
            }
            public int RGetServiceProcessToken(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, NtApiDotNet.Ndr.Marshal.NdrContextHandle p1, out NtApiDotNet.NtToken p2)
            {
                _Marshal_Helper m = new _Marshal_Helper();
                m.WriteContextHandle(p0);
                m.WriteContextHandle(p1);
                _Unmarshal_Helper u = SendReceive(63, m);
                p2 = u.Read_69();
                return u.ReadInt32();
            }
            public int ROpenSCManager2(string p0, int p1, out NtApiDotNet.Ndr.Marshal.NdrContextHandle p2)
            {
                _Marshal_Helper m = new _Marshal_Helper();
                m.WriteReferent(p0, new System.Action<string>(m.WriteTerminatedString));
                m.WriteInt32(p1);
                _Unmarshal_Helper u = SendReceive(64, m);
                p2 = u.ReadContextHandle();
                return u.ReadInt32();
            }
            public int RGetSharedServiceRegistryStateKey(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, int p2, out NtApiDotNet.NtKey p3)
            {
                _Marshal_Helper m = new _Marshal_Helper();
                m.WriteContextHandle(p0);
                m.WriteInt32(p1);
                m.WriteInt32(p2);
                _Unmarshal_Helper u = SendReceive(65, m);
                p3 = u.Read_67();
                return u.ReadInt32();
            }
            public int RGetSharedServiceDirectory(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, ref char[] p2, int p3, out int p4)
            {
                _Marshal_Helper m = new _Marshal_Helper();
                m.WriteContextHandle(p0);
                m.WriteInt32(p1);
                m.WriteReferent(p2, new System.Action<char[], long>(m.Write_72), p3);
                m.WriteInt32(p3);
                _Unmarshal_Helper u = SendReceive(66, m);
                p2 = u.ReadReferent<char[]>(new System.Func<char[]>(u.Read_68), false);
                p4 = u.ReadInt32();
                return u.ReadInt32();
            }
        }
        #endregion
    }
}
