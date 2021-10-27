using System;

/*
 * 
 * Напишите FizzBuzz программу - вам надо вывести на экран числа от 1 до 100, 
 * но когда число делится на три оно заменяется на fizz, если число делится на пять, 
 * то на buzz. Числа, делящиеся на три и пять одновременно заменяются на строку "fizz buzz". 
 * **найти способ вывести менее чем за 100 итераций цикла
 * 
 */
namespace Task_2__additional_
{
    class Program
    {
        static void Main(string[] args)
        {

            /* 
             * При том, что нужно сделать меньше 100 итераций при 100 строках,
             * пришла мысль найти шаблон. Он основан на том, что наименьший делитель одновременно
             * на 3 и на 5 - 15. Последовательность чисел и fizz/buzz повторяются каждые 15 чисел,
             * что было проверено руками в блокноте. 
             * 
             * Шаблон получается таким: i, i+1, fizz, i+3, buzz, fizz, i+6,i+7,fizz,buzz,i+10,fizz,i+12,i+13,fizzbuzz
            */

            // инт является целочисленным числом, поэтому при делении на 15 мы потеряем дробную часть
            // умножив обратно - получим число, до которого шаблон будет идти с шагом 15.
            int lastNumber = 100;
            int maxPattern = (lastNumber / 15) * 15;


            for (int i = 1; i < maxPattern; i += 15) //количество итераций - 6: 1-15, 16-30,17-45,46-60,61-75,76-90
            {
                int b = i;
                Console.WriteLine(b);
                Console.WriteLine(b + 1);
                Console.WriteLine("fizz");
                Console.WriteLine(b + 3);
                Console.WriteLine("buzz");
                Console.WriteLine("fizz");
                Console.WriteLine(b + 6);
                Console.WriteLine(b + 7);
                Console.WriteLine("fizz");
                Console.WriteLine("buzz");
                Console.WriteLine(b + 10);
                Console.WriteLine("fizz");
                Console.WriteLine(b + 12);
                Console.WriteLine(b + 13);
                Console.WriteLine("fizzbuzz");
            }

            // здесь добиваем хвост. Здесь будет еще 10 итераций (91,92,93,94,95,96,97,98,99,100). Итого 16.
            for (int i = maxPattern+1; i <= lastNumber; i++)
            {

                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("fizzbuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();
        }
    }
}
