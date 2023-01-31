using System;

namespace WriteMassiwFor
{
    class Program
    {
        static void Main(string[] args)
        {

            //string[] names = new string[13];

            //names[0] = "Ivan";

            //Console.WriteLine("Введите ваше имя:");
            //names[1] = Console.ReadLine();

            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine(names[i]);
            //}

            //foreach (var item in names)
            //{
            //    Console.WriteLine(item);
            //}

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
