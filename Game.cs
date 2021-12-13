namespace cSharpMonday
{
  class Game
  {
    public Game()
    {
      Console.WriteLine("Type your choice! ( Rock, Paper or Scissors )");
      string playerChoice = Console.ReadLine();
      Round(playerChoice);
    }
    public void Round(string playerChoice)
    {
      //ROCK = 1
      //PAPER = 2
      //SCISSORS = 3
      if( playerChoice.ToLower() == "rock"){
        if(Computer() == 1 )
        {
          Console.WriteLine("Computer chose Rock! It's a TIE!");
        }
        else if(Computer() == 2 )
        {
          Console.WriteLine("Computer chose Paper! You Lost!");
        }
        else if(Computer() == 3 )
        {
          Console.WriteLine("Computer chose Scissors! You Won!");
        }
      }
      else if( playerChoice.ToLower() == "paper"){
        if(Computer() == 1 )
        {
          Console.WriteLine("Computer chose Rock! You Won!");
        }
        else if(Computer() == 2 )
        {
          Console.WriteLine("Computer chose Paper! It's a TIE!");
        }
        else if(Computer() == 3 )
        {
          Console.WriteLine("Computer chose Scissors! You Lost!");
        }
      }
      else if( playerChoice.ToLower() == "scissors"){
        if(Computer() == 1 )
        {
          Console.WriteLine("Computer chose Rock! You Lost!");
        }
        else if(Computer() == 2 )
        {
          Console.WriteLine("Computer chose Paper! You Won!");
        }
        else if(Computer() == 3 )
        {
          Console.WriteLine("Computer chose Scissors! It's a TIE!");
        }
      }
    }
    private int Computer()
    {
      Random rand = new Random();
      int computer = rand.Next(1,4);
      return computer;
    }
   }
}
