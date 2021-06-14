using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {

            //string continueFlag;
            //do
            //{

            //    Console.WriteLine("Enter 5 numbers to sum ");
            //    int one = int.Parse(Console.ReadLine());
            //    int two = int.Parse(Console.ReadLine());
            //    int three = int.Parse(Console.ReadLine());
            //    int four = int.Parse(Console.ReadLine());
            //    int five = int.Parse(Console.ReadLine());

            //    int[] arr = new int[] { one, two, three, four, five };

            //    int sum = arr.Sum();

            //    Console.WriteLine(sum);

            //    Console.WriteLine("Would you like to continue? (y/n)");
            //    continueFlag = Console.ReadLine();

            //} while (continueFlag == "y");



            //string continueFlag2;
            //do
            //{

            //    Console.WriteLine("Enter 5 numbers to return the median");
            //    int one = int.Parse(Console.ReadLine());
            //    int two = int.Parse(Console.ReadLine());
            //    int three = int.Parse(Console.ReadLine());
            //    int four = int.Parse(Console.ReadLine());
            //    int five = int.Parse(Console.ReadLine());



            //    List<int> myNums = new List<int> { one, two, three, four, five };

            //    myNums.Sort();

            //    Console.WriteLine(myNums[2]);


            //    Console.WriteLine("Would you like to continue? (y/n)");
            //    continueFlag2 = Console.ReadLine();

            //} while (continueFlag2 == "y");




            string continueFlag3;
            do
            {

                Dictionary<string, int> students = new Dictionary<string, int>();
                students.Add("Ryan", 25);
                students.Add("Ted", 26);
                students.Add("Jen", 27);
                students.Add("Fred", 28);
                students.Add("Ned", 29);
                students.Add("Dave", 30);
                students.Add("Steve", 31);
                students.Add("Claire", 32);
                students.Add("Joel", 33);
                students.Add("Nick", 34);

                Console.WriteLine("Enter a Students Name");
                string name = Console.ReadLine();

                bool keyExists = students.ContainsKey(name);
                if (keyExists)
                {
                    foreach (var pair2 in students)
                    {
                        if (pair2.Key == name)
                        {
                            Console.WriteLine($"{ pair2.Key} is {pair2.Value} years old");
                        }

                    }

                }
                else
                {
                    Console.WriteLine("not vaild name");


                }

                Console.WriteLine("Would you like to continue? (y/n)");
                continueFlag3 = Console.ReadLine();

            } while (continueFlag3 == "y");




        }
    }
}
