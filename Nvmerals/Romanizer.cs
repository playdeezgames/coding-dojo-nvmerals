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
            if(value==9) return "IX";

            var sb = new StringBuilder();

            if(value>=5)
            {
                sb.Append("V");
                value-=5;
            }

            if(value==4)
            {
                sb.Append("IV");
                value-=4;
            }

            while(value>0)
            {
                sb.Append("I");
                value--;
            }
            
            return sb.ToString();
        }
    }
}
