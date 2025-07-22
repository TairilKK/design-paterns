public class Checkbox : Component
{
  public void Select()
  {
    Console.WriteLine("Checkbox selected");

    _mediator.Notify(this, "checkboxSelected");
  }
  public void SaveValue()
  {
    Console.WriteLine("Checkbox value saved");
  }
}
