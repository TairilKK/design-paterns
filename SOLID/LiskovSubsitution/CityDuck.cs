namespace SOLID;

public class CityDuck : Duck
{
  public override void Quack()
  {
    Console.WriteLine("City duck quack");
  }
  public override void Swim()
  {
    Console.WriteLine("City duck swim");
  }
  public override void Fly()
  {
    Console.WriteLine("City duck flies");
  }
}
