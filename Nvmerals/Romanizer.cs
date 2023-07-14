using System;
using System.Collections.Generic;
using System.Linq;
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
        private static readonly IReadOnlyList<(int number, string text)> grapthars=new List<(int,string)>
        {
            (1000,"M"),
            (900,"CM"),
            (500,"D"),
            (400,"CD"),
            (100,"C"),
            (90,"XC"),
            (50,"L"),
            (40,"XL"),
            (10,"X"),
            (9,"IX"),
            (5,"V"),
            (4,"IV"),
            (1,"I"),
        };
        public static string Romanize(int value)
        {
            //
            // aggregate grapthars DoTheNs
            return grapthars.Aggregate(
                (value,new StringBuilder()),
                (a,b)=>(DoTheNs(b.number,b.text,a.Item1,a.Item2),a.Item2)).Item2.ToString();
            // foreach(var hammer in grapthars)
            // {
            //     value = DoTheNs(hammer.number,hammer.text,value,sb);
            // }
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
    }
}
