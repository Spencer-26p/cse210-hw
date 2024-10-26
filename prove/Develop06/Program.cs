using System;

/*Creative features:
1. Added the ability to remove goals, in case they are completed. This is done manually in case a user wants
to keep that goal in the list.

2. Added an active count to how many times an eternal goal has been completed.

3.Can't get additional points for a goal that is already completed.

4. Added daily goals. Daily goals keep track of what time 
*/
class Program
{
    static void Main(string[] args)
    {
        GoalManager starter = new GoalManager();
        starter.Start();
    }
}