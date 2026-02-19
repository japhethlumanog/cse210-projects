public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string desc, int points)
        : base(name, desc, points)
    {
    }

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return GetPoints();
        }
        return 0;
    }

    public override string GetStatus()
    {
        if (_isComplete)
            return "[X] " + GetName();
        else
            return "[ ] " + GetName();
    }

    public override string GetSaveString()
    {
        return $"Simple|{GetName()}|{IsComplete()}";
    }
}
