using System;

namespace Nvmerals
{
    public static class Romanizer
    {
        public static string Romanize(int value)
        {
            if(value==7) return "VII";
            else if(value==6) return "VI";
            else if(value==5) return "V";
            else if(value==4) return "IV";
            else if(value==3) return "III";
            else if(value==2) return "II";
            else return "I";
        }
    }
}
