using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Employee // Базовый класс Сотрудник
    {

        /// <summary>
        /// фамилия
        /// </summary>
        public string surname;

        public string name;

        /// <summary>
        ///  минимальная зарплата
        /// </summary>
        public double p;

        /// <summary>
        /// повышающий коэффициент
        /// </summary>
        public double k;


      
        public string Surname { get { return surname; } set { surname = value; } }
        public string Name { get { return name; } set { name = value; } }
        public double P { get { return p; } set { p = value; } }
        public double K { get { return k; } set { k = value; } }


        public Employee(string surname, string name, double p, double k)
        {

            this.surname = name;
            this.name = name;
            this.p = p;
            this.k = k;
        }


        /// <summary>
        ///   метод Income() возвращает доход сотрудника, 
        ///   который рассчитывается как произведение базовой зарплаты на повышающий коэффициент
        ///   
        /// Поскольку этот метод является виртуальным, его можно переопределить в производных классах, чтобы изменить его поведение. 
        /// Например, в потомке Engineer, как указано в задаче, этот метод переопределен таким образом, 
        /// что доход инженера увеличивается в зависимости от количества разработанных проектов.
        /// </summary>
        /// <returns></returns>
        public virtual double Income()
        {
            return p * k;
        }



        public virtual void ShowInfo()
        {
            Console.WriteLine($"Фамилия: {surname}");
            Console.WriteLine($"Имя: {name}");
            Console.WriteLine($"Минимальная зарплата: {p}");
            Console.WriteLine($"Повышающий коэффициент: {k}");
        }








    }
}
