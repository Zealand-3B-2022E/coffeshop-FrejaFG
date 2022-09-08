using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    internal class Cortado : Coffee, IMilk
    {
        public Cortado()
            :base()
        { }

        public Cortado(int discount)
            :base(discount)
        { }

        public int MlMilk()
        {
            return 40;
        }

        public override int price()
        {
            return 25 - base.Discount;
        }

        public override string Strength()
        {
            return "Medium";
        }

        public override string TypeOfCoffee()
        {
            return "Cortado";
        }
    }
}
