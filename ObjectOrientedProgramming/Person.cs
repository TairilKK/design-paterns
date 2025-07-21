namespace ObjectOrientedProgramming;

public class Person
{
  // fields
  public string Name;

  // methods
  public Person(string Name)
  {
    this.Name = Name;
  }

  public void SayHi()
  {
    Console.WriteLine($"Hello, my name is {Name}");
  }
}
