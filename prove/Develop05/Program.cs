using System;
using System.Net.Quic;

namespace GoalProgram
{
class Program
{
    //Extra things for the Surpassing Expectations
    //Put an extra message if the person accomplishes the bonus
    //Message for bonus includes a bunch of stars
    //Extra option in menu to display the score again.
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    } 
}
}
