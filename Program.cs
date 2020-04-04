using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Users.ConsolePL
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите одно из следующих действий:" + Environment.NewLine + "1 - Добавить пользователя" + Environment.NewLine + "2 - Просмотреть список пользователей" + Environment.NewLine +
                   "3 - Удалить пользователя");
            var action = Console.ReadLine();
            switch (action)
            {
                case "1":
                    MyLogic.Add();
                    break;
                case "2":
                    MyLogic.GetUsers();
                    break;
                case "3":
                    Console.WriteLine("Укажите ID пользователя:");
                    try
                    {
                        if (int.TryParse(Console.ReadLine(), out var index)) {
                            MyLogic.Remove(index);
                        } else
                        {
                            throw new Exception("No correctly format of index");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Некорректный индекс!");
                    }

                    break;
            }
            Console.ReadLine();
        }
    }
}
