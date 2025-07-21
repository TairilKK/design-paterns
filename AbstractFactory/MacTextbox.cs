namespace AbstractFactory;

public class MacTextbox : ITextbox
{
  public void HandleInput()
  {
    Console.WriteLine("Handle mac text input");
  }

  public void Render()
  {
    Console.WriteLine("Render mac textbox");
  }
}
