using static System.Console;
using System.IO;

public class SimpleGoal : Goal
{
    public SimpleGoal() 
    : base()
    {
    }

    public SimpleGoal(string goalName, string description, int points, bool complete)
    : base(goalName, description, points, complete)
    {
    }

    public override void RecordEvent()
    {
        base._completed = true;
    }

    public override void GetGoalList1(int number)
    {
        string mk_X = "";
        if (base._completed)
        mk_X = "X";
        WriteLine($"{number}. [{mk_X}] {base._goalName} ({base._description})");
    }

    public override string SaveGoal() 
    {
        return $"Simple Goal:{base._goalName},{base._description},{base._points},{base.IsComplete()}";
    }
}

public class EternalGoal : Goal
{
    public EternalGoal() 
    : base()
    {
        base._completed = false;
    }
    
    public EternalGoal(string goalName, string description, int points, bool completed)
    : base(goalName, description, points)
    {
    }
    public override void RecordEvent()
    {
    }

    public override string SaveGoal() 
    {
        return $"Eternal Goal:{base._goalName},{base._description},{base._points}";
    }
}