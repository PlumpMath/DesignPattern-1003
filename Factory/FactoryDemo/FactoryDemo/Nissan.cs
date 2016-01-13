using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDemo
{
    class Nissan : ICarDealerTask
    {
        public void SignContract()
        {
            Console.WriteLine("簽約");
        }

        public void ConfirmTransaction()
        {
            Console.WriteLine("確認匯款");
        }

        public void DeliverCar()
        {
            Console.WriteLine("交車");
        }
    }
}
