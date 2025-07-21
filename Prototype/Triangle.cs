namespace Prototype;

public class Triangle : Shape
{
  public override Shape Clone()
  {
    Triangle cloneBase = (Triangle)MemberwiseClone();

    cloneBase.Border = new Border()
    {
      Size = Border.Size,
      Color = Border.Color
    };

    return cloneBase;
  }

  public override void Render()
  {
    Console.WriteLine("Render triangle");
  }
}
