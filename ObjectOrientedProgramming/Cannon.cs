namespace ObjectOrientedProgramming;

public class Cannon : IPrinter
{
  public void Print(string content)
  {
    Console.WriteLine("Cannon printing: " + content);
  }
}
