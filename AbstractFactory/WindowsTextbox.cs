namespace AbstractFactory;

public class WindowsTextbox : ITextbox
{
  public void HandleInput()
  {
    Console.WriteLine("Handle windows text input");
  }

  public void Render()
  {
    Console.WriteLine("Render windows textbox");
  }
}
