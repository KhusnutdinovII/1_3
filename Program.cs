using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random(); //Подключаем ГСЧ
            int[] mas = new int[15]; //Создаем массив на 15 элементов
            int min = 100, index = 0; //Переменные для хранения минимального значения и его индекса

            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rnd.Next(100); //Заполняем массив случайными числами от 0 до 100
                Console.Write("{0}  ", mas[i]); //Выводим их на экран
                if (mas[i] < min) //Если текущее значение меньше минимального
                {
                    min = mas[i]; //то переопределяем минимальное
                    index = i; //и его индекс
                }
            }

            Console.Write("\nМинимальное значение: {0}; Индекс: {1}", min, index + 1);
            Console.ReadKey();
        }
    }
}