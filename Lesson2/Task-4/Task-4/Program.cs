using System;

/* Для полного закрепления понимания простых типов найдите любой чек, либо фотографию
этого чека в интернете и схематично нарисуйте его в консоли, только за место динамических,
по вашему мнению, данных (это может быть дата, название магазина, сумма покупок)
подставляйте переменные, которые были заранее заготовлены до вывода на консоль.
*/

// За основу взят чек с АЗС Роснефти

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Постоянные данные
            string billCompanyName = "АО \"РН-Москва\"";
            string billBranchCode = "MJ 082";
            string billBranchAddress = "119270, г.Москва, Лужнецкая наб., д.10, соор. Б";
            string billBranchName = $"АЗС {billBranchCode} Лужники-2";
            string fuelTaxInfo = "НДС 20%";
            string result = "ПОДЫТОГ:";
            string finalResult = "ИТОГ";
            string payedInfo = "ПОЛУЧЕНО:";
            string payAddress = "МЕСТО РАСЧЕТОВ";
            string billDoc = "ФД: ";
            string branchCashier = "КАССИР: ";


            //Переменные данные
            string billProduct = "АИ-92-К5 Т 3:00000";
            double fuelPrice = 45.90;
            double fuelQuantity = 40;
            double fuelResult = (double)(fuelPrice * fuelQuantity);
            string fuelPriceInfo = $"{fuelQuantity} X {fuelPrice} = {fuelResult}";
            double fuelTax = fuelPrice * fuelQuantity * 20 / 120;
            string payMethod = "Банковская карта N карты: ";
            string payCardNumber = "XXXXXXXXXXXX1234";
            string payMethodDetail = "БЕЗНАЛИЧНЫМИ";
            string payMethodCard = "ПЛАТ. КАРТОЙ";
            string billNumber = "49245";
            string payDate = "27.10.21 17:17 СЗНККТ: 000025";
            string branchCashierName = "Иванов И.И.";




            int userWindowWidth = Console.WindowWidth;
            //  int userWindowHeight = Console.WindowHeight;

            //1
            Console.SetCursorPosition((userWindowWidth - billCompanyName.Length) / 2, 0);
            Console.WriteLine(billCompanyName);

            //2
            Console.SetCursorPosition((userWindowWidth - billBranchName.Length) / 2, 1);
            Console.WriteLine(billBranchName);                                                     

            //3
            Console.WriteLine(billProduct);

            //4
            Console.SetCursorPosition((userWindowWidth - fuelPriceInfo.Length), 4);
            Console.WriteLine(fuelPriceInfo);

            //5
            Console.WriteLine(fuelTaxInfo);                                                                
            Console.SetCursorPosition(userWindowWidth - fuelTax.ToString().Length, 5);
            Console.WriteLine(fuelTax);

            //6
            Console.WriteLine(billProduct);

            //7
            Console.WriteLine(payMethod + payCardNumber);

            //8
            Console.WriteLine(result);
            Console.SetCursorPosition(userWindowWidth - fuelResult.ToString().Length,8);
            Console.WriteLine(fuelResult);

            //9
            Console.WriteLine(finalResult);
            Console.SetCursorPosition(userWindowWidth - fuelResult.ToString().Length, 9);
            Console.WriteLine(fuelResult);

            //10
            Console.WriteLine(payMethodDetail);
            Console.SetCursorPosition(userWindowWidth - fuelResult.ToString().Length, 10);
            Console.WriteLine(fuelResult);

            //11
            Console.WriteLine(payedInfo);

            //12
            Console.WriteLine(payMethodCard);
            Console.SetCursorPosition(userWindowWidth - fuelResult.ToString().Length, 12);
            Console.WriteLine(fuelResult);

            //13
            Console.WriteLine(fuelTaxInfo);
            Console.SetCursorPosition(userWindowWidth - fuelTax.ToString().Length, 13);
            Console.WriteLine(fuelTax);

            //14
            Console.WriteLine(billBranchName);

            //15
            Console.WriteLine(billBranchAddress);

            //16
            Console.WriteLine(payAddress);
            Console.SetCursorPosition(userWindowWidth - billBranchCode.Length, 15);
            Console.WriteLine(billBranchCode);

            //17
            Console.WriteLine(payDate);
            Console.SetCursorPosition(userWindowWidth - (billDoc + billNumber).Length, 17);
            Console.WriteLine(billDoc + billNumber);

            //18
            Console.WriteLine(branchCashier + branchCashierName);

            Console.ReadKey();
        }
    }
}
