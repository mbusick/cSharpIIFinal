using System;

namespace MyFirstApplication
{
    class Program
    {
        public static void Main(string[] args)
        {


            string[] lines = System.IO.File.ReadAllLines("../../../TextFile1.txt");

            foreach (string line in lines)
            {
                string[] col = line.Split(new char[] { ',' });

                
            }
        }
    }
}
