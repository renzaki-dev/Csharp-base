using System;
using System.Linq.Expressions;


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

            //-----------------------------------------------------------------


            //string data;
            //data = Console.ReadLine(); // Input
            //Console.WriteLine("Hello " + data);

            //Console.WriteLine("Первое число = ");
            //string data1 = Console.ReadLine();
            //int a = Convert.ToInt32(data);

            //Console.WriteLine("Второе число = ");
            //string data2 = Console.ReadLine();
            //int b = Convert.ToInt32(data2);


            //int sum = a + b;


            //Console.WriteLine("Summary = " + sum);
            //Console.ReadLine();

            //-----------------------------------------------------------------


            //string data;
            //Console.WriteLine("number A = ");
            //data = Console.ReadLine();
            //int a = Convert.ToInt32(data);

            //Console.WriteLine("number B = ");
            //data = Console.ReadLine();
            //int b = Convert.ToInt32(data);

            //int sum = (a + b) / 2;

            //Console.WriteLine(sum);
            //Console.ReadLine();

            //-----------------------------------------------------------------

            //string data;
            //Console.WriteLine("number A = ");
            //data = Console.ReadLine();
            //int a = Convert.ToInt32(data);

            //Console.WriteLine("number B = ");
            //data = Console.ReadLine();
            //int b = Convert.ToInt32(data);

            //int sum = (a + b) / 2;

            //Console.WriteLine(sum);
            //Console.ReadLine();

            //-----------------------------------------------------------------

            //string data;
            //int a, b, c;

            //Console.WriteLine("A = ");
            //data = Console.ReadLine();
            //a = Convert.ToInt32(data);

            //Console.WriteLine("B = ");
            //data = Console.ReadLine();
            //b = Convert.ToInt32(data);

            //Console.WriteLine("C = ");
            //data = Console.ReadLine();
            //c = Convert.ToInt32(data);

            //int sum = a + b + c;
            //int multiply = a * b * c;

            //Console.WriteLine("Summary = " + sum);
            //Console.WriteLine("Произведение = " + multiply);
            //Console.ReadLine();

            //-----------------------------------------------------------------

            //string data;
            //int dollor;
            //double som = 12.625;

            //Console.WriteLine("Введите сумму в Доллaрах: ");
            //data = Console.ReadLine();
            //dollor = Convert.ToInt32(data);

            //double result = dollor * som;
            //Console.WriteLine("Доллaр в сум: " + result);

            //Console.ReadLine();

            //-----------------------------------------------------------------



            //Console.WriteLine("Введите число для проверки на четность: ");
            //int a = int.Parse(Console.ReadLine());
            //if (a % 2 == 0)
            //{
            //    Console.WriteLine("четное");
            //}
            //else
            //{
            //    Console.WriteLine("нечетное");

            //}

            //-----------------------------------------------------------------

            //Console.WriteLine("Введите первое число: ");
            //string a = Console.ReadLine();
            //int firstNumber = int.Parse(a);

            //Console.WriteLine("Что хотите +, -, *, /  : ");
            //string operation = Console.ReadLine();
            //Console.WriteLine("Введите второе число: ");
            //string b = Console.ReadLine();
            //int secondNumber = int.Parse(b);

            //if(operation == "+")
            //{
            //    Console.WriteLine("Result: " + (firstNumber + secondNumber));
            //} else if(operation == "-")
            //{
            //    Console.WriteLine("Result: " + (firstNumber - secondNumber));
            //}
            //else if (operation == "*")
            //{
            //    Console.WriteLine("Result: " + (firstNumber * secondNumber));
            //}
            //else if (operation == "/")
            //{
            //    Console.WriteLine("Result: " + (firstNumber / secondNumber));
            //} else
            //{
            //    Console.WriteLine("Что то пошло не так!!");
            //}


            //-----------------------------------------------------------------

            Console.WriteLine("Введите первое число: ");
            string a = Console.ReadLine();
            int firstNumber = int.Parse(a);

            Console.WriteLine("Что хотите +, -, *, /  : ");
            string operation = Console.ReadLine();
            Console.WriteLine("Введите второе число: ");
            string b = Console.ReadLine();
            int secondNumber = int.Parse(b);

            switch(operation)
            {
                case "+":
                    Console.WriteLine("Result: " + (firstNumber + secondNumber));
                    break;
                case "-":
                    Console.WriteLine("Result: " + (firstNumber - secondNumber));
                    break;

                default:
                    Console.WriteLine("Что то пошло не так!!");
                    break;
            }

        }
    }
}
