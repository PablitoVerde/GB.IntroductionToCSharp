using System;

//Задание. Написать программу, выводящую элементы двухмерного массива по диагонали.


/*В википедии указывается, что диагональ бывает как в прямоугольной, так и квадратной матрице.
 * При этом двумерный массив в наших условиях является матрицой.
 * 
 * Главная диагональ квадратной матрицы — диагональ, которая проходит через верхний левый и нижний правый углы.
 * Главной диагональю прямоугольной матрицы является диагональ, которая начинается в верхнем левом углу матрицы и 
 * изменяется вниз и вправо, пока не будет достигнут правый или нижний край матрицы.
 */


namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Получение параметров от пользователя
            Console.WriteLine("Привет! Добро пожаловать в программу по работе с массивами!");
            Console.Write("Введи количество столбцов: ");
            int matrixDimensionX = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введи количество строк: ");
            int matrixDimensionY = Convert.ToInt32(Console.ReadLine());

            //Инициализация двумерного массива, заполнение его случайными элементами. Для контроля - вывод их на экран.
            int[,] matrixArray = new int[matrixDimensionX, matrixDimensionY];
            Random rnd = new Random();

            for (int i = 0; i < matrixDimensionX; i++)
            {
                for (int j = 0; j < matrixDimensionY; j++)
                {
                    matrixArray[i, j] = rnd.Next(1, 100);
                    Console.WriteLine($"Элемент {i}{j} - {matrixArray[i, j]}");
                }
            }

            //Поиск диагонали в матрице
            int matrixDiagonalLimit;
            if (matrixDimensionX < matrixDimensionY)
            {
                matrixDiagonalLimit = matrixDimensionX;
            }
            else
            {
                matrixDiagonalLimit = matrixDimensionY;
            }

            //Создание массива для чисел из диагонали матрицы
            int[] matrixDiagonalArray = new int[matrixDiagonalLimit];

            for(int i =0;i<matrixDiagonalLimit;i++)
            {
                matrixDiagonalArray[i] = matrixArray[i, i];
            }

            //Вывод на экран чисел из диагонали матрицы
            for (int i = 0; i < matrixDiagonalArray.Length; i++)
            {
                Console.WriteLine($"Цифры из диагонали матрицы - {matrixDiagonalArray[i]}");
            }

            Console.ReadKey();
        }
    }
}
