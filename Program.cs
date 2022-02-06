using System;

namespace ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[13];

            names[0] = "Ivan";
            names[1] = "Maks";
            names[2] = "Min";
            names[3] = "IKolz";
            names[4] = "Nina";
            names[5] = "Sergey";
           
            Console.WriteLine("Введите Ваше имя");
            names[6] = Console.ReadLine();

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }           
        }
    }
}

