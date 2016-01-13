using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ICarDealerTask task = null;

            Console.WriteLine("Enter car name:");
            string car_name = Console.ReadLine().ToString();
            task = CarFactory.CreateCarDeal(car_name);

            task.SignContract();
            task.ConfirmTransaction();
            task.DeliverCar();

            Console.WriteLine(car_name + " is sold.");

            Console.ReadLine();
        }
    }
}
