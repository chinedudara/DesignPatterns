using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalDesignPatterns.SimpleFactory
{
    public interface Door
    {
        decimal GetWidth();
        decimal GetHeight();
    }

    public class WoodenDoor : Door
    {
        private readonly decimal width;
        private readonly decimal height;

        public WoodenDoor(decimal width, decimal height)
        {
            this.width = width;
            this.height = height;
        }

        public decimal GetHeight() => height;

        public decimal GetWidth() => width;
    }

    //-------------------------------------//
    //----------- Factory Class -----------//
    //-------------------------------------//
    public class DoorFactory
    {
        public static Door MakeDoor(decimal width, decimal height)
        {
            return new WoodenDoor(width, height);
        }
    }
}
