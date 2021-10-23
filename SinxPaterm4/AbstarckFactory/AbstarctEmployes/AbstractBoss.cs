using System;
using System.Collections.Generic;
using System.Text;

namespace SinxPaterm4.AbstarckFactory
{
    abstract class AbstractBoss
    {
       public string FIO;
        int YearOfBirth;
        float Wage;

        public AbstractBoss()
        {
            Console.WriteLine("Введите фио в одеу строку через пробел");
            FIO = Console.ReadLine();

            Console.WriteLine("Введите год(только год) рождения ");
            YearOfBirth = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите Зароботную плату в рублях в одну строку");

            Wage = int.Parse(Console.ReadLine());
            Console.WriteLine("Сотрудник успешно создан");
        }
    }
}
