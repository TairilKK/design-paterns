using Prototype;

var c1 = new Circle()
{
  Radius = 5,
  X = 1,
  Y = 2,
  Border = new Border()
  {
    Color = "Red",
    Size = "2px"
  }
};

Circle c2 = (Circle)c1.Clone();

bool referenceEquals = ReferenceEquals(c1, c2);
Console.WriteLine($"Reference Equals: {referenceEquals}");


bool borderReferenceEquals = ReferenceEquals(c1.Border, c2.Border);
Console.WriteLine($"Reference Equals: {borderReferenceEquals}");
