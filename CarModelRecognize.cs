using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;


namespace CarModelSdk_NetCore
{
    public class CarModelRecognize
    {
        [DllImport(@"CarModelSdk.dll", CharSet = CharSet.Ansi)]
        public static extern int Test(int myInt);


        [DllImport(@"CarModelSdk.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public static extern int SetFileDirectoryIn(string strpath);

        [DllImport(@"CarModelSdk.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public static extern int SetFileDirectoryOut(string strpath);


        [DllImport(@"CarModelSdk.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public static extern int GetFileDirectoryIn(out StringStruct text);

        [DllImport(@"CarModelSdk.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public static extern int GetFileDirectoryOut(out StringStruct text);


        [DllImport(@"CarModelSdk.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public static extern int InitRecognizer();


        [DllImport(@"CarModelSdk.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public static extern int GetRecoCarMarkAddress(out long num);

        [DllImport(@"CarModelSdk.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public static extern int GetRecoCarTypeAddress(out long num);


        [DllImport(@"CarModelSdk.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public static extern int SetRecoCountLim(
            int cntLim);

        [DllImport(@"CarModelSdk.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public static extern int SetRecognizeMode(
            int mode);


        [DllImport(@"CarModelSdk.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public static extern int SetRecognizeOptions(
            int recognizeBorder_prc,
            int latitude_deg,
            int dayOffset_min,
            int zoneOffset_min);

        [DllImport(@"CarModelSdk.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public static extern int SetOutFileNamesFormat(
            int filename,
            int datetime,
            int name,
            int mark,
            int modl,
            int genr,
            int markProb,
            int type,
            int side,
            int typeProb,
            int filenam2);

        [DllImport(@"CarModelSdk.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public static extern int SetSaveOptions(
            int filesToDisk,
            int markRect,
            int typeRect,
            int saveRec,
            int saveUnrec,
            int remOld,
            int renNew);


        [DllImport(@"CarModelSdk.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public static extern int CalcSunrizeCpp_mins(
            int mon, int day);

        [DllImport(@"CarModelSdk.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public static extern int CalcSunsetCpp_mins(
            int mon, int day);


        [DllImport(@"CarModelSdk.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public static extern int CalcSunrizeCpp_mins_full(
            int mon, int day,
            int latitude_deg, int offsetDayTime_min, int offsetTimeZone_min);

        [DllImport(@"CarModelSdk.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public static extern int CalcSunsetCpp_mins_full(
            int mon, int day,
            int latitude_deg, int offsetDayTime_min, int offsetTimeZone_min);


        [DllImport(@"CarModelSdk.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public unsafe static extern int RecognizeImgCpp(
            out CarDataStruct answer,
            Emgu.CV.Mat img,
            string fileName,
            int mode);

        [DllImport(@"CarModelSdk.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public unsafe static extern int RecognizeImageByteArrCpp(
            out CarDataStruct answer,
            byte[] buf,
            long bufLen,
            string fileName,
            int mode);

        [DllImport(@"CarModelSdk.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public static extern int RecognizeFileCpp(
            out CarDataStruct answer,
            string fileName,
            int mode);

        [DllImport(@"CarModelSdk.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public static extern int RecognizeDirCpp(
            int mode);

        //[DllImport(@"CarModelSdk.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        //public unsafe static extern int RecognizeImageByteArrCpp_thread(
        //    out CarDataStruct answer,
        //    byte[] buf,
        //    long bufLen,

        //    int mode,
        //    int recognizeBorder_prc);
    }

}
