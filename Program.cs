using System;
using System.Collections.Generic;

namespace HelloooWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> strlist = new List<string>();
            strlist.Add("test");
            strlist.Add("of");
            strlist.Add("Netcore2");

            foreach(var str in strlist)
            {
                Console.WriteLine(str);
            }
            
        }
    }
}
