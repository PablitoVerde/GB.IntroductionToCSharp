using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;


/*
 * Список задач (ToDo-list):
● написать приложение для ввода списка задач;
● задачу описать классом ToDo с полями Title и IsDone;
● на старте,если есть файл tasks.json/xml/bin (выбрать формат), загрузить
из него массив имеющихся задач и вывести их на экран;
● если задача выполнена, вывести перед её названием строку «[x]»;
● вывести порядковый номер для каждой задачи;
● при вводе пользователем порядкового номера задачи отметить задачу с этим
порядковым номером как выполненную;
● записать актуальный массив задач в файл tasks.json/xml/bin.
*/

namespace Task_5
{
    class Program
    {
        static void Main()
        {
            //Пути файлов. 1 - для хранения данных между сессиями, 2 - для хранения данных во время сессии.
            string filePath = Directory.GetCurrentDirectory() + @"\tasks.json";
            string filePathTemp = Directory.GetCurrentDirectory() + @"\tasksTemp.json";

            //Проверка наличия файлов, копирование содержимого во временный файл
            ToDo.CheckUsersFile(filePath, filePathTemp);

            //Меню. Обновление реализовано очищением экрана и выводом всех данных на него. Все хранится в файлах.
            bool menuworking = true;
            while (menuworking)
            {
                Console.Clear();
                Console.WriteLine("Список задач");

                LoadTasks(filePathTemp);

                Console.WriteLine($"Что будем делать? \n 1. Добавить задачу. \n 2. Пометить задачу исполненной. \n 3. Выйти.");

                string userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        {
                            Console.Write("Введите задачу: ");
                            ToDo task = new ToDo();
                            task.Title = Console.ReadLine();
                            task.IsDone = false;
                            ToDo.AddTask(task, filePathTemp);
                            break;
                        }
                    case "2":
                        {
                            Console.Write("Введите номер выполненной задачи: ");
                            string taskDoneNumber = Console.ReadLine();
                            ToDo.FulfillTask(Convert.ToInt32(taskDoneNumber), filePathTemp);
                            break;
                        }
                    case "3":
                        {
                            SaveUnDoneTasks(filePathTemp, filePath);
                            menuworking = false;
                            break;
                        }
                }
            }
        }

        //Метод вывода на экран всех задач. В зависимости от решенности присваевается маркер [x]
        static void LoadTasks(string _filepathtemp)
        {
            string str = File.ReadAllText(_filepathtemp);

            if (str != "")
            {
                ToDo[] tasks = JsonSerializer.Deserialize<ToDo[]>(str);
                for (int i = 0; i < tasks.Length; i++)
                {
                    string task;

                    if (tasks[i].IsDone)
                    {
                        task = $"{i + 1}. [x] {tasks[i].Title}.";
                    }
                    else
                    {
                        task = $"{i + 1}. [ ] {tasks[i].Title}.";
                    }
                    Console.WriteLine(task);
                }
            }
        }

        //Сохранение данных в файл при выборе п.3 из меню. Сохраняет только невыполненные задачи
        static void SaveUnDoneTasks(string _filepathtemp, string _filepath)
        {

            string str = File.ReadAllText(_filepathtemp);


            if (str != "")
            {
                ToDo[] tasks = JsonSerializer.Deserialize<ToDo[]>(str);

                int j = 0;
                for (int i = 0; i < tasks.Length; i++)
                {
                    if (tasks[i].IsDone == false)
                    {
                        j++;
                    }
                }

                //создание массива только с невыполненными задачами для сериализации в файл
                ToDo[] tasks2 = new ToDo[j];

                int k = 0;
                for (int i = 0; i < tasks.Length; i++)
                {
                    if (tasks[i].IsDone == false)
                    {
                        tasks2[k] = tasks[i];
                        k++;

                    }

                }

                string jsonser = JsonSerializer.Serialize(tasks2);
                File.WriteAllText(_filepath, jsonser);

                File.Delete(_filepathtemp);
            }
        }

        class ToDo
        {
            //Поля класса
            public string Title { get; set; }
            public bool IsDone { get; set; }

            //Конструктор для класса
            public ToDo(string _title, bool _isdone)
            {
                Title = _title;
                IsDone = _isdone;
            }

            //Базовый конструктор для сериализации
            public ToDo()
            {

            }

            //Метод для обработки при запуске программы файловой системы и просмотра содержимого файлов
            static public void CheckUsersFile(string _filepath, string _filepathtemp)
            {
                //Если файл сессии не существует, существует файл для хранения данных между сессиями, то во временный копируется содержимое основого
                if (!File.Exists(_filepathtemp) && File.Exists(_filepath))
                {
                    File.Copy(_filepath, _filepathtemp);
                }
                //Если не существует каких-либо файлов, создается два чистых файла
                else if (!File.Exists(_filepathtemp) && !File.Exists(_filepath))
                {
                    File.Create(_filepath).Close();
                    File.Create(_filepathtemp).Close();
                }
                //Если существует оба файла, то удаляется временный, создается заново и в него копируется содержимое постоянного
                else if (File.Exists(_filepathtemp) && File.Exists(_filepath))
                {
                    File.Delete(_filepathtemp);
                    File.Copy(_filepath, _filepathtemp);
                }
            }

            //Метод для добавления задания в список заданий
            static public void AddTask(ToDo _todo, string _filepathtemp)
            {
                string str = File.ReadAllText(_filepathtemp);

                if (str != "")
                {
                    ToDo[] tasks = JsonSerializer.Deserialize<ToDo[]>(str);


                    ToDo[] tasks2 = new ToDo[tasks.Length + 1];

                    tasks2[tasks2.Length - 1] = _todo;

                    for (int i = 0; i < tasks.Length; i++)
                    {
                        tasks2[i] = tasks[i];
                    }

                    string jsonser = JsonSerializer.Serialize(tasks2);
                    File.WriteAllText(_filepathtemp, jsonser);

                }
                else
                {
                    ToDo[] tasks2 = new ToDo[1];
                    tasks2[0] = _todo;

                    string jsonser = JsonSerializer.Serialize(tasks2);
                    File.WriteAllText(_filepathtemp, jsonser);
                }
            }

            static public void FulfillTask(int _number, string _filepathtemp)
            {

                string str = File.ReadAllText(_filepathtemp);

                if (str != "")
                {
                    ToDo[] tasks = JsonSerializer.Deserialize<ToDo[]>(str);

                    if (_number > 0 && _number <= tasks.Length)
                    {
                        for (int i = 0; i < tasks.Length; i++)
                        {
                            if (i == _number)
                            {
                                tasks[i-1].IsDone = true;
                            }
                        }
                    }

                    string jsonser = JsonSerializer.Serialize(tasks);
                    File.WriteAllText(_filepathtemp, jsonser);
                }
            }
        }
    }
}
