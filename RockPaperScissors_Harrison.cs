public class Harrison_RPS {
    public static void Main(string[] args) {
        Random rand = new Random();

        //Constants for the computerChoise
         int ROCK = 0;
         int PAPER = 1;
         int SCISSORS = 2;

        int computerChoice = -1;
        string playerChoice = "";
        string wantToPlay = "yes";

        //Wins, Losses, Ties
        int wins = 0;
        int loss = 0;
        int ties = 0;

        // Game starts here

        Console.WriteLine("******************************************");
        Console.WriteLine("*****Welcome to Rock, Paper, Scissors*****");
        Console.WriteLine("******************************************");

        while(wantToPlay.Equals("yes")){
            computerChoice = rand.Next(3);
            //Taking player choise
            Console.WriteLine("Type Rock, Paper, or Scissors");
            playerChoice = Console.ReadLine();

            //Determine Winner
            if(computerChoice == ROCK && playerChoice.Equals("rock")){
                Console.WriteLine("You and the computer both chose Rock, You Tied!");
                ties++;
            }
            else if(computerChoice == ROCK && playerChoice.Equals("paper")){
                Console.WriteLine("Your paper covered the computers Rock!! You Win!");
                wins++;
            }
            else if(computerChoice == ROCK && playerChoice.Equals("scissors")){
                Console.WriteLine("Your Scissors got smashed by the computers Rock. You Lose!");
                loss++;
            }
            else if(computerChoice == PAPER && playerChoice.Equals("rock")){
                Console.WriteLine("Your Rock got covered by the computers paper. You lose!");
                loss++;
            }
            else if(computerChoice == PAPER && playerChoice.Equals("paper")){
                Console.WriteLine("You and the computer both chose Paper, You Tied!");
                ties++;
            }
            else if(computerChoice == PAPER && playerChoice.Equals("scissors")){
                Console.WriteLine("Your scissors cut the computers Paper!! You Win!");
                wins++;
            }
            else if(computerChoice == SCISSORS && playerChoice.Equals("rock")){
                Console.WriteLine("Your Rock smashed the computers scissors!! You Win!");
                wins++;
            }
            else if(computerChoice == SCISSORS && playerChoice.Equals("paper")){
                Console.WriteLine("Your Paper got cut by the computers scissors, You Lose!");
                loss++;
            }
            else if(computerChoice == SCISSORS && playerChoice.Equals("scissors")){
                Console.WriteLine("You both chose scissors, You tied with the computer");
                ties++;
            }
            else{
                Console.WriteLine("You didn't choose correctly, please type rock, paper, or scissors");
            }
            Console.WriteLine("Do you want to play again? Type Yes or No");
            wantToPlay = Console.ReadLine();
        }
        Console.WriteLine("Thanks for playing!!!! You won " + wins + ", lost " + loss +", and tied " + ties + " games!");
    }
}