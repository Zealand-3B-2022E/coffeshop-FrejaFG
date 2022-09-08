using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public class BlackCoffee : Coffee
    {
        public BlackCoffee()
            :base()
        {

        }

        public BlackCoffee(int discount)
            :base(discount)
        {

        }

        public override string Strength()
        {
            return "Strong";
        }

        public override string TypeOfCoffee()
        {
            return "Black Coffee";
        }
    }
}
