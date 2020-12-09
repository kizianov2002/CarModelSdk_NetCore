using System;
using System.Collections.Generic;
using System.Text;

namespace CarModelSdk_NetCore
{
    public class CarData
    {
        public string Name;
        public string Mark;
        public string Modl;
        public string Genr;
        public string MarkProbStr;
        public string Type;
        public string Side;
        public string TypeProbStr;
        public string FileFullName;

        public CarData()
        {
            Name = "";
            Mark = "";
            Modl = "";
            Genr = "";
            MarkProbStr = "0";
            Type = "";
            Side = "";
            TypeProbStr = "0";
            FileFullName = "";
        }

        public CarData(
            string name, string mark, string modl, string genr,
            string markProbStr, 
            string type, string side,
            string typeProbStr, 
            string filename)
        {
            Name = name;
            Mark = mark;
            Modl = modl;
            Genr = genr;
            MarkProbStr = markProbStr;
            Type = type;
            Side = side;
            TypeProbStr = typeProbStr;
            FileFullName = filename;
        }

        public CarData(CarDataStruct answer)
        {
            var sizeName = System.Array.IndexOf(answer.Name, (byte)0);
            Name = System.Text.Encoding.UTF8.GetString(answer.Name, 0, sizeName < 0 ? 255 : sizeName);

            var sizeMark = System.Array.IndexOf(answer.Mark, (byte)0);
            Mark = System.Text.Encoding.UTF8.GetString(answer.Mark, 0, sizeMark < 0 ? 255 : sizeMark);

            var sizeModl = System.Array.IndexOf(answer.Modl, (byte)0);
            Modl = System.Text.Encoding.UTF8.GetString(answer.Modl, 0, sizeModl < 0 ? 255 : sizeModl);

            var sizeGenr = System.Array.IndexOf(answer.Genr, (byte)0);
            Genr = System.Text.Encoding.UTF8.GetString(answer.Genr, 0, sizeGenr < 0 ? 255 : sizeGenr);

            var sizeProbMarkStr = System.Array.IndexOf(answer.MarkProbStr, (byte)0);
            MarkProbStr = System.Text.Encoding.UTF8.GetString(answer.MarkProbStr, 0, sizeProbMarkStr < 0 ? 255 : sizeProbMarkStr);


            var sizeType = System.Array.IndexOf(answer.Type, (byte)0);
            Mark = System.Text.Encoding.UTF8.GetString(answer.Type, 0, sizeType < 0 ? 255 : sizeType);

            var sizeSide = System.Array.IndexOf(answer.Side, (byte)0);
            Modl = System.Text.Encoding.UTF8.GetString(answer.Side, 0, sizeSide < 0 ? 255 : sizeSide);

            var sizeProbTypeStr = System.Array.IndexOf(answer.TypeProbStr, (byte)0);
            TypeProbStr = System.Text.Encoding.UTF8.GetString(answer.TypeProbStr, 0, sizeProbTypeStr < 0 ? 255 : sizeProbTypeStr);


            var sizeFileFullName = System.Array.IndexOf(answer.FileFullName, (byte)0);
            FileFullName = System.Text.Encoding.UTF8.GetString(answer.FileFullName, 0, sizeFileFullName < 0 ? 255 : sizeFileFullName);
        }
    }


    public class StringData
    {
        public static string StructToString(StringStruct text)
        {
            var sizeText = System.Array.IndexOf(text.Text, (byte)0);
            string Text = System.Text.Encoding.UTF8.GetString(text.Text, 0, sizeText < 0 ? 255 : sizeText);
            return Text;
        }
    }
}
