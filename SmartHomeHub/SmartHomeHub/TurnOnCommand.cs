public class TurnOnCommand : ICommand
{
    private Lamp _lamp;
    private IModeStrategy _mode;

    public TurnOnCommand(Lamp lamp, IModeStrategy mode)
    {
        _lamp = lamp;
        _mode = mode;
    }

    public void Execute()
    {
        if (_mode.CanTurnOnLamp())
        {
            _lamp.TurnOn();
        }
        else
        {
            Console.WriteLine("Mode blocked turning on the lamp.");
        }
    }
}
