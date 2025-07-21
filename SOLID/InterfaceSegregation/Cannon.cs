namespace SOLID;

public class Cannon : IPrinter, IFax
{
  public void Fax(string content)
  {
    Console.WriteLine("Cannon fax");
  }

  public void PrintColor(string content)
  {
    Console.WriteLine("Cannon print color");
  }

  public void PrintGray(string content)
  {
    Console.WriteLine("Cannon print gray");
  }
}
