using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int gold;
            int crystal;
            int price = 20;
            Console.WriteLine($"Приветствую тебя путник! рад видеть в наших землях! У меня есть для тебя весьма редкие кристаллы!" +
                $" Для тебя цена составит {price} золотых монет! Сколько у тебя монет?");
            gold = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Отлично! Сколько кристалов ты хочешь?");
            crystal = Convert.ToInt32(Console.ReadLine());
            gold -= crystal * price;
            Console.WriteLine($"Великолепно! После сделки у тебя останется {gold} монет и {crystal} кристаллов!");
        }
    }
}
