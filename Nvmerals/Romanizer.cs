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

            while(value>=10)
            {
                value -= 10;
                sb.Append("X");
            }

            value = DoTheIX(value, sb);

            value = AddVWhenMoreThanFive(value, sb);

            value = DoTheIV(value, sb);

            value = DoTheIs(value, sb);

            return sb.ToString();
        }

        private static int DoTheIX(int value, StringBuilder sb)
        {
            if (value == 9)
            {
                value -= 9;
                sb.Append("IX");
            }

            return value;
        }

        private static int AddVWhenMoreThanFive(int value, StringBuilder sb)
        {
            if (value >= 5)
            {
                sb.Append("V");
                value -= 5;
            }

            return value;
        }

        private static int DoTheIV(int value, StringBuilder sb)
        {
            if (value == 4)
            {
                sb.Append("IV");
                value -= 4;
            }

            return value;
        }

        private static int DoTheIs(int value, StringBuilder sb)
        {
            while (value > 0)
            {
                sb.Append("I");
                value--;
            }

            return value;
        }
    }
}
