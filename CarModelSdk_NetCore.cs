using ikvm.lang;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Loader;
using System.Text;

namespace CarModelSdk_NetCore
{
    public class CarModelSdk
    {
        public static string FileDirectoryIn = "c:\\Temp\\In";
        public static string FileDirectoryOut = "c:\\Temp\\Out";

        public static int Mode = (int)RecognizeMode.RecognizeBoth;
        public static int RecognizeBorder_prc = 90;
        public static int Latitude_deg = 45;
        public static int OffsetDayTime_min = 45;
        public static int OffsetTimeZone_min = 0;

        public static int OutNameAddFileName = 1;
        public static int OutNameAddDateTime = 0;
        public static int OutNameAddName = 1;
        public static int OutNameAddMark = 0;
        public static int OutNameAddModl = 0;
        public static int OutNameAddGenr = 0;
        public static int OutNameAddMarkProb = 1;
        public static int OutNameAddType = 0;
        public static int OutNameAddSide = 0;
        public static int OutNameAddTypeProb = 0;
        public static int OutNameAddFileNam2 = 1;

        public static int FilesToDisk = 0;

        public static int OutMarkRect = 1;
        public static int OutTypeRect = 1;

        public static int SaveRecognized = 1;
        public static int SaveUnrecognized = 1;
        public static int SaveRemoveOld = 1;
        public static int SaveRenameNew = 1;

        public CarModelSdk()
        {
            int ans = Test(12345);
            if (ans == 12345)
            {
                //Console.WriteLine(" !!! Use CarModelSdk.dll !!! ");
            }
            else
            {
                throw new CarModelSdkException("CarModelSdk.dll is not accesible!");
            }

            SetRecognizeOptions(
                RecognizeBorder_prc,
                Latitude_deg,
                OffsetDayTime_min,
                OffsetTimeZone_min);

            SetFileDirectoryIn(
                FileDirectoryIn);

            SetFileDirectoryOut(
                FileDirectoryOut);

            SetOutFileNamesFormat(
                (OutNameAddFileName),
                (OutNameAddDateTime),
                (OutNameAddName),
                (OutNameAddMark),
                (OutNameAddModl),
                (OutNameAddGenr),
                (OutNameAddMarkProb),
                (OutNameAddType),
                (OutNameAddSide),
                (OutNameAddTypeProb),
                (OutNameAddFileNam2)
                );

            SetSaveOptions(
                (FilesToDisk),
                (OutMarkRect),
                (OutTypeRect),
                (SaveRecognized),
                (SaveUnrecognized),
                (SaveRemoveOld),
                (SaveRenameNew)
                );

            InitRecognizer();
        }

        public static int Test(int myInt)
        {
            return CarModelRecognize.Test(myInt);
        }

        public static int SetFileDirectoryIn(string strpath)
        {
            FileDirectoryIn = strpath;
            return CarModelRecognize.SetFileDirectoryIn(FileDirectoryIn);
        }

        public static int SetFileDirectoryOut(string strpath)
        {
            FileDirectoryOut = strpath;
            return CarModelRecognize.SetFileDirectoryOut(FileDirectoryOut);
        }

    
        public static int GetFileDirectoryIn(out StringStruct text)
        {
            return CarModelRecognize.GetFileDirectoryIn(out text);
        }

        public static int GetFileDirectoryOut(out StringStruct text)
        {
            return CarModelRecognize.GetFileDirectoryOut(out text);
        }

        public static int InitRecognizer()
        {
            return CarModelRecognize.InitRecognizer();
        }

        public static int GetRecoCarMarkAddress(out long num)
        {
            return CarModelRecognize.GetRecoCarMarkAddress(out num);
        }

        public static int GetRecoCarTypeAddress(out long num)
        {
            return CarModelRecognize.GetRecoCarTypeAddress(out num);
        }


        public static int SetRecoCountLim( int cntLim ) 
        {
            return CarModelRecognize.SetRecoCountLim(
                cntLim);
        }

        public static int SetRecognizeMode( RecognizeMode recognizeMode ) 
        {
            Mode = (int)recognizeMode;
            return CarModelRecognize.SetRecognizeMode(
                Mode);
        }

        public static int SetRecognizeOptions(
            int recognBorder,
            int latitude_deg,
            int offsetDayTime_min,
            int offsetTimeZone_min)
        {
            RecognizeBorder_prc = recognBorder;
            Latitude_deg = latitude_deg;
            OffsetDayTime_min = offsetDayTime_min;
            OffsetTimeZone_min = offsetTimeZone_min;

            //Console.WriteLine("RecognizeBorder_prc = " + RecognizeBorder_prc);
            //Console.WriteLine("Latitude_deg = " + Latitude_deg);
            //Console.WriteLine("OffsetDayTime_min = " + OffsetDayTime_min);
            //Console.WriteLine("OffsetTimeZone_min = " + OffsetTimeZone_min);

            return CarModelRecognize.SetRecognizeOptions(
                RecognizeBorder_prc,
                Latitude_deg,
                OffsetDayTime_min,
                OffsetTimeZone_min);
        }

        public static int SetOutFileNamesFormat(
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
            int filenam2)
        {
            OutNameAddFileName = filename;
            OutNameAddDateTime = datetime;
            OutNameAddName = name;
            OutNameAddMark = mark;
            OutNameAddModl = modl;
            OutNameAddGenr = genr;
            OutNameAddMarkProb = markProb;
            OutNameAddType = type;
            OutNameAddSide = side;
            OutNameAddTypeProb = typeProb;
            OutNameAddFileNam2 = filenam2;

            return CarModelRecognize.SetOutFileNamesFormat(
                 OutNameAddFileName,
                 OutNameAddDateTime,
                 OutNameAddName,
                 OutNameAddMark,
                 OutNameAddModl,
                 OutNameAddGenr,
                 OutNameAddMarkProb,
                 OutNameAddType,
                 OutNameAddSide,
                 OutNameAddTypeProb,
                 OutNameAddFileNam2);
        }

        public static int SetSaveOptions(
            int filesToDisk,
            int markRect,
            int typeRect,
            int saveRec,
            int saveUnrec,
            int remOld,
            int renNew )
        {
            FilesToDisk = filesToDisk;
            OutMarkRect = markRect;
            OutTypeRect = typeRect;
            SaveRecognized = saveRec;
            SaveUnrecognized = saveUnrec;
            SaveRemoveOld = remOld;
            SaveRenameNew = renNew;

            return CarModelRecognize.SetSaveOptions(
                 FilesToDisk,
                 OutMarkRect,
                 OutTypeRect,
                 SaveRecognized,
                 SaveUnrecognized,
                 SaveRemoveOld,
                 SaveRenameNew);
        }


        public static int CalcSunrize_mins(
            int mon, 
            int day)
        {
            return CarModelRecognize.CalcSunrizeCpp_mins(
                mon, 
                day);
        }

        public static int CalcSunset_mins(
            int mon, 
            int day)
        {
            return CarModelRecognize.CalcSunsetCpp_mins(
                mon, 
                day);
        }


        public static int CalcSunrize_mins_full(
            int mon, 
            int day,
            int latitude_deg, int offsetDayTime_min, int offsetTimeZone_min)
        {
            return CarModelRecognize.CalcSunrizeCpp_mins_full(
                mon, 
                day,
                latitude_deg, offsetDayTime_min, offsetTimeZone_min);
        }

        public static int CalcSunset_mins_full(
            int mon, 
            int day,
            int latitude_deg, int offsetDayTime_min, int offsetTimeZone_min)
        {
            return CarModelRecognize.CalcSunsetCpp_mins_full(
                mon, 
                day,
                latitude_deg, offsetDayTime_min, offsetTimeZone_min);
        }


        public static int RecognizeImg(
            out CarDataStruct answer,
            Emgu.CV.Mat img,
            string fileName)
        {
            return CarModelRecognize.RecognizeImgCpp(
                out answer,
                img,
                fileName,
                -1);
        }

        public static int RecognizeImageByteArr(
            out CarDataStruct answer,
            byte[] buf,
            long bufLen,
            string fileName)
        {
            // Console.WriteLine("CarModelSdk_NetCore.RecognizeImageByteArrCpp()");
            return CarModelRecognize.RecognizeImageByteArrCpp(
                out answer,
                buf,
                bufLen,
                fileName,
                -1);
        }

        public static string RecognizeFile(
            out CarDataStruct answer,
            string fileName)
        {
            var res = CarModelRecognize.RecognizeFileCpp(
                out answer,
                fileName,
                -1);

            string file_name = System.Text.Encoding.UTF8.GetString(answer.FileFullName);

            int pos = file_name.IndexOf(":");

            if (pos >= 1)
                file_name = file_name.Substring(pos - 1, file_name.Length - pos + 1);

            return file_name;
        }


        public static int RecognizeDir()
        {
            return CarModelRecognize.RecognizeDirCpp(
                -1);
        }

    }
}
