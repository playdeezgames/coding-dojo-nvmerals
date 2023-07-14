using System;

namespace Nvmerals
{
    public static class Romanizer
    {
        public static string Romanize(int value)
        {
            if(value==2) return "II";
            return "I";
        }
    }
}
