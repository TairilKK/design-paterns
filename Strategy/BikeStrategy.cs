namespace Strategy;

public class BikeStrategy : IRouteStrategy
{
  public void createRoute(Coordinate from, Coordinate to)
  {
    Console.WriteLine("Bike strategy");
  }
}
