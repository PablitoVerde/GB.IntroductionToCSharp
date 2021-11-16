using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * 
 * Задача - есть рюкзак, максимальной грузоподъемности W. И есть какое-то количество вещей, у каждой вещи есть цена и вес. 
 * Надо собрать рюкзак чтобы суммарная ценность вещей в нем была максимальная. Т.е. вам надо написать функцию 
 * int GetPackedBag(int maxWeight, int[] itemsPrice, int[] itemsWeight)
 * */

namespace Task_6__additional_
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Соберем рюкзак!");
            Console.Write("Введите максимальную грузоподъемность: ");
            int w = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите массив весов предметов через пробел: ");
            string s = Console.ReadLine();

            int[] itemsWeight = GetIntNumbersFromString(s);

            Console.WriteLine("Введите массив стоимости предметов через пробел: ");
            string s2 = Console.ReadLine();

            int[] itemsPrice = GetIntNumbersFromString(s2);

            int[] j = new int[2];
            int[] result = GetMaxPriceWeight(w, itemsPrice, itemsWeight, j);


            Console.WriteLine($"Максимальный вес {result[0]}, максимальная цена {result[1]}");

            Console.ReadKey();
        }

        static int[] GetIntNumbersFromString(string _s)
        {
            string[] _numbers = _s.Split(' ');
            int[] result = new int[_numbers.Length];
            for (int i = 0; i < _numbers.Length; i++)
            {
                result[i] = Convert.ToInt32(_numbers[i]);
            }
            return result;
        }

        static int[] GetMaxPriceWeight(int _maxweight, int[] _itemsprice, int[] _itemsweight, int[] _currentresult)
        {
            int[] result = new int[2];
            result[0] = _currentresult[0];
            result[1] = _currentresult[1];

            for (int i = 0; i < _itemsprice.Length; i++)
            {
                if (_itemsweight[i] < _maxweight && _itemsweight[i] + result[0] <= _maxweight)
                {
                    result[1] += _itemsprice[i];
                    result[0] += _itemsweight[i];

                    if (_itemsprice.Length > 1)
                    {
                        int[] _itemsprice2 = new int[_itemsprice.Length - 1];
                        for (int k = 0; k < _itemsprice2.Length; k++)
                        {
                            _itemsprice2[k] = _itemsprice[k + 1];
                        }

                        int[] _itemsweight2 = new int[_itemsweight.Length - 1];
                        for (int h = 0; h < _itemsweight2.Length; h++)
                        {
                            _itemsweight2[h] = _itemsweight[h + 1];
                        }

                        GetMaxPriceWeight(_maxweight, _itemsprice2, _itemsweight2, result);
                    }
                }
                else
                {
                    if (_itemsprice.Length > 1)
                    {
                        int[] _itemsprice2 = new int[_itemsprice.Length - 1];
                        for (int k = 0; k < _itemsprice2.Length; k++)
                        {
                            _itemsprice2[k] = _itemsprice[k + 1];
                        }

                        int[] _itemsweight2 = new int[_itemsweight.Length - 1];
                        for (int h = 0; h < _itemsweight2.Length; h++)
                        {
                            _itemsweight2[h] = _itemsweight[h + 1];
                        }

                        GetMaxPriceWeight(_maxweight, _itemsprice2, _itemsweight2, result);
                    }
                }
            }
            return result;
        }
    }
}
