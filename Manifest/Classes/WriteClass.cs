using System;
using System.IO;

namespace Manifest
{
    public class WriteClass
    {
        public static void WriteToFile(string fileName, string[] arryLine)
        {
            //string fileName = "frm.txt";
            string txt = "";

            StreamWriter objWriter = new StreamWriter(fileName + ".txt");

            for (int i = 0; i < arryLine.Length; i++)
            {
                //arryLine[i] = "" + arryLine[i] + "";
                txt += arryLine[i];
                if (i < arryLine.Length - 1) txt += ",";
            }

            txt += Environment.NewLine;


            objWriter.Write(txt);
            objWriter.Close();


            //using (StreamWriter sw = File.AppendText(fileName + ".txt"))
            //{
            //    sw.WriteLine("This");
            //    sw.WriteLine("is Extra");
            //    sw.WriteLine("Text");
            //}

        }
        public static void Append(string fileName, string[] arryLine)
        {
            //string fileName = "frm.txt";
            string txt = "";

            StreamWriter objWriter = File.AppendText(fileName + ".txt");

            for (int i = 0; i < arryLine.Length; i++)
            {
                //arryLine[i] = "" + arryLine[i] + "";
                txt += arryLine[i];
                if (i < arryLine.Length - 1) txt += ",";
            }

            txt += Environment.NewLine;


            objWriter.Write(txt);
            objWriter.Close();


            //using (StreamWriter sw = File.AppendText(fileName + ".txt"))
            //{
            //    sw.WriteLine("This");
            //    sw.WriteLine("is Extra");
            //    sw.WriteLine("Text");
            //}

        }
        
        
        public static string[] WriteVOY(VOYViewModel _v)
        {
            string[] _str = new string[11];
            _str[0] = _v.txt1;
            _str[1] = _v.txt2;
            _str[2] = _v.txt3;
            _str[3] = _v.txt4;
            _str[4] = _v.txt5;
            _str[5] = _v.txt6;
            _str[6] = _v.txt7;
            _str[7] = _v.txt8;
            _str[8] = _v.txt9;
            _str[9] = _v.txt10;
            _str[10] = _v.txt11;

            ////Add double cotation
            //for (int i = 0; i < _str.Length; i++)
            //{
            //    _str[i] = "\"" + _str[i] + "\"";
            //}

            return _str.AddQutation();
        }

        public static string[] WriteBol(BOLViewModel _b)
        {
            string[] _str = new string[61];
            _str[0] = _b.txt1;
            _str[1] = _b.txt2;
            _str[2] = _b.txt3;
            _str[3] = _b.txt4;
            _str[4] = _b.txt5;
            _str[5] = _b.txt6;
            _str[6] = _b.txt7;
            _str[7] = _b.txt8;
            _str[8] = _b.txt9;
            _str[9] = _b.txt10;
            _str[10] = _b.txt11;
            _str[11] = _b.txt12;
            _str[12] = _b.txt13;
            _str[13] = _b.txt14;
            _str[14] = _b.txt15;
            _str[15] = _b.txt16;
            _str[16] = _b.txt17;
            _str[17] = _b.txt18;
            _str[18] = _b.txt19;
            _str[19] = _b.txt20;
            _str[20] = _b.txt21;
            _str[21] = _b.txt22;
            _str[22] = _b.txt23;
            _str[23] = _b.txt24;
            _str[24] = _b.txt25;
            _str[25] = _b.txt26;
            _str[26] = _b.txt27;
            _str[27] = _b.txt28;
            _str[28] = _b.txt29;
            _str[29] = _b.txt30;
            _str[30] = _b.txt31;
            _str[31] = _b.txt32;
            _str[32] = _b.txt33;
            _str[33] = _b.txt34;
            _str[34] = _b.txt35;
            _str[35] = _b.txt36;
            _str[36] = _b.txt37;
            _str[37] = _b.txt38;
            _str[38] = _b.txt39;
            _str[39] = _b.txt40;
            _str[40] = _b.txt41;
            _str[41] = _b.txt42;
            _str[42] = _b.txt43;
            _str[43] = _b.txt44;
            _str[44] = _b.txt45;
            _str[45] = _b.txt46;
            _str[46] = _b.txt47;
            _str[47] = _b.txt48;
            _str[48] = _b.txt49;
            _str[49] = _b.txt50;
            _str[50] = _b.txt51;
            _str[51] = _b.txt52;
            _str[52] = _b.txt53;
            _str[53] = _b.txt54;
            _str[54] = _b.txt55;
            _str[55] = _b.txt56;
            _str[56] = _b.txt57;
            _str[57] = _b.txt58;
            _str[58] = _b.txt59;
            _str[59] = _b.txt60;
            _str[60] = _b.txt61;
            //_str[61] = _b.txt62;

            return _str.AddQutation();
        }

        public static string[] WriteCtr(CTRViewModel _ct)
        {
            string[] _c = new string[5];
            _c[0] = _ct.txt1;
            _c[1] = _ct.txt2;
            _c[2] = _ct.txt3;
            _c[3] = _ct.txt4;
            _c[4] = _ct.txt5;

            return _c.AddQutation();
        }

        public static string[] WriteCons(CONNViewModel _cons)
        {
            string[] _co = new string[22];
            _co[0] = _cons.txt1;
            _co[1] = _cons.txt2;
            _co[2] = _cons.txt3;
            _co[3] = _cons.txt4;
            _co[4] = _cons.txt5;
            _co[5] = _cons.txt6;
            _co[6] = _cons.txt7;
            _co[7] = _cons.txt9;
            _co[8] = _cons.txt8;
            _co[9] = _cons.txt10;
            _co[10] = _cons.txt11;
            _co[11] = _cons.txt12;
            _co[12] = _cons.txt13;
            _co[13] = _cons.txt14;
            _co[14] = _cons.txt15;
            _co[15] = _cons.txt16;
            _co[16] = _cons.txt17;
            _co[17] = _cons.txt18;
            _co[18] = _cons.txt19;
            _co[19] = _cons.txt20;
            _co[20] = _cons.txt21;
            _co[21] = _cons.txt22;


            return _co.AddQutation();
        }
    }
}
