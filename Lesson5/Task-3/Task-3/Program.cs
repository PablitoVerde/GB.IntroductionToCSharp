using System;
using System.IO;

/*
 * Ввести с клавиатуры произвольный набор чисел (0...255) и записать их в бинарный
файл.
*/

namespace Task_3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите произвольный набор чисел от 0 до 255 через пробел:");
            string userInput = Console.ReadLine();

            
            string[] stringsMass = userInput.Split(' ');
            string programmOutput = Directory.GetCurrentDirectory() + @"\result.bin";


            byte[] bytes = new byte[stringsMass.Length];
            for (int i = 0; i < bytes.Length; i++)
            {
                bytes[i] = Convert.ToByte(stringsMass[i]);               
            }

            
            File.WriteAllBytes(programmOutput, bytes);
            Console.WriteLine("Запись данных в файл завершена.");

            //Блок для проверки
            byte[] b = File.ReadAllBytes(programmOutput);
            foreach (object o in b)
            {
                Console.WriteLine(o);
            }

            Console.ReadKey();
        }
    }
}
