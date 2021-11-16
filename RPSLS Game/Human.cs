using System;

public class Human
{
    public int userInput;
    public string Choice;
    public string name;
    
    public Human(string playerName)
    {
        name = playerName;
    }
	public string ChooseGesture()
    {
        Console.WriteLine("Please choose a number below\nPick 1 for rock\npick 2 for paper\npick 3 for scissors\npick 4 for lizard\npick 5 for spock\n");
        int user_input = Console.ReadLine()
        if(user_input == 1)
            {
             return "rock";
            }
        else if(user_input == 2)
            {
            return "paper";
            }
        else if (user_input== 3)
            {
            return "scissors";
            }
        else if (user_input== 4)
            {
            return "lizard";
            }
        else if( user_input== 5)
            {
            return "spock";
            }
        else
            Console.WriteLine("choose valid number");
            string Choice = ChooseGesture()



}
