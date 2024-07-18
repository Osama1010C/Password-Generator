using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Password_Genrator
{
    class Generator
    {
        private static char[] easyChars = { '1', '2', '3','4','5','6','7','8','9','0','a',
                                'b','c','q','w','e','r','t','y','u','i','o','p'
                                ,'s','d','f','g','h','j','k','l','z','x','c','v'
                                ,'n','m'};
        private static char[] hardChars = { '1', '2', '3','4','5','6','7','8','9','0','a',
                                'b','c','q','w','e','r','t','y','u','i','o','p'
                                ,'s','d','f','g','h','j','k','l','z','x','c','v'
                                ,'n','m','Q','W','E','R','T','Y','U','I','O','P'
                                ,'A','S','D','F','G','H','J','K','L','Z','X','C'
                                ,'V','B','N','M','!','@','#','$','%','^','&','*','(',
                                ')','-','_','=','+','{','}','[',']',',','.','?'
                                ,'/','`','~',';',':'};
        public static String[] SmallPassword()
        {
            Random r = new Random();
            String[] pass = { "", "" };
            for (int i = 0; i < 8; i++)
            {
                int num = r.Next(0, easyChars.Length);
                int n = num;
                pass[0] += easyChars[n];
            }
            for (int i = 0; i < 8; i++)
            {
                int num = r.Next(0, hardChars.Length);
                int n = num;
                pass[1] += hardChars[n];
            }

            return pass;
        }

        public static String[] MediumPassword()
        {
            Random r = new Random();
            String[] pass = { "", "" };
            for (int i = 0; i < 15; i++)
            {
                int num = r.Next(0, easyChars.Length);
                int n = num;
                pass[0] += easyChars[n];
            }
            for (int i = 0; i < 15; i++)
            {
                int num = r.Next(0, hardChars.Length);
                int n = num;
                pass[1] += hardChars[n];
            }

            return pass;
        }

        public static String[] HardPassword()
        {
            Random r = new Random();
            String[] pass = { "", "" };
            for (int i = 0; i < 25; i++)
            {
                int num = r.Next(0, easyChars.Length);
                int n = num;
                pass[0] += easyChars[n];
            }
            for (int i = 0; i < 25; i++)
            {
                int num = r.Next(0, hardChars.Length);
                int n = num;
                pass[1] += hardChars[n];
            }

            return pass;
        }
    }
}
