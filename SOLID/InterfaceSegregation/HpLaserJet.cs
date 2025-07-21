namespace SOLID;

public class HpLaserJet : IPrinter
{
  public void Fax(string content)
  {
    Console.WriteLine("Hp Laser Jet fax");
  }

  public void PrintColor(string content)
  {
    Console.WriteLine("Hp Laser Jet print color");
  }

  public void PrintGray(string content)
  {
    Console.WriteLine("Hp Laser Jet print gray");
  }

  public void Scan(string content)
  {
    Console.WriteLine("Hp Laser Jet scan");
  }
}
