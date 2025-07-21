namespace Prototype;

public class Rectangle : Shape
{
  public override Shape Clone()
  {
    Rectangle cloneBase = (Rectangle)MemberwiseClone();

    cloneBase.Border = new Border()
    {
      Size = Border.Size,
      Color = Border.Color
    };

    return cloneBase;
  }

  public override void Render()
  {
    Console.WriteLine("Render rectangle");
  }
}
