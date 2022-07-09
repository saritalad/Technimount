using System;

namespace A_dllDemo
{
    public class StringFunction
    {
        public static string JoinName(string f,string l)
        {
            return f + " " + l;
        }

        public static string Upper(string u)
        {
            return u.ToUpper();
        }
        public static string Lower(string u)
        {
            return u.ToLower();
        }

    }
}
