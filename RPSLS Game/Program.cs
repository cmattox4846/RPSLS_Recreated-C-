using RSPLS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPSLS
{
    static void Main(string[] args)
    {


        public class GameBoard
        {
              
            public void RunGame()
            {
                DisplayWelcome();
                GameModeChoice();
            }


            public void DisplayWelcome()
            {
                Console.WriteLine("Welcome to RPSLS (Rock, Paper, Scissors, Lizard, Spock");
                Console.WriteLine("RPSLS is just like Rock Paper Scissors, each player has to choose any one variable Rock, Paper, Scissors, Lizard or Spock.  Once the each player has chosen there vaiable, the choicces will be revealed and compared and winner will be decleared.  The winner will be decided by the chart below  * Rock crushes Scissors  ---  Scissors cuts Paper --- Paper covers Rock --- Rock crushes Lizard --- Lizard poisons Spock   Spock smashes Scissors --- Scissors decapitates Lizard --- Lizard eats Paper --- Paper disproves Spock --- Spock vaporizes Rock");
            }


            public void GameModeChoice()
            { 
                Console.WriteLine("1 - To play against a another human  2 - To Play against the computer ");
                     int game_mode = int.Parse(Console.ReadLine());
                
                int number_of_games = NumberOfGames();

                Console.WriteLine("Please enter your name: ");
                    string player_one_name = Console.ReadLine();
                
                Human player1 = new(player_one_name);
            
                if(game_mode == 1)
                {
                    Console.WriteLine(" Please enter your name: ");
                    string player_two_name = Console.ReadLine();

                    Human player2 = new(player_two_name);
                    play_game(number_of_games, player_one_name,player_two_name);
                }


                else if (game_mode == 2) 
                {
                   Ai AiPlayer = new("Iron Man");
                    play_game(number_of_games, player_one_name,AiPlayer.name);
                }

                else 
                {
                    Console.WriteLine("Please only pick 1 or 2!");
                    GameModeChoice();

                 }
            }

            public int NumberOfGames() 
            {
                Console.WriteLine("  Please choose number of games up to 20:  ");
                int numberOfGames = int.Parse(Console.ReadLine());
                int amount_to_win = Math.Floor(numberOfGames / 2) + 1;

                return amount_to_win;
            }

           public void play_game(int number_of_games, string player_one_name, string player_two_name) 
            {


                int player_1_score = 0;
                int player_2_score = 0;
                bool game_over = false;
                string choice1 = "";
                string choice2 = "";
                string player_2_name = player_two_name;


                while (game_over == false){
                    Console.WriteLine("{player_one_name}, It is your turn.", player_one_name);
                choice1 = Human.player.ChooseGesture();
                    Console.WriteLine(" {player_2_name}, It is your turn.", player_two_name);
                choice2 = player_two.choose_gesture();
                    Console.WriteLine(" {player_one_name} has {choice1} VS {player_2_name} has {choice2}");
                    string winner = determine_winner(choice1, choice2);
                    if (winner == choice1) 
                    {
                    player_1_score += 1;
                    Console.WriteLine("  {player_one_name} has a score of {player_1_score}");
                    Console.WriteLine(" {player_2_name} has a score of {player_2_score}");
                     }
                    else if (winner == choice2) 
                    {
                    player_2_score += 1;
                    Console.WriteLine("  {player_one_name} has a score of {player_1_score}");
                    Console.WriteLine(" {player_2_name} has a score of {player_2_score}");
                    }


                if (player_1_score == number_of_games) 
                {
                    DisplayWinner(player_one_name);
                    game_over = true;
                }
                else if (player_2_score == number_of_games)
                {
                    DisplayWinner(player_2_name);
                    game_over = true;
                }
                
            }

            public string determine_winner(choice1, choice2) { 
                if choice1 == "rock" and choice2 == "scissors"){
                    Console.WriteLine("{choice1} beats {choice2}");
                    return choice1;
            }
                else if( choice1 == "scissors" and choice2 == "paper"){
                    Console.WriteLine("{choice1} beats {choice2}");
                    return choice1;
                }
                else if( choice1 == "paper" and choice2== "rock"){
                     Console.WriteLine("{choice1} beats {choice2}");
                     return choice1;
                    }
                else if( choice1 == "rock" and choice2== "lizard"){
                    Console.WriteLine("{choice1} beats {choice2}");
                    return choice1;
                  }
                else if( choice1 == "lizard" and choice2== "spock"){
                    Console.WriteLine("{choice1} beats {choice2}");
                    return choice1;
                  }
                else if( choice1 == "spock" and choice2== "scissors"){
                    Console.WriteLine("{choice1} beats {choice2}");
                    return choice1;
                  }
                else if( choice1 == "scissors" and choice2== "lizard"){
                    Console.WriteLine("{choice1} beats {choice2}");
                    return choice1;
                   }
                else if( choice1 == "lizard" and choice2== "paper"){
                    Console.WriteLine("{choice1} beats {choice2}");
                    return choice1;
                  }
                else if( choice1 == "paper" and choice2== "spock"){
                    Console.WriteLine("{choice1} beats {choice2}");
                    return choice1;
                  }
                else if( choice1 == "spock" and choice2== "rock"){
                    Console.WriteLine("{choice1} beats {choice2}");
                    return choice1;
                   }
                else if( choice2 == "rock" and choice1 == "scissors"){
                    Console.WriteLine("{choice2} beats {choice1}");
                    return choice2;
                  }
                else if( choice2 == "scissors" and choice1== "paper"){
                    Console.WriteLine("{choice2} beats {choice1}");
                    return choice2;
                    }
                else if( choice2 == "paper" and choice1== "rock"){
                    Console.WriteLine("{choice2} beats {choice1}");
                    return choice2;
                    }
                else if( choice2 == "rock" and choice1== "lizard"){
                    Console.WriteLine("{choice2} beats {choice1}");
                    return choice2;
                     }
                else if( choice2 == "lizard" and choice1== "spock"){
                    Console.WriteLine("{choice2} beats {choice1}");
                    return choice2;
                     }
                else if( choice2 == "spock" and choice1== "scissors"){
                    Console.WriteLine("{choice2} beats {choice1}");
                    return choice2;
                  }
                else if( choice2 == "scissors" and choice1== "lizard"){
                    Console.WriteLine("{choice2} beats {choice1}");
                    return choice2
                  }
                else if( choice2 == "lizard" and choice1== "paper"){
                    Console.WriteLine("{choice2} beats {choice1}");
                    return choice2;
                  }
                else if( choice2 == "paper" and choice1== "spock")
                  {
                    Console.WriteLine("{choice2} beats {choice1}");
                    return choice2;
                  }
                else if( choice2 == "spock" and choice1== "rock")
                  {
                    Console.WriteLine("{choice2} beats {choice1}");
                    return choice2;
                  }
                else {
                    Console.WriteLine("Its a draw! You both choose {choice1}");
                    }
            }




            public void DisplayWinner(string player)
            {
                Console.WriteLine(" Congrats {player} you have won the game!", player);
                Console.WriteLine(" Would you like to play again?  1- Play Again  2- End Game  Enter Choice: ");
                int answer = int.Parse(Console.ReadLine());
                if (answer == 1) {
                RunGame();
                        }
                //else{
                //    Environment.Exit(code)
                //    }
               }
        }
    }

