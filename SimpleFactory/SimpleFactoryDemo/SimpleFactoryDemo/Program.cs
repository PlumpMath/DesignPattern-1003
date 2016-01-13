using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CarStore store = new CarStore(new SimpleCarFactory());
            Console.WriteLine("A 客人訂購Ford");
            store.CarOrders("Ford");
            Console.WriteLine("Deal !");

            Console.ReadLine();
        }        
    }

    public class SimpleCarFactory
    {
        public ICarDealerTask CreateCarDeal(string car_name)
        {
            ICarDealerTask car;

            if (car_name == "Ford")
            {
                car = new Ford();
                return car;
            }

            if (car_name == "Toyota")
            {
                car = new Toyota();
                return car;
            }
            else
            {
                return null;
            }
        }
    }

    public class CarStore
    {
        private SimpleCarFactory _factory;

        public CarStore(SimpleCarFactory pFactory)
        {
            _factory = pFactory;
        }

        public ICarDealerTask CarOrders(string car_name)
        {
            ICarDealerTask carDeal;

            carDeal = _factory.CreateCarDeal(car_name);
            carDeal.SignContract();
            carDeal.ConfirmTransaction();
            carDeal.DeliverCar();

            return carDeal;
        }
    }

    public class Ford : ICarDealerTask
    {
        public void SignContract() { }
        public void ConfirmTransaction() { }
        public void DeliverCar() { }

    }

    public class Toyota : ICarDealerTask
    {
        public void SignContract() { }
        public void ConfirmTransaction() { }
        public void DeliverCar() { }
    }
}
