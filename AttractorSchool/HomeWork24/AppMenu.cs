using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork24
{
    internal static  class AppMenu
    {
        public static void Start()
        {
            int option = 0;
            Console.WriteLine("Меню:\n 1. Отобразить текущее состояние грузовиков\n 2. Показать данные грузовика по id\nВыберите действие:");
            string input = Console.ReadLine();

            while (!int.TryParse(input, out option) && option < 3)
            {
                Console.WriteLine("Неизвестная опция. Введите 1 или 2");
                input = Console.ReadLine();
            }

            if (option == 1)
            {
                //Считать грузовики из файла и отобразить в консоли
                Console.WriteLine("Список грузовиков:");
            }

            if (option == 2)
            {
                //Убедиться что введный Id существует и вернуть детали грузовика или ошибку
                Console.WriteLine("Введите Id грузовика:");
            }
        }
    }
}