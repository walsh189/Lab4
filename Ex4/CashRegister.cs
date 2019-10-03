using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    class CashRegister
    {
        public int NumberOfItems { get; private set; }
        public double Total { get; private set; }

        public void AddItem(double itemPrice)
        {
            Total += itemPrice;
            NumberOfItems++;
        }
    }
}
