namespace SOLID;

public class RubberDuck : Duck
{
  public override void Quack()
  {
    Console.WriteLine("Rubber duck quack");
  }

  public override void Swim()
  {
    Console.WriteLine("Rubber duck swim");
  }
}
