namespace cSharpMonday
{
  class GameBetter
  {
    public List<Choice> Options { get; private set; } = new List<Choice>() { new Rock(), new Paper(), new Scissors() };
    public GameBetter()
    {
      Console.WriteLine("Type your choice! ( Rock, Paper or Scissors )");
      string? playerChoice = Console.ReadLine();
      Round(playerChoice?.ToLower());
    }
    public void Round(string? playerChoice)
    {
      Choice cChoice = Computer();
      Choice? pChoice = Options.Find(o => o.Draw.ToLower() == playerChoice);
      // make sure pChoice is defined
      if (pChoice == null)
      {
        Console.WriteLine("INVALID CHOICE");
      }
      if (pChoice?.Draw == cChoice.Name)
      {
        Console.WriteLine("Its a Draw!");
      }
      if (pChoice?.Win == cChoice.Name)
      {
        Console.WriteLine("You Win!");
      }
      if (pChoice?.Lose == cChoice.Name)
      {
        Console.WriteLine("You Lost!");
      }

    }
    public Choice Computer()
    {
      Random rand = new Random();
      int computer = rand.Next(0, 3);
      return Options[computer];
    }
  }
}