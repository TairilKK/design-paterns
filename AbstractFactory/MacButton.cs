namespace AbstractFactory;

public class MacButton : IButton
{
  public void HandleClick()
  {
    Console.WriteLine("Handle mac click event");
  }

  public void Render()
  {
    Console.WriteLine("Render mac button");
  }
}
