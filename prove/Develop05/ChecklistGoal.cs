using static System.Console;
using System.IO;

public class ChecklistGoal : Goal
{
    private int _times = 0;
    private int _bonus = 0;
    private int _target = 0;
    
    public ChecklistGoal() 
    : base()
    {
        Write("How many times does this goal need to be accomplished for a bonus? ");
        _target = int.Parse(ReadLine());
        Write("What is the bonus for accomplishing that many times? ");
        _bonus = int.Parse(ReadLine());
    }

    public ChecklistGoal(string goalName, string description, int points, bool copleted, int target, int times, int bonus)
    : base(goalName, description, points)
    {

    }

    public override void GetGoalList1(int number) // Get List
    {
        string mk_X = "";
        if (base._completed)
        mk_X = "X";
        WriteLine ($"{number}. [{mk_X}] {base._goalName} ({base._description}) --- Currently completed {this._times}/{this._target}");
    }

    public override void RecordEvent() // Record Event // Incomplete
    {
        this._times++;
        if (this._times == this._target)
        {
            base._completed = true;
        }
    }

    public override string SaveGoal() 
    {
        return $"Checklist Goal:{base._goalName},{base._description},{base._points},{this._bonus},{this._times},{this._target}";
    }
}

public class SaveLoad
{
    private List<Goal> _goals = new List<Goal>();
    private int _points = 0;

    public SaveLoad()
    {
    
    }

    public void SaveGoal(List<Goal> goals, int points)
    {
        Write("What is the name of the file to save to? ");
        string fileSave = ReadLine();
        using (StreamWriter sw = new StreamWriter(fileSave, true))
        {
            sw.WriteLine(points);                    
            foreach (Goal save in goals)
            {
                sw.WriteLine($"{save.SaveGoal()}");
            } 
        }
    }

    public void LoadGoal()
    {
        Write($"What is the name of the file to load from? ");
        string fileLoad = ReadLine();
        string line;

        using (StreamReader sr = new StreamReader(fileLoad))
        {
            line = sr.ReadLine();
            _points = int.Parse(line);
            line = sr.ReadLine();

            while ((line = sr.ReadLine()) != null)
            {
                string[] goalParts = line.Split(",");
                string typeGoal = goalParts[0];

                if (typeGoal == "Simple Goal:")
                {
                    var goal = new SimpleGoal(goalParts[1], goalParts[2], int.Parse(goalParts[3]), bool.Parse(goalParts[4]));
                    _goals.Add(goal);
                }

                else if (typeGoal == "Eternal Goal:")
                {
                    var goal = new EternalGoal(goalParts[1], goalParts[2], int.Parse(goalParts[3]), bool.Parse(goalParts[4]));
                    _goals.Add(goal);
                }

                else if (typeGoal == "Checklist Goal:")
                {
                    var goal = new ChecklistGoal(goalParts[1], goalParts[2], int.Parse(goalParts[3]), bool.Parse(goalParts[4]), int.Parse(goalParts[5]), int.Parse(goalParts[6]), int.Parse(goalParts[7]));
                    _goals.Add(goal);
                }
                line = sr.ReadLine();
            }
        }
    }

    public List<Goal> GetGoal()
    {
        return _goals;
    }

    public int GetPoints()
    {
        return _points;
    }
}