using System;

public class SmartHomeFacade
{
    private Lamp _lamp;
    private CommandInvoker _invoker;
    private IModeStrategy _mode;

    public SmartHomeFacade(Lamp lamp, CommandInvoker invoker, IModeStrategy mode)
    {
        _lamp = lamp;
        _invoker = invoker;
        _mode = mode;
    }

    public void TurnOnLamp()
    {
        Console.WriteLine("Facade: Turning on lamp...");
        var cmd = new TurnOnCommand(_lamp, _mode);
        _invoker.AddCommand(cmd);
        _invoker.Run();
    }

    public void TurnOffLamp()
    {
        Console.WriteLine("Facade: Turning off lamp...");
        var cmd = new TurnOffCommand(_lamp);
        _invoker.AddCommand(cmd);
        _invoker.Run();
    }

    public void ChangeMode(IModeStrategy newMode)
    {
        Console.WriteLine("Facade: Changing mode...");
        _mode = newMode;
    }
}
