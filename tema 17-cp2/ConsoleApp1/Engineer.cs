using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Engineer : Employee // Потомок Инженер
    {

        /// <summary>
        /// количество разработанных проектов
        /// </summary>
        public int n;

        public int N { get { return n; } set { n = value; } }


        public Engineer(string surname, string name, double p, double k, int n) : base(surname, name, p, k)
        {
           this.n = n;
        }


        /// <summary>
        /// для инженера (потомка) доход будет рассчитываться иначе, чем для обычного сотрудника (базового класса).
        /// </summary>
        /// <returns></returns>
        public override double Income()
        {
            if (n > 10)
            {
                return k * p * (n / 10);
            }
            else
            {
                return base.Income();
            }
        }


        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Фамилия: {surname}");
            Console.WriteLine($"Имя: {name}");
            Console.WriteLine($"Минимальная зарплата: {p}");
            Console.WriteLine($"Повышающий коэффициент: {k}");
        }


        public override ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Количество разработанных проектов: {n}");
        }






    }
}
