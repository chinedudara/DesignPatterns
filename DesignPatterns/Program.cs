// See https://aka.ms/new-console-template for more information
using DesignPatterns.CreationalDesignPatterns.FactoryMethod;
using DesignPatterns.CreationalDesignPatterns.SimpleFactory;

Console.WriteLine("Creational Design Patterns");
Console.WriteLine("----------------------------------");
Console.WriteLine(Environment.NewLine);


Console.WriteLine("Simple Factory");
var door = DoorFactory.MakeDoor(20, 10);
Console.WriteLine($"Width: {door.GetHeight()}");
Console.WriteLine($"Height: {door.GetWidth()}");
Console.WriteLine(Environment.NewLine);

Console.WriteLine("Factory Method");
var interviewer = new MarketingManager();
interviewer.TakeInterview();
var interviewer2 = new DevelopmentManager();
interviewer2.TakeInterview();
