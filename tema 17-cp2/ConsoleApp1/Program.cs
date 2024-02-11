using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Информация о сотруднике:");
            Employee employee = new Employee("Иванов", "Иван", 1000, 1.5);
            employee.ShowInfo();
            Console.WriteLine($"Доход: {employee.Income()}");

            Console.WriteLine("\nИнформация об инженере:");
            Engineer engineer = new Engineer("Петров", "Петр", 1500, 2.0, 15);
            engineer.ShowInfo();
            Console.WriteLine($"Доход: {engineer.Income()}");

            Console.WriteLine("\nИнформация об автобусе:");
            Bus bus = new Bus("Mercedes", 50, 20);
            bus.ShowInfo();
            Console.WriteLine($"Общая стоимость всех мест: {bus.TotalCost()}");

            Console.WriteLine("\nИнформация о туристическом автобусе:");
            TouristBus touristBus = new TouristBus("MAN", 40, 25, 10);
            touristBus.ShowInfo();
            Console.WriteLine($"Общая стоимость всех мест с учетом экскурсии: {touristBus.TotalCost()}");



            Console.ReadKey();
        }
    }
}
