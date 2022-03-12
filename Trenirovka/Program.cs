using System;
using System.Text;

namespace ConsoleApp
{
    class Program
    {
        /// <summary>
        /// Tests
        /// </summary>>
        /// <param name="args"></param>
        /// 
        static void Main(string[] args)
        {
            //bool success = false;
            //Console.WriteLine("Введите число от 1 до 10");
            //do
            //{                
            //    string answer = console.readline();
            //    success = int.tryparse(answer, out int value);

            //    if (value >= 1 && value <= 10)
            //    {
            //        console.writeline("вы ввели: " + value);
            //    }

            //    if (!success)
            //    {
            //        console.writeline("вы ввели не число!");
            //    }

            //} while (!success);

            //string str = "abcdefg";

            //foreach (var item in str)
            //{
            //    console.writeline(item);
            //}

            //string name = "Ivan";
            //string name1 = "Maks K";
            //string name2 = "alexrus";
            //string name3 = "SS limit";
            //string name4 = "Михаил";
            //string name5 = "Sergey Escanor";


            //Console.WriteLine("Введите ваше имя");
            //string name6 = Console.ReadLine();

            //string[] names = new string[13];

            //names[0] = "Ivan";
            //names[1] = "Maks K";
            //names[2] = "alexrus";
            //names[3] = "SS limit";
            //names[4] = "Михаил";
            //names[5] = "Sergey Escanor";

            //Console.WriteLine("Введите ваше имя:");
            //names[6] = Console.ReadLine();

            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine(names[i]);
            //}

            //foreach (var item in names)
            //{
            //    Console.WriteLine(item);
            //}

                                                        //string[] names = new string[13];
                                                        //byte[] ages = new byte[13];
                                                        //string[] phoneNumbers = new string[13];

                                                        //double a = 1;
                                                        //double b = 2;

                                                        //Console.WriteLine("");

                                                        //double c;

            int[] numbers = new int[10];
            
            Random random = new Random();

            for (int i = 0; i < numbers.Length; i++) 
            { 
                numbers[i] = random.Next();
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}