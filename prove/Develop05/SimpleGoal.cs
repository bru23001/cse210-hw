/*
BEHAVIORS:			
    1) RecordEvent() : void (Override)
    2) IsComplete() : bool (Override)
    3) GetStringRepresentation() : string (Override)

ATTRIBUTES:
	1) _isComplete : bool

CONSTRUCTORS:
    SimpleGoal(name : string, description : string, points : int) - This should also set the the variables
    for if it is complete to be false.



*/

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal: {_shortName}, {_description}, {_points}, {_isComplete}";
    }
}
