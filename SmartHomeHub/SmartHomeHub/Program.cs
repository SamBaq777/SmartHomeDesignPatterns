using System;

class Program
{
    static void Main(string[] args)
    {
        // OBSERVER SETUP
        var lamp = new Lamp();
        var dashboard = new DashboardObserver();
        var logger = new LoggerObserver();

        lamp.AddObserver(dashboard);
        lamp.AddObserver(logger);

        // COMMAND + STRATEGY SETUP
        var invoker = new CommandInvoker();
        IModeStrategy normalMode = new NormalMode();

        // FACADE SETUP
        var facade = new SmartHomeFacade(lamp, invoker, normalMode);

        Console.WriteLine("\n--- FACADE TEST ---");

        // Normal mode
        facade.TurnOnLamp();
        facade.TurnOffLamp();

        // Change to Eco mode
        facade.ChangeMode(new EcoMode());
        facade.TurnOnLamp(); // Should be blocked

        // Change to Party mode
        facade.ChangeMode(new PartyMode());
        facade.TurnOnLamp(); // Should work

        Console.ReadLine();
    }
}
