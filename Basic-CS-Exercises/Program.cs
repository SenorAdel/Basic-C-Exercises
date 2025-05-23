using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

//exercises website ( https://www.w3resource.com/csharp-exercises/ )
//this Project is good for practicing C# for beginners like me :P

namespace exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Basic_1();
            Basic_2();
            Basic_3();
            Basic_4();
            Basic_5();
            Basic_6();
            Basic_7();
            Basic_8();
            Basic_9();
            Basic_10();
            Basic_11();
            Basic_12();
            Basic_13();
            Basic_14();
            //15,16,17 skipped
            Basic_18();
            Basic_19();
            Basic_20();
            Basic_21(); 
            Basic_22();
            Basic_23();
            Basic_24(); 
            Basic_25();*/



            /*
            basic_algo_1();
            basic_algo_2();
            basic_algo_3();

            exception_Handling_1();
            exception_Handling_2();
            exception_Handling_3();
            exception_Handling_4();*/
            exception_Handling_5();

            /*data_types_1();

            conditional_statement_1();

            for_loop_1();
            for_loop_2();*/



            Console.ReadKey();
        }
        static void Basic_1()
        {
            Console.WriteLine("Hello:");
            Console.WriteLine("Adel Sulaiman");
        }
        static void Basic_2()
        {
            Console.WriteLine("Enter the 1st num");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the 2nd num");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num1 + num2);
            Console.WriteLine("----------------------------------------");
        }
        static void Basic_3()
        {
            Console.WriteLine("Enter the 1st num");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the 2nd num");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num1 / num2);
            Console.WriteLine("----------------------------------------");

        }
        static void Basic_4()
        {
            Console.WriteLine("Enter the 1st num");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What you want to do with your nums (+,-,*,/)");
            string operations = Console.ReadLine();

            Console.WriteLine("Enter the 2nd num");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (operations == "-")
            {
                Console.WriteLine(num1 - num2);
            }
            else if (operations == "+")
            {
                Console.WriteLine(num1 + num2);
            }
            else if (operations == "*")
            {
                Console.WriteLine(num1 * num2);
            }
            else if (operations == "/")
            {
                Console.WriteLine(num1 / num2);

            }
            Console.WriteLine("----------------------------------------");

        }
        static void Basic_5()
        {
            Console.WriteLine("swap two numbers");
            Console.WriteLine("First num");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Second num");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(num2);
            Console.WriteLine(num1);
            Console.WriteLine("----------------------------------------");

        }
        static void Basic_6()
        {
            Console.WriteLine("enter three numbers to multiplication");

            Console.WriteLine("Enter the 1st num");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the 2nd num");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the 3rd num");
            int num3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num1 * num2 * num3);
            Console.WriteLine("----------------------------------------");

        }
        static void Basic_7()
        {
            Console.WriteLine("Enter two numbers to (adding, subtracting, multiplying and dividing)");

            Console.WriteLine("Enter the 1st num");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the 2nd num");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num1 + num2);
            Console.WriteLine(num1 - num2);
            Console.WriteLine(num1 * num2);
            Console.WriteLine(num1 / num2);
            Console.WriteLine("----------------------------------------");

        }
        static void Basic_8()
        {
            Console.WriteLine("enter a number to multiplying");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter how many time to multiplying");
            int multiply = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < multiply; i++)
            {
                int result = num1 * i;
                Console.WriteLine(result);
            }
            Console.WriteLine("----------------------------------------");

        }
        static void Basic_9()
        {
            Console.WriteLine("Enter the 1st num");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the 2nd num");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the 3rd num");
            int num3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the 4th num");
            int num4 = Convert.ToInt32(Console.ReadLine());
            double result = (num1 + num2 + num3 + num4) / 4;
            Console.WriteLine(result);
            Console.WriteLine("----------------------------------------");

        }
        static void Basic_10()
        {
            int number1, number2, number3;

            Console.WriteLine("Enter first number:");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third number:");
            number3 = Convert.ToInt32(Console.ReadLine());

            int Result1 = ((number1 + number2) * number3);
            int Result2 = (number1 * number2 + number2 * number3);

            Console.WriteLine($"Result is (x+y)•z is {Result1} and x•y + y•z is {Result2}");
            Console.WriteLine("----------------------------------------");

        }
        static void Basic_11()
        {
            Console.WriteLine("enter your old");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num >= 20)
            {
                Console.WriteLine("you are older then 20 years");

            }
            else
            {
                Console.WriteLine("you are younger then 20 years ");
            }
            Console.WriteLine("----------------------------------------");


        }
        static void Basic_12()
        {
            Console.WriteLine("input number");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num + "" + num + "" + num + "" + num);
            Console.WriteLine(num + num + num + num);
            Console.WriteLine(num + "" + num + "" + num + "" + num);
            Console.WriteLine(num + num + num + num);
            Console.WriteLine("----------------------------------------");

        }
        static void Basic_13()
        {
            Console.WriteLine("enter a number to repeat");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num + num + num);
            Console.WriteLine(num + "" + num + "" + num);
            Console.WriteLine(num + "" + num + "" + num);
            Console.WriteLine(num + "" + num + "" + num);
            Console.WriteLine(num + num + num);
            Console.WriteLine("----------------------------------------");

        }
        static void Basic_14()
        {
            Console.WriteLine("enter the temperature in degrees celsius (°C) to get it in Kelvin and Fahrenheit");
            int num = Convert.ToInt32(Console.ReadLine());

            double C = num;
            double K = num + 273.15;
            double F = (num * 1.8) + 32;
            Console.WriteLine($"Temperature is {num}°C" + $"\n {K} Kelvin" + $"\n {F} fahrenheit");
            Console.WriteLine("----------------------------------------");

        }
        static void Basic_18()
        {
            Console.WriteLine("This programm check if the inputs (- and +)");
            Console.Write("First input: ");
            int inp1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Second input: ");
            int inp2 = Convert.ToInt32(Console.ReadLine());

            if (inp1 > -1 && inp2 < 0)
            {
                Console.WriteLine("Ture");
            }
            else
            {
                Console.WriteLine("False");
            }
            Console.WriteLine("----------------------------------------");
        }
        static void Basic_19()
        {
            Console.WriteLine("this program give the sum for 2 numbers but if the numbers are same return the triple of their sum: ");

            Console.Write("First input: ");
            int inp1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Second input: ");
            int inp2 = Convert.ToInt32(Console.ReadLine());

            if (inp1 == inp2)
            {
                Console.WriteLine(((inp1 + inp2) * 3));
            }
            else
            {
                Console.WriteLine(inp1 + inp2);
            }
            Console.WriteLine("----------------------------------------");
        }
        static void Basic_20()
        {
            Console.WriteLine("This program return the difference between two given numbers " +
                "\n if the first number is greater than the second number \n Return double the absolute value of the difference ");

            Console.Write("First input: ");
            int inp1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Second input: ");
            int inp2 = Convert.ToInt32(Console.ReadLine());

            if (inp1 > inp2)
            {
                Console.WriteLine((inp1 - inp2) * 2);
            }
            else
            {
                Console.WriteLine(inp1 - inp2);
            }
            Console.WriteLine("----------------------------------------");
        }
        static void Basic_21()
        {
            Console.WriteLine("this program return true if one of the integers is 20 or if their sum is 20");

            Console.Write("First input: ");
            int inp1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Second input: ");
            int inp2 = Convert.ToInt32(Console.ReadLine());

            if (inp1 == 20 || inp2 == 20 || inp1 + inp2 == 20)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            Console.WriteLine("----------------------------------------");
        }
        static void Basic_22()
        {
            Console.WriteLine("Input an integer:");

            int x = Convert.ToInt32(Console.ReadLine());

            if (x - 100 <= 20 || x - 200 <= 20)
            {
                Console.WriteLine($"result True ");
            }
            else
            {
                Console.WriteLine("result False ");
            }
            Console.WriteLine("----------------------------------------");
        }
        static void Basic_23()
        {
            Console.WriteLine("Enter Uppercase letters to get them Lowercase");
            string inp1 = Console.ReadLine();
            Console.WriteLine(inp1.ToLower());
            Console.WriteLine("----------------------------------------");
        }
        static void Basic_24()
        {
            Console.WriteLine("Write a sentence to get largerest and smallest words:");
            string sentence = Console.ReadLine();

            int zero = 0;

            string[] words = sentence.Split(new[] { " " }, StringSplitOptions.None);
            foreach (string l in words)
            {
                if (l.Length > zero)
                {
                    sentence = l;
                    zero = l.Length;
                }
            }
            Console.WriteLine($"largest word is :{sentence}");
            foreach (string l in words)
            {
                if (l.Length < zero)
                {
                    sentence = l;
                    zero = l.Length;
                }
            }
            Console.WriteLine($"smallest word is :{sentence}");
            Console.WriteLine("----------------------------------------");
        }
        static void Basic_25()
        {
            Console.WriteLine("Odd numbers from 1 to 99. Prints one number per line.");

            for (int j = 1; j < 100; j++)
            {
                if (j % 2 != 0)
                {
                    Console.WriteLine(j);
                }
            }
        }
        static void basic_algo_1()
        {
            Console.WriteLine("sum of the two numerical");

            Console.WriteLine("Enter the 1st num");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the 2nd num");
            double num2 = Convert.ToDouble(Console.ReadLine());
            if (num1 == num2)
            {
                double result = (num1 * 3) + (num2 * 3);
                Console.WriteLine(result);

            }
            else
            {
                Console.WriteLine(num1 + ", " + num2);
            }
            Console.WriteLine("----------------------------------------");

        }
        static void basic_algo_2()
        {
            Console.WriteLine("gib ein number");

            int number = Convert.ToInt32(Console.ReadLine());

            const int x = 51;

            if (number > x)
            {
                Console.WriteLine((number - x) * 3);

            }
            else
                Console.WriteLine(x - number);

            Console.WriteLine("----------------------------------------");

        }
        static void basic_algo_3()
        {
            Console.WriteLine("result check, if number = 30 or sum of it = 30");

            Console.WriteLine("Enter the 1st num");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the 2nd num");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (num1 == 30 || num2 == 30 || num1 + num2 == 30)
            {
                Console.WriteLine("true");

            }
            else
            { Console.WriteLine("false"); }
            ;
            Console.WriteLine("----------------------------------------");

        }
        static void exception_Handling_1()
        {
            Console.WriteLine("enter 2 number to divides them");
            try
            {
                Console.Write("1st number: ");
                string input1 = Console.ReadLine();
                double number1 = Convert.ToDouble(input1);

                Console.Write("2nd number: ");
                string input2 = Console.ReadLine();
                double number2 = Convert.ToDouble(input2);

                if (number2 != 0)
                {
                    double result = number1 / number2;
                    Console.WriteLine("Result: " + result);
                }
                else
                {
                    Console.WriteLine("Error: Cannot divide by zero.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Non-numeric value entered.");
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred: " + e.Message);
            }
            Console.WriteLine("----------------------------------------");

        }
        static void exception_Handling_2()
        {
            Console.WriteLine("enter 2 numbers");
            try
            {
                Console.Write("1st number: ");
                string input1 = Console.ReadLine();
                int number1 = Convert.ToInt32(input1);

                Console.Write("2nd number: ");
                string input2 = Console.ReadLine();
                int number2 = Convert.ToInt32(input2);
                if (number2 < 0)
                {
                    Console.WriteLine("Error: your number is negative");
                }
                else
                {
                    Console.WriteLine("your number fine");
                }
            }

            catch (FormatException)
            {
                Console.WriteLine("Error: Non-numeric value entered.");
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred: " + e.Message);
            }
            Console.WriteLine("----------------------------------------");
        }
        static void exception_Handling_3()
        {
            try
            {
                Console.Write("Enter your file path:");
                string input1 = Console.ReadLine();
                if (File.Exists(input1))
                {
                    Console.WriteLine(" the file does exist :) ");
                }
                else { Console.WriteLine("Something went wrong"); }
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("----------------------------------------");
        }
        static void exception_Handling_4()
        {
            try
            {
                Console.WriteLine("Enter a numeric integer:");
                int input1 = Convert.ToInt32(Console.ReadLine());

                if (input1 < -1 || input1 <= 1000)
                {
                    Console.WriteLine("Fine no Problems");
                }
                else
                {
                    Console.WriteLine("Something went wrong (can be your entered negative number)");
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("----------------------------------------");
        }
        static void exception_Handling_5()
        {
            try
            {
                Console.WriteLine("enter how many numbers would you like to get average for them");
                int input11 = Convert.ToInt32(Console.ReadLine());

                int[] input1 = new int[input11 + 1];  //array

                Console.WriteLine("enter numbers to get the average for  them");

                for (int i = 0; i <= input11; i++) //many inputs
                {
                    int int_input = Convert.ToInt32(Console.ReadLine());
                    input1[i] = int_input;
                }

                foreach (int s in input1)   //Sum of inputs
                {
                    int result = 0;
                    result = result + s;
                    // Need to get the average only 
                }

            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void data_types_1()
        {
            Console.WriteLine("input a letter 3 times");
            Console.Write("input 1st one: ");
            string letter1 = Console.ReadLine();

            Console.Write("input 2nd one: ");
            string letter2 = Console.ReadLine();

            Console.Write("input 3rd one: ");
            string letter3 = Console.ReadLine();

            Console.WriteLine(letter1 + " " + letter2 + " " + letter3);
            Console.WriteLine("----------------------------------------");

        }
        static void conditional_statement_1()
        {
            Console.WriteLine("two integers check are equal or not");

            Console.Write("1st number: ");
            string input1 = Console.ReadLine();
            int number1 = Convert.ToInt32(input1);

            Console.Write("2nd number: ");
            string input2 = Console.ReadLine();
            int number2 = Convert.ToInt32(input2);
            if (number1 == number2)
            {
                Console.WriteLine($"{number1} and {number2} are equal");
            }
            else
            {
                Console.WriteLine($"{number1} and {number2} are not equal");
            }
            Console.WriteLine("----------------------------------------");

        }
        static void for_loop_1()
        {
            Console.WriteLine("A loop");
            Console.WriteLine("enter how many numbers of rows you want: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= number1; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("----------------------------------------");

        }
        static void for_loop_2()
        {
            Console.WriteLine("A loop and the sum of it");
            Console.WriteLine("enter how many numbers of rows you want: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            for (int i = 0; i <= number1; i++)
            {
                Console.WriteLine(i);
                result = result + i;
            }
            Console.WriteLine(result);
            Console.WriteLine("----------------------------------------");

        }







    }
}
