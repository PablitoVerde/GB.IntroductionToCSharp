using System;

/*
 * Вернуть наибольшую совпадающую подстроку из двух строк.
 */

namespace Task_5
{
    class Program
    {
        //публичная переменная, которая хранит текущий ответ на задачу (можно решить ref/out, включив данную переменную, вероятно, в метод мэйн).
        static string finalResult = "";
        static void Main()
        {
            //Получение пользовательских данных
            Console.WriteLine("Программа по поиску наибольшей подстроки среди двух строк.");

            Console.WriteLine("Введите первую строку.");
            string stringNumberOne = Console.ReadLine();

            Console.WriteLine("Введите вторую строку.");
            string stringNumberTwo = Console.ReadLine();

            //Создание массивов символов
            char[] chars1 = stringNumberOne.ToCharArray();
            char[] chars2 = stringNumberTwo.ToCharArray();

            string stringResult = "";          

            //перечисление всех элементов двух массивов
            for (int i = 0; i < chars1.Length; i++)
            {
                for (int j = 0; j < chars2.Length; j++)
                {
                    stringResult = GetLine(chars1, chars2, i, j, stringResult);
                }
            }

            Console.WriteLine(finalResult);

            Console.ReadKey();

        }

        //Метод, принимает 2 массива, текущий индекс в обоих массивах и промежуточный результат
        static string GetLine(char[] _chars1, char[] _chars2, int _i, int _j, string _result)
        {
            if (_i != _chars1.Length && _j != _chars2.Length)
            {
                if (_chars1[_i] == _chars2[_j])
                {
                    _result += _chars1[_i];

                    GetLine(_chars1, _chars2, _i + 1, _j + 1, _result);
                }
                
                //Прекратить заполнять новую строку совпадающих переменных, если очередной элемент не совпал
                else
                {
                    GetMax(_result);
                    _result = "";
                }
            }
            //Прекратить заполнять новую строку совпадающих переменных, если один из массивов закончился
            else
            {
                GetMax(_result);
                _result = "";
            }

            return _result;
        }

        //Метод сравнения двух строк решения: содержащую итоговый ответ и содержащую текущий ответ
        static void GetMax(string _result)
        { 
            if (finalResult.Length < _result.Length)
                finalResult = _result;          
        }
    }
}
