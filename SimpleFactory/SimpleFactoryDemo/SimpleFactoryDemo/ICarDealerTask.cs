using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryDemo
{
    public interface ICarDealerTask
    {
        void SignContract();
        void ConfirmTransaction();
        void DeliverCar();
    }
}
