namespace SOLID;

// Bad duck abstraction
public class RubberDuck : Duck
{
  public override void Fly()
  {
    throw new NotImplementedException();
  }

  public override void Quack()
  {
    Console.WriteLine("Rubber duck quack");
  }

  public override void Swim()
  {
    Console.WriteLine("Rubber duck swim");
  }
}
