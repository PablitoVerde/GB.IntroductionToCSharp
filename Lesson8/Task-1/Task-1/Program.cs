using System;
using System.Configuration;
using System.Threading;
using System.Globalization;
using Task_1.Properties;
using System.IO;



/*
 * Создать консольное приложение, которое при старте выводит приветствие, записанное в настройках
приложения (application-scope). 
Запросить у пользователя имя, возраст и род деятельности, 
а затем сохранить данные в настройках. 
При следующем запуске отобразить эти сведения. 
Задать приложению версию и описание
 */


namespace Task_1
{
    class Program
    {
        static void Main()
        {

            Thread.CurrentThread.CurrentCulture = new CultureInfo(CultureInfo.CurrentCulture.ToString());

            Console.WriteLine(Resources.SayHello);       

            Configuration cf = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoaming);

            var file = new ExeConfigurationFileMap { ExeConfigFilename = cf.FilePath };

            Configuration config = ConfigurationManager.OpenMappedExeConfiguration(file, ConfigurationUserLevel.None);

            if (File.Exists(cf.FilePath))
            {
                
                var userName = config.AppSettings.Settings["UserName"].Value;
                var userAge = config.AppSettings.Settings["Age"].Value;
                var userWork = config.AppSettings.Settings["Work"].Value;
                Console.WriteLine($"Привет {userName} {userAge} {userWork}!");
            }
            else
            {
                Console.WriteLine("Мы пока не знакомы. Заполните данные о себе.");

                Console.Write("Введите имя пользователя: ");
                config.AppSettings.Settings.Add("UserName", Console.ReadLine());


                Console.Write("Введите возраст пользователя: ");
                config.AppSettings.Settings.Add("Age", Console.ReadLine());

                Console.Write("Введите сферу деятельности пользователя: ");
                config.AppSettings.Settings.Add("Work", Console.ReadLine());

                config.Save();

                Console.WriteLine(cf.FilePath);
                var userName = config.AppSettings.Settings["UserName"].Value;
                var userAge = config.AppSettings.Settings["Age"].Value;
                var userWork = config.AppSettings.Settings["Work"].Value;

                Console.WriteLine($"{userName} {userAge} {userWork}");
           }

            Console.ReadKey();                  
        }
    }
}
