using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public abstract class Coffee
    {

        // Returns the price of the coffe.
        //The method is virtual hence csn be overridden. 
        public virtual int price()
        {
            return 20 - Discount;
        }

        // Vi sætter en deafault contructor med Discount=0
        public Coffee()
            :this(0)
        { }

        public Coffee (int discount)
        {
            if (discount > 5)
                throw new ArgumentException("5kr is top discount");

            if (discount < 0)
                throw new ArgumentException("Discount cannot be less than 1 kr. ");

            this.Discount = discount;
        }

        protected int Discount { get; private set; }

        public abstract string Strength();

        public abstract string TypeOfCoffee();

        public override string ToString()
        {
            return $"This is a {this.TypeOfCoffee()}, I cost {this.price()} and i am {this.Strength()}";
        }
    }
}
