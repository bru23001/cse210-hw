/*
BEHAVIORS:
    1) RecordEvent() : void (Override)
    2) IsComplete() : bool (Override)
    3) GetDetailsString() : string (Override)
    4) GetStringRepresentation() : string (Override)
ATTRIBUTES:
    1) _amountCompleted : int
    2) _target : int
    3) _bonus : int
CONSTRUCTORS:
    CheckListGoal(name : string, description : string, points : int, target : int, bonus : int) 
    - In addition to the standard attributes, a checklist goal also needs the target and the 
    bonus amounts. Then, it should set the amount completed to begin at 0.



*/

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        return base.GetDetailsString() + $" Completed {_amountCompleted}/{_target} times";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal: {_shortName}, {_description}, {_points}, {_amountCompleted}, {_target}, {_bonus}";
    }
}
