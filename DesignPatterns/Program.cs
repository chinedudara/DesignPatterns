// See https://aka.ms/new-console-template for more information
using DesignPatterns.CreationalDesignPatterns.AbstractFactory;
using DesignPatterns.CreationalDesignPatterns.FactoryMethod;
using DoorFactory = DesignPatterns.CreationalDesignPatterns.SimpleFactory.DoorFactory;

Console.WriteLine("Creational Design Patterns");
Console.WriteLine("----------------------------------");
Console.WriteLine(Environment.NewLine);

#region Simple Factory
{
    Console.WriteLine("Simple Factory");
    var door = DoorFactory.MakeDoor(20, 10);
    Console.WriteLine($"Width: {door.GetHeight()}");
    Console.WriteLine($"Height: {door.GetWidth()}");
    Console.WriteLine(Environment.NewLine);
}
#endregion

#region Factory Method
{
    Console.WriteLine("Factory Method");
    var marketingManager = new MarketingManager();
    marketingManager.TakeInterview();
    var devManager = new DevelopmentManager();
    devManager.TakeInterview();
    Console.WriteLine(Environment.NewLine);
}

#endregion

#region Abstract Factory
{
    Console.WriteLine("Abstract Factory");
    var woodenDoorFactory = new WoodenDoorFactory();
    var door = woodenDoorFactory.MakeDoor();
    var fitter = woodenDoorFactory.MakeFittingExpert();
    door.GetDescription();
    fitter.GetDescription();

    var ironDoorFactory = new IronDoorFactory();
    door = ironDoorFactory.MakeDoor();
    fitter = ironDoorFactory.MakeFittingExpert();
    door.GetDescription();
    fitter.GetDescription();
    Console.WriteLine(Environment.NewLine);
}

#endregion

