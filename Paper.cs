


namespace cSharpMonday
{
  public class Paper : Choice
  {
    public Paper()
    {
      Win = "rock";
      Lose = "scissors";
      Draw = "paper";
      Name = "paper";

    }

    public string Win { get; private set; }
    public string Lose { get; private set; }
    public string Draw { get; private set; }
  }
}