namespace Prototype;

public class Circle : Shape
{
  public int Radius { get; set; }
  public override Shape Clone()
  {
    Circle cloneBase = (Circle)MemberwiseClone();

    cloneBase.Border = new Border()
    {
      Size = Border.Size,
      Color = Border.Color
    };

    return cloneBase;
  }

  public override void Render()
  {
    Console.WriteLine("Render circle");
  }
}
