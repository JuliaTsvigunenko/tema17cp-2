using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class TouristBus : Bus // Потомок Туристический автобус
    {

        /// <summary>
        ///  стоимость экскурсии
        /// </summary>
        public double excursionCost;

        public double ExcursionCost { get { return excursionCost; } set { excursionCost = value; } }


        public TouristBus(string brand, int seats, double ticketCost, double excursionCost): base(brand, seats, ticketCost)
        {
            this.excursionCost = excursionCost;
        }


        public override double TotalCost()
        {
            return base.TotalCost() + seats * excursionCost;
        }


        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Стоимость экскурсии: {ExcursionCost}");
        }










    }
}
