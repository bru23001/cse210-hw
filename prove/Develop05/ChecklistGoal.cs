/*
METHODS:
1. RecordEvent - This method should do whatever is necessary for each specific kind of goal, such as 
    marking a simple goal complete and adding to the number of times a checklist goal has been completed. 
    It should return the point value associated with recording the event (keep in mind that it may contain 
    a bonus in some cases if a checklist goal was just finished, for example).
2. IsComplete - This method should return true if the goal is completed. The way you determine if a goal
    is complete is different for each type of goal.
3. GetDetailsString - This method should return the details of a goal that could be shown in a list. 
    It should include the checkbox, the short name, and description. Then in the case of the ChecklistGoal 
    class, it should be overridden to shown the number of times the goal has been accomplished so far.
4. GetStringRepresentation - This method should provide all of the details of a goal in a way that is 
    easy to save to a file, and then load later.

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

    public ChecklistGoal(string shortName, string description, int points, int target, int bonus) : base(shortName, description, points)
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
        return $"{base.GetDetailsString()} - Completed {_amountCompleted}/{_target} times";
    }

    public override string GetStringRepresentation()
    {
        return $"{base.GetDetailsString()}\nAmount Completed: {_amountCompleted}/{_target} - Bonus: {_bonus}";
    }
}
