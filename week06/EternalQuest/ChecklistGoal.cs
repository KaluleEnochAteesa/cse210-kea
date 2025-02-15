public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus, int amountCompleted = 0)
        : base(name, description, points)
    {
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        _amountCompleted++;
        int pointsAwarded = _points;

        if (IsComplete())
        {
            pointsAwarded += _bonus;
            Console.WriteLine($"Congratulations! You earned a bonus of {_bonus} points for completing the goal.");
        }
        else
        {
            Console.WriteLine($"Goal recorded. You have completed this goal {_amountCompleted} out of {_target} times.");
        }

        return pointsAwarded;
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {base.GetDetailsString()} - {_amountCompleted}/{_target} completed";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{_shortName}|{_description}|{_points}|{_amountCompleted}|{_target}|{_bonus}";
    }
}
