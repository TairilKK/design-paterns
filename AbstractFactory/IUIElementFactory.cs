namespace AbstractFactory;

public interface IUIElementFactory
{
  IButton CreateButton();
  ITextbox CreateTextbox();
}
