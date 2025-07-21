namespace AbstractFactory;

public class WindowsButton : IButton
{
  public void HandleClick()
  {
    Console.WriteLine("Handle window click event");
  }

  public void Render()
  {
    Console.WriteLine("Render windows button");
  }
}
