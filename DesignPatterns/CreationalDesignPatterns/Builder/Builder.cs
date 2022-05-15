using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalDesignPatterns.Builder
{
    public class Burger
    {
        //Fields should be made Protected
        public int size;
        public bool pepperonni = false;
        public bool cheese = false;
        public bool lettuce = false;
        public bool tomato = false;

        public Burger(BurgerBuilder builder)
        {
            size = builder.size;
            pepperonni = builder.pepperonni;
            cheese = builder.cheese;
            lettuce = builder.lettuce;
            tomato = builder.tomato;
        }
    }

    public class BurgerBuilder
    {
        public int size;
        public bool pepperonni = false;
        public bool cheese = false;
        public bool lettuce = false;
        public bool tomato = false;

        public BurgerBuilder(int size)
        {
            this.size = size;
        }

        public BurgerBuilder AddPepperonni()
        {
            pepperonni = true;
            return this;
        }

        public BurgerBuilder AddCheese()
        {
            cheese = true;
            return this;
        }

        public BurgerBuilder AddLettuce()
        {
            lettuce = true;
            return this;
        }

        public BurgerBuilder AddTomato()
        {
            tomato = true;
            return this;
        }

        public Burger Build() => new Burger(this);
    }
}