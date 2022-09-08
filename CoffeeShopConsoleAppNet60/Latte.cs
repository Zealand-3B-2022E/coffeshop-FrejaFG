using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public class Latte : Coffee, IMilk
    {
        public Latte()
            :base()
        { }

        public Latte(int discount)
            :base(discount)
        { }

        public override string TypeOfCoffee()
        {
            return "Latte";
        }

        public override int price()
        {
            return 40 - base.Discount;
        }

        public override string Strength()
        {
            return "mild";
        }

        public int MlMilk()
        {
            return 200;
        }
    }
}
