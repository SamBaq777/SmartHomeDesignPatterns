using System;

public class DashboardObserver : IObserver
{
    public void Update(string message)
    {
        Console.WriteLine("[Dashboard] " + message);
    }
}
