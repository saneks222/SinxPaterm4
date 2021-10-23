using System;
using System.Collections.Generic;
using System.Text;
namespace SinxPaterm4.AbstarckFactory
{
   abstract class AbstarctIntern
    {
       public string FIO;
        int YearOfBirth;
        float Wage;

        public AbstarctIntern() 
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
