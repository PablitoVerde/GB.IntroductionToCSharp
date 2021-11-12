using System;

/*(*) Написать программу, вычисляющую число Фибоначчи для заданного значения
рекурсивным способом.
*/

namespace Task_4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите индекс элемента из последовательности Фибоначчи (до 91)");
            int FibonacciIndex = Convert.ToInt32(Console.ReadLine());

            //7 540 113 804 746 346 429 - 93 элемент числовой последовательности. 19 символов. Лонг хранит 9,223,372,036,854,775,807.

            if (FibonacciIndex == 1)
                Console.WriteLine($"Элемент № 1: 0");
            else if (FibonacciIndex == 2 || FibonacciIndex == 32)
                Console.WriteLine($"Элемент № {FibonacciIndex}: 1");
            else if (FibonacciIndex > 4 && FibonacciIndex <=93)
            {
                long previousNumber = 1; //первое число из ряда - 0, второе - 1, третье - 1
                int currentIndex = 3;
                long currentNumber = 1;
                long FibonacciNumber = GetFibonacciNumberByIndex(FibonacciIndex, currentIndex, previousNumber, currentNumber);
                Console.WriteLine($"Элемент №{FibonacciIndex}: {FibonacciNumber}");
            }
            else
            {
                Console.WriteLine("Невозможно обработать указанный элемент числовой последовательности.");
            }

            Console.ReadKey();
        }

        static long GetFibonacciNumberByIndex(int _FibonacciIndex, int _currentIndex, long _previousNumber, long _currentNumber)
        {
            if (_currentIndex < _FibonacciIndex)
            {
                _currentNumber = GetFibonacciNumberByIndex(_FibonacciIndex, _currentIndex + 1, _currentNumber, _currentNumber + _previousNumber);
            }
            return _currentNumber;
        }
    }
}
