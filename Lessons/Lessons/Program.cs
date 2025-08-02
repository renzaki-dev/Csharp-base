using System;


namespace Lessons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a, b;
            //a = 7;
            //b = 3;
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //bool variable1 = false;
            //bool variable2 = true;
            //Console.WriteLine(variable1);
            //Console.WriteLine(variable2);

            //double variable3 = 3.14;
            //char variable4 = '#';
            //string variable5 = "Hello, World!!!!";

            //Console.WriteLine(variable3);
            //Console.WriteLine(variable4);
            //Console.WriteLine(variable5);

            //string data;
            //data = Console.ReadLine(); // Input
            //Console.WriteLine("Hello " + data);

            Console.WriteLine("Первое число = ");
            string data1 = Console.ReadLine();
            int a = Convert.ToInt32(data);

            Console.WriteLine("Второе число = ");
            string data2 = Console.ReadLine();
            int b = Convert.ToInt32(data2);


            int sum = a + b;


            Console.WriteLine("Summary = " + sum);
            Console.ReadLine();
        }
    }
}
