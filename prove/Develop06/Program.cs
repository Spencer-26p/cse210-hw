using System;

/*Creative features:
1. Added the ability to remove goals, in case they are completed. This is done manually in case a user wants
to keep that goal in the list.

2. Added an active count to how many times an eternal goal has been completed.

3.Can't get additional points for a goal that is already completed.

4. Added daily goals. Daily goals keep a tally of activities and adds a streak as long as the time since the last event
does not exceed 2 days. Each streak adds a multiplier of points for the activity by a (rounded) 10%.
*/
class Program
{
    static void Main(string[] args)
    {
        GoalManager starter = new GoalManager();
        starter.Start();
    }
}