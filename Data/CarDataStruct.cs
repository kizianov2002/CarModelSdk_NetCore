using System.Runtime.InteropServices;


namespace CarModelSdk_NetCore
{
    public enum RecognizeMode {
        RecognizeAuto = -1,
        RecognizeNone,
        RecognizeModel,
        RecognizeType,
        RecognizeBoth
    };

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct CarDataStruct
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 255)]
        public byte[] Name;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 255)]
        public byte[] Mark;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 255)]
        public byte[] Modl;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 255)]
        public byte[] Genr;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 255)]
        public byte[] MarkProbStr;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 255)]
        public byte[] Type;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 255)]
        public byte[] Side;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 255)]
        public byte[] TypeProbStr;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 255)]
        public byte[] FileFullName;
    };

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct StringStruct
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 255)]
        public byte[] Text;

        override public string ToString()
        {
            string res = "" + Text;
            return res;
        }
    };

}