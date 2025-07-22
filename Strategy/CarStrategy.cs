namespace Strategy;

public class CarStrategy : IRouteStrategy
{
  public void createRoute(Coordinate from, Coordinate to)
  {
    Console.WriteLine("City strategy");
  }
}
