namespace ObjectOrientedProgramming;

public class Hp : IPrinter
{
  public void Print(string content)
  {
    Console.WriteLine("Hp printing: " + content);
  }
}
