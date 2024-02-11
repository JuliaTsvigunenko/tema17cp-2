using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Bus // Базовый класс Автобус
    {

        /// <summary>
        /// марка
        /// </summary>
        public string brand;

        /// <summary>
        ///  количество мест
        /// </summary>
        public int seats;

        /// <summary>
        /// стоимость билета
        /// </summary>
        public double ticketCost;

        public string Brand { get { return brand; } set { brand = value; } }
        public int Seats { get { return seats; } set { seats = value; } }
        public double TicketCost { get { return ticketCost; } set { ticketCost = value; }}


        public Bus(string brand, int seats, double ticketCost)
        {
            this.brand = brand;
            this.seats = seats;
            this.ticketCost = ticketCost;
        }


        public virtual void ShowInfo()
        {
            Console.WriteLine($"Марка автобуса: {brand}");
            Console.WriteLine($"Количество мест: {seats}");
            Console.WriteLine($"Стоимость билета: {ticketCost}");
        }






    }
}
