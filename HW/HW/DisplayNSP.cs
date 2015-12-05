using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW
{
    static class DisplayNSP
    {
        public static string SerName = "Baker";
        public static string Name = "Patrick";
        public static string Patronymic = "Denny";
        static int length = Name.Length + SerName.Length + Patronymic.Length;
        public static int Length { get { return length; } set { length = value; } }

        public static void Output()
        {

            string begin = "+-";
            string end = "+";

            while (true)
            {
                if (begin.Length - 1 == DisplayNSP.Length)
                {
                    begin += "--";
                    begin += end;
                    break;
                }
                begin += "-";
            }
            Console.WriteLine(begin);
            Console.Write("|{0} {1} {2}|\n", DisplayNSP.SerName, DisplayNSP.Name, DisplayNSP.Patronymic);
            Console.WriteLine(begin);

        }
    }
}
