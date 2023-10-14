/*
METHODS:
1. RecordEvent - This method should do whatever is necessary for each specific kind of goal, such as 
    marking a simple goal complete and adding to the number of times a checklist goal has been completed. 
    It should return the point value associated with recording the event (keep in mind that it may contain 
    a bonus in some cases if a checklist goal was just finished, for example).
2. IsComplete - This method should return true if the goal is completed. The way you determine if a goal
    is complete is different for each type of goal.
3. GetStringRepresentation - This method should provide all of the details of a goal in a way that is 
        easy to save to a file, and then load later.

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
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {

    }
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
        
        
        return $"{base.GetDetailsString()} - Completed";}
}
