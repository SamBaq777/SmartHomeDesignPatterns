using System;
using System.Collections.Generic;

public class Lamp : ISubject
{
    private List<IObserver> observers = new List<IObserver>();
    public bool IsOn { get; private set; }

    public void TurnOn()
    {
        IsOn = true;
        NotifyObservers("Lamp is now ON");
    }

    public void TurnOff()
    {
        IsOn = false;
        NotifyObservers("Lamp is now OFF");
    }

    public void AddObserver(IObserver observer)
    {
        observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void NotifyObservers(string message)
    {
        foreach (var obs in observers)
        {
            obs.Update(message);
        }
    }
}
