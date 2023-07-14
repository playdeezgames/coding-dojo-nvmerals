using System;
using System.Text;

namespace Nvmerals
{
    public static class Romanizer
    {
        // I - 1
        // V - 5
        // X - 10
        // L - 50
        // C - 100
        // D - 500
        // M - 1000
        public static string Romanize(int value)
        {
            var sb = new StringBuilder();

            value = DoTheNs(10,"X",value, sb);

            value = DoTheNs(9,"IX",value, sb);

            value = DoTheNs(5,"V",value, sb);

            value = DoTheNs(4,"IV",value, sb);

            value = DoTheNs(1,"I",value, sb);

            return sb.ToString();
        }

        private static int AddVWhenMoreThanFive(int value, StringBuilder sb)
        {
            return DoTheNs(5,"V",value,sb);
        }

        private static int DoTheIV(int value, StringBuilder sb)
        {
            return DoTheNs(4,"IV",value,sb);
        }


        private static int DoTheIX(int value, StringBuilder sb)
        {
            return DoTheNs(9,"IX",value, sb);
        }
        private static int DoTheNs(int n, string s, int value, StringBuilder sb)
        {
            while (value >= n)
            {
                value -= n;
                sb.Append(s);
            }

            return value;
        }
        private static int DoTheXs(int value, StringBuilder sb)
        {
            return DoTheNs(10,"X",value,sb);
        }
        private static int DoTheIs(int value, StringBuilder sb)
        {
            return DoTheNs(1,"I",value,sb);
        }
    }
}
