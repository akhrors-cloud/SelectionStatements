using System;

namespace ifCondition
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            Console.WriteLine("What is your favourite number from 1 to 1000 ?");
            Console.WriteLine("--------------------------------------\n");




            var toHigh = " Too high";
            var toMedium = " Too Medium";
            var toLow = " Too low";
            var toLowest = " the lowest";

            int num = int.Parse(Console.ReadLine());
            

            if (num >= 800 && num <= 1000)
            {
                Console.WriteLine($" your number is {num} that is {toHigh}");
             
            }
            else if(num >= 600 && num <= 800) {
                Console.WriteLine($"your number is {num} that is  {toMedium}");
            }
            else if (num >= 400 && num <= 600) {
                Console.WriteLine($"your number is {num} that is  {toLow}");
            }
            else if (num >= 1 && num <= 500)
                    {
                Console.WriteLine($"your number is {num} that is  {toLowest}");
            }
            else
            {
                Console.WriteLine("do something else");
            }
             

        }
    }
}
