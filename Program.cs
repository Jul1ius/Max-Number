using System;

namespace Max_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            double finalNum = 0;
            
            while (num != "Stop")
            {
                double secNum = double.Parse(num);
                if (secNum > finalNum)
                {
                    finalNum = secNum; 
                }
                num = Console.ReadLine();
            }
            Console.WriteLine(finalNum);
        }
    }
}
