namespace SOLID;

// We can't always treat square as rectangle
public class Square : Rectangle
{
  public override void SetHeight(int height)
  {
    base.SetHeight(height);
    base.SetWidth(height);
  }
  public override void SetWidth(int width)
  {
    base.SetHeight(width);
    base.SetWidth(width);
  }
}
