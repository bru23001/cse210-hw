/*
BEHAVIORS:
    1) RecordEvent() : void (Override)
    2) IsComplete() : bool (Override)
    3) GetStringRepresentation() : string (Override)

ATTRIBUTES:
	1) None needed

CONSTRUCTORS:
    EternalGoal(name : string, description : string, points : int)


*/

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points) {}

    public override void RecordEvent()
    {
        // For an eternal goal, recording an event doesn't change its completion status.
    }

    public override bool IsComplete()
    {
        // An eternal goal is never complete.
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal: {_shortName}, {_description}, {_points}";
    }
}
