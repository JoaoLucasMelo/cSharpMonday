


namespace cSharpMonday
{
  public class Scissors : Choice
  {
    public Scissors()
    {
      Win = "paper";
      Lose = "rock";
      Draw = "scissors";
      Name = "scissors";

    }

    public string Win { get; private set; }
    public string Lose { get; private set; }
    public string Draw { get; private set; }
  }
}