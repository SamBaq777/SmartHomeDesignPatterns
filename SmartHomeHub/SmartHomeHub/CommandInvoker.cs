using System;
using System.Collections.Generic;

public class CommandInvoker
{
    private Queue<ICommand> _queue = new Queue<ICommand>();
    private List<ICommand> _history = new List<ICommand>();

    public void AddCommand(ICommand command)
    {
        _queue.Enqueue(command);
    }

    public void Run()
    {
        while (_queue.Count > 0)
        {
            var cmd = _queue.Dequeue();
            cmd.Execute();
            _history.Add(cmd);
        }
    }

    public void ReplayLastFive()
    {
        Console.WriteLine("Replaying last 5 commands...");

        int start = Math.Max(0, _history.Count - 5);

        for (int i = start; i < _history.Count; i++)
        {
            _history[i].Execute();
        }
    }
}
