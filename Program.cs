using System;
using System.Collections.Generic;

namespace boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<object> box = new List<object>();

            box.Add(7);
            box.Add(28);
            box.Add(-1);
            box.Add(true);
            box.Add("chair");

            int sum = 0;
            foreach(var obj in box) {
                Console.WriteLine(obj);
                if(obj is int) {
                    sum += (int)obj;
                }
            }
            Console.WriteLine("The sum of all the integers in the list is {0}", sum);
            
        }
    }
}
