namespace SOLID;

public class Cannon : IPrinter
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

  public void Scan(string content)
  {
    throw new NotImplementedException();
  }
}
