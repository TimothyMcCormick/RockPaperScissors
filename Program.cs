// See https://aka.ms/new-console-template for more information

bool playing = true;
int userPoints = 0;
int computerPoints = 0;
while (playing)
{
  System.Console.WriteLine("Hello, World! Welcome to my Rock, Paper, Scissors game! Please enter a number below for your choice and press Enter");

  System.Console.WriteLine("1. Rock");
  System.Console.WriteLine("2. Paper");
  System.Console.WriteLine("3. Scissors");

  string userChoice = System.Console.ReadLine();
  Random randomChoice = new Random();
  int computerChoice = randomChoice.Next(1, 4);

  switch (computerChoice)
  {
    case 1:
      if (userChoice == "1")
      {
        //this is a tie
        System.Console.WriteLine("User chose Rock");
        System.Console.WriteLine("Computer chose Rock");
        System.Console.WriteLine("Game tied");
      }

      else if (userChoice == "2")
      {
        System.Console.WriteLine("User chose Paper");
        System.Console.WriteLine("Computer chose Rock");
        System.Console.WriteLine("User wins");
        userPoints++;
      }

      else if (userChoice == "3")
      {
        System.Console.WriteLine("User chose Scissors");
        System.Console.WriteLine("Computer chose Rock");
        System.Console.WriteLine("Computer Wins");
        computerPoints++;
      }
      break;

    case 2:
      if (userChoice == "1")
      {
        Console.WriteLine("User chose Rock");
        Console.WriteLine("Computer chose Paper");
        Console.WriteLine("Computer Wins");
        computerPoints++;
      }

      else if (userChoice == "2")
      {
        //this is a tie
        Console.WriteLine("User chose Paper");
        Console.WriteLine("Computer chose Paper");
        Console.WriteLine("Game tied");
      }
      else if (userChoice == "3")
      {
        Console.WriteLine("User chose Scissors");
        Console.WriteLine("Computer chose Paper");
        Console.WriteLine("User wins");
        userPoints++;
      }
      break;

    case 3:
      if (userChoice == "1")
      {
        System.Console.WriteLine("User chose Rock");
        System.Console.WriteLine("Computer chose Scissors");
        System.Console.WriteLine("User wins");
        userPoints++;
      }
      else if (userChoice == "2")
      {
        System.Console.WriteLine("User chose Paper");
        System.Console.WriteLine("Computer chose Scissors");
        System.Console.WriteLine("Computer Wins");
        computerPoints++;
      }
      else if (userChoice == "3")
      {
        //this is a tie
        System.Console.WriteLine("User chose Scissors");
        System.Console.WriteLine("Computer chose Scissors");
        System.Console.WriteLine("Game tied");
      }
      break;
  }
  System.Console.WriteLine("Would you like to play again?");
  System.Console.WriteLine("Enter Y or N");



  string playAgain = System.Console.ReadLine();

  System.Console.Clear();
  if (playAgain == "N" || playAgain == "n" || playAgain == "no")
  {
    playing = false;
    System.Console.WriteLine($"User has {userPoints} points - Computer has {computerPoints} points");

  }
  else if (playAgain == "Y" || playAgain == "y" || playAgain == "yes")
  {
    playing = true;
    System.Console.WriteLine($"User has {userPoints} points - Computer has {computerPoints} points");
  }

}




