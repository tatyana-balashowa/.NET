﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Users.BLL;
using Users.Entities;

namespace Users.ConsolePL
{
    class MyLogic
    {
        private static IUserLogic userLogic = new UserLogic();
        public static void Add ()
        {
            Console.WriteLine("Имя пользователя:");
            string name = Console.ReadLine();
            Console.WriteLine("Дата рождения:");
            try
            {
                if (DateTime.TryParse(Console.ReadLine(), out var dateOfBirth))
                {
                    Console.WriteLine("Возраст:");
                    if (int.TryParse(Console.ReadLine(), out var age))
                    {
                        var newUser = new User()
                        {
                            Name = name,
                            DateOfBirth = dateOfBirth,
                            Age = age
                        };
                        userLogic.Add(newUser);
                        Console.WriteLine("Пользователь добавлен!");
                    }
                    else
                    {
                        throw new Exception("No correctly format of User's age");
                    }
                } else
                {
                    throw new Exception("No coкrectly format of User's dateOfBirth");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Некорректные данные пользователя!");
            }
        }
        public static void GetUsers()
        {
            try
            {
                var result = userLogic.GetUsers();
                if (result.Any())
                {
                    foreach (var item in result)
                    {
                        Console.WriteLine(item.ToString());
                    }
                } else
                {
                    throw new Exception("Empty!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Нет пользователей!");
            }
        }
        public static void Remove (int index)
        {
            try
            {
                if (userLogic.GetUsers().Any())
                {
                    if (index >= 0 && index < userLogic.GetUsers().Count())
                    {
                        userLogic.Remove(index);
                        Console.WriteLine("Пользователь удален!");
                    } else
                    {
                        throw new Exception("No correctly index");
                    }
                } else
                {
                    throw new Exception("Empty!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Пожалуйста , убедитесь в наличии пользователей и  правильности введенного индекса !");
            }
        }
    }
}
