using System;
using SinxPaterm4.AbstarckFactory;
using System.Collections.Generic;
using SinxPaterm4.AbstarckFactory.Employe;
namespace SinxPaterm4
{
    //по факту это класс клиент пользователь фабрирк
    class Program
    {
        //поля для контретных фабрик
        static private HrFactory hrfactory =new HrFactory();
        static private InternacionalFactory internacionalFactory = new InternacionalFactory();
        static private PlaningFactory planingFactory = new PlaningFactory();
        static private LearningFactory learningFactory = new LearningFactory(); 
        //коллкции для  созданных сотрудников
        static private List<AbstarctIntern> InternCollection = new List<AbstarctIntern>();
        static private List<AbstarctEmploy> EmployeCollection = new List<AbstarctEmploy>();
        static private List<AbstarctVice> VicesCollection = new List<AbstarctVice>();
        static private List<AbstractBoss> BossCollection = new List<AbstractBoss>();
        static void Main(string[] args)
        {
            Console.WriteLine("введите 1-для создание сотрудника 2-для перехода в меню фильрации по отделам 3- для выхода из программы");

            while (true) 
            {
                int input = int.Parse(Console.ReadLine());
                if (input == 1) 
                {
                    CreateSpecificEmploye();
                }

                if (input == 2) 
                {
                    SelectByDeportament();
                }

                if (input == 3) 
                {
                    break;
                }
            }

        }

        #region Методы для гибкого создания обьектов с помощью фабрик
        public static void CreateIntern(AbstarctFactory factory) 
        {
            InternCollection.Add(factory.CreateIntern());
        }

        public static void CreateEmploye(AbstarctFactory factory) 
        {
            EmployeCollection.Add(factory.CreateEmploye());
        }

        public static void CreateVice(AbstarctFactory factory) 
        {
            VicesCollection.Add(factory.CreateVice());
        }

        public static void CreateBoss(AbstarctFactory factory) 
        {
            BossCollection.Add(factory.CreateBoss());
        }
        #endregion

        public static void CreateSpecificEmploye() 
        {
            Console.WriteLine("1- отдел кадров 2- отдел планирования 3- отдел обучения 4- межнациональный отдел");
            int input = int.Parse(Console.ReadLine());
            
            if (input == 1) 
            {
                Console.WriteLine("1- стажер 2- работник 3-зам начальника 4 - начальник");
                int input1 = int.Parse(Console.ReadLine());
                if (input1 == 1) 
                {
                    CreateIntern(hrfactory);
                }
                if (input1 == 2)
                {
                    CreateEmploye(hrfactory);
                }
                if (input1 == 3)
                {
                    CreateVice(hrfactory);
                }
                if (input1 == 4)
                {
                    CreateBoss(hrfactory);
                }

            }

            if (input == 2)
            {
                Console.WriteLine("1- стажер 2- работник 3-зам начальника 4 - начальник");
                int input2 = int.Parse(Console.ReadLine());
                if (input2 == 1)
                {
                    CreateIntern(planingFactory);
                }
                if (input2 == 2)
                {
                    CreateEmploye(planingFactory);
                }
                if (input2 == 3)
                {
                    CreateVice(planingFactory);
                }
                if (input2 == 4)
                {
                    CreateBoss(planingFactory);
                }
            }

            if (input == 3)
            {
                Console.WriteLine("1- стажер 2- работник 3-зам начальника 4 - начальник");
                int input3 = int.Parse(Console.ReadLine());
                if (input3 == 1)
                {
                    CreateIntern(learningFactory);
                }
                if (input3 == 2)
                {
                    CreateEmploye(learningFactory);
                }
                if (input3 == 3)
                {
                    CreateVice(learningFactory);
                }
                if (input3 == 4)
                {
                    CreateBoss(learningFactory);
                }
            }

            if (input == 4)
            {
                Console.WriteLine("1- стажер 2- работник 3-зам начальника 4 - начальник");
                int input4 = int.Parse(Console.ReadLine());
                if (input4 == 1)
                {
                    CreateIntern(internacionalFactory);
                }
                if (input4 == 2)
                {
                    CreateEmploye(internacionalFactory);
                }
                if (input4 == 3)
                {
                    CreateVice(internacionalFactory);
                }
                if (input4 == 4)
                {
                    CreateBoss(internacionalFactory);
                }
            }

        }

        public static void SelectByDeportament() 
        {
            Console.WriteLine("Фильтрация по отделам: 1- отдел кадров 2- отдел планирования 3- отдел обучения 4- межнациональный отдел");
            int input = int.Parse(Console.ReadLine());
            if (input == 1) 
            {
                for (int i = 0; i < InternCollection.Count; i++) 
                {
                    if (InternCollection[i] is HrIntern) { Console.WriteLine(InternCollection[i].FIO); }
                }

                for (int i = 0; i < EmployeCollection.Count; i++)
                {
                    if (EmployeCollection[i] is HrEmploye) { Console.WriteLine(EmployeCollection[i].FIO); }
                }

                for (int i = 0; i < VicesCollection.Count; i++)
                {
                    if (VicesCollection[i] is HrVice) { Console.WriteLine(VicesCollection[i].FIO); }
                }

                for (int i = 0; i < BossCollection.Count; i++)
                {
                    if (BossCollection[i] is HrBoss) { Console.WriteLine(BossCollection[i].FIO); }
                }
            }

            if (input == 2)
            {
                for (int i = 0; i < InternCollection.Count; i++)
                {
                    if (InternCollection[i] is PlaningIntern) { Console.WriteLine(InternCollection[i].FIO); }
                }

                for (int i = 0; i < EmployeCollection.Count; i++)
                {
                    if (EmployeCollection[i] is PlaningEmploye) { Console.WriteLine(EmployeCollection[i].FIO); }
                }

                for (int i = 0; i < VicesCollection.Count; i++)
                {
                    if (VicesCollection[i] is PlaningVice) { Console.WriteLine(VicesCollection[i].FIO); }
                }

                for (int i = 0; i < BossCollection.Count; i++)
                {
                    if (BossCollection[i] is PlaningBoss) { Console.WriteLine(BossCollection[i].FIO); }
                }
            }

            if (input == 3)
            {
                for (int i = 0; i < InternCollection.Count; i++)
                {
                    if (InternCollection[i] is LearnIntern) { Console.WriteLine(InternCollection[i].FIO); }
                }

                for (int i = 0; i < EmployeCollection.Count; i++)
                {
                    if (EmployeCollection[i] is LearnEmploye) { Console.WriteLine(EmployeCollection[i].FIO); }
                }

                for (int i = 0; i < VicesCollection.Count; i++)
                {
                    if (VicesCollection[i] is LearnVice) { Console.WriteLine(VicesCollection[i].FIO); }
                }

                for (int i = 0; i < BossCollection.Count; i++)
                {
                    if (BossCollection[i] is LearnBoss) { Console.WriteLine(BossCollection[i].FIO); }
                }
            }

            if (input == 4)
            {
                for (int i = 0; i < InternCollection.Count; i++)
                {
                    if (InternCollection[i] is InternacionalIntern) { Console.WriteLine(InternCollection[i].FIO); }
                }

                for (int i = 0; i < EmployeCollection.Count; i++)
                {
                    if (EmployeCollection[i] is InternacionalEmploye) { Console.WriteLine(EmployeCollection[i].FIO); }
                }

                for (int i = 0; i < VicesCollection.Count; i++)
                {
                    if (VicesCollection[i] is InternacionalVice) { Console.WriteLine(VicesCollection[i].FIO); }
                }

                for (int i = 0; i < BossCollection.Count; i++)
                {
                    if (BossCollection[i] is InternacionalBoss) { Console.WriteLine(BossCollection[i].FIO); }
                }
            }

        }
    }
}
