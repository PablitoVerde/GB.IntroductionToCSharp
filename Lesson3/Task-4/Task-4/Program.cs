using System;

//*«Морской бой»: вывести на экран массив 10х10, состоящий из символов X и O, где Х — элементы кораблей, а О — свободные клетки.

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Морской бой");

            string[,] gameField = new string[10, 10];

            char[] gameFieldColumns = { 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ж', 'З', 'И', 'К' };
            string[] gameFieldRows = { "1  ", "2  ", "3  ", "4  ", "5  ", "6  ", "7  ", "8  ", "9  ", "10 " };


            //Отрисовка буквенных координат
            Console.Write("   ");
            for (int i = 0; i < gameFieldColumns.Length; i++)
            {
                Console.Write(gameFieldColumns[i]);
            }
            Console.Write("\n");

            //Заполнение поля игры "водой"
            for (int i = 0; i < 10; i++)
            {
                //отрисовка координат цифр
                Console.Write(gameFieldRows[i]);
                for (int j = 0; j < 10; j++)
                {
                    gameField[i, j] = "O";
                    Console.Write(gameField[j, i]);
                }

                // переход на новую строку
                Console.Write("\n");
            }

            //запрос на однопалубные корабли
            for (int k = 1; k <= 4; k++)
            {
                Console.WriteLine("Укажите координаты одного однопалубного корабля через запятую:");

                string s = Console.ReadLine();
                string[] coordinatesBoat = s.Split(',');

                int coordinateY = Convert.ToInt32(coordinatesBoat[1])-1;
                int coordinateХ = 0;

                for (int i = 1; i <= gameFieldColumns.Length; i++)
                {
                    if (gameFieldColumns[i-1].ToString() == coordinatesBoat[0])
                    {
                        coordinateХ = i-1;
                        break;
                    }
                }
                gameField[coordinateХ, coordinateY] = "X";

            }

            //Отрисовка поля с кораблями
            Console.Write("\n");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(gameField[j, i]);
                }

                // переход на новую строку
                Console.Write("\n");
            }

            Console.ReadKey();
        }
    }
}
