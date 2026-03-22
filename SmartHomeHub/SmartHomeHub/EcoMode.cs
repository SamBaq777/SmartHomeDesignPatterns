public class EcoMode : IModeStrategy
{
    public bool CanTurnOnLamp()
    {
        return false; // Eco mode blockerar lampan för att spara energi
    }
}
