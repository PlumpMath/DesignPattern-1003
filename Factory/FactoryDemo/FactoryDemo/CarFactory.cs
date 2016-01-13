using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDemo
{
    class CarFactory
    {
        static public ICarDealerTask CreateCarDeal(string car_name)
        {
            ICarDealerTask carObj = null;

            switch (car_name)
            {
                case "Ford":
                    carObj = new Ford();
                    break;

                case "Toyota":
                    carObj = new Toyota();
                    break;

                case "Nissan":
                    carObj = new Nissan();
                    break;
                
                default:
                    carObj = new Ford();
                    break;
            }

            return carObj;
        }
    }
}
