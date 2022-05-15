using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalDesignPatterns.AbstractFactory
{
    #region Door
    public interface Door
    {
        void GetDescription();
    }

    public class WoodenDoor : Door
    {
        public void GetDescription()
        {
            Console.WriteLine("I am a wooden door");
        }
    }

    public class IronDoor : Door
    {
        public void GetDescription()
        {
            Console.WriteLine("I am an iron door");
        }
    }
    #endregion

    #region FittingExpert
    public interface DoorFittingExpert
    {
        void GetDescription();
    }

    public class Carpenter : DoorFittingExpert
    {
        public void GetDescription()
        {
            Console.WriteLine("I fit wooden doors only");
        }
    }

    public class Welder : DoorFittingExpert
    {
        public void GetDescription()
        {
            Console.WriteLine("I fit iron doors only");
        }
    }
    #endregion


    //-------------------------------------//
    //----------- Factory Class -----------//
    //-------------------------------------//
    public interface DoorFactory
    {
        Door MakeDoor();
        DoorFittingExpert MakeFittingExpert();
    }

    public class WoodenDoorFactory : DoorFactory
    {
        public Door MakeDoor() => new WoodenDoor();

        public DoorFittingExpert MakeFittingExpert() => new Carpenter();
    }

    public class IronDoorFactory : DoorFactory
    {
        public Door MakeDoor() => new IronDoor();

        public DoorFittingExpert MakeFittingExpert() => new Welder();
    }
}
