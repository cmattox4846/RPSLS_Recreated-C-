using System;
using System;

public class Ai
{

    public string Choice;
    public string name;

    public Ai(string playerName)
    {
        name = playerName;
        Choice = ChooseGesture();
    }
    public string ChooseGesture()
    {
        Random rnd = new Random();
        int AIChoice = rnd.Next(1, 6);
        if (AIChoice == 1)
        {
            return "rock";
        }
        else if (AIChoice == 2)
        {
            return "paper";
        }
        else if (AIChoice == 3)
        {
            return "scissors";
        }
        else if (AIChoice == 4)
        {
            return "lizard";
        }
        else if (AIChoice == 5)
        {
            return "spock";
        }
        else
        {
            return "choose valid number";
        }

    }

}
