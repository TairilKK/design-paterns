namespace AbstractFactory;

public class WindowsFactory : IUIElementFactory
{
  public IButton CreateButton()
  {
    return new WindowsButton();
  }

  public ITextbox CreateTextbox()
  {
    return new WindowsTextbox();
  }
}
