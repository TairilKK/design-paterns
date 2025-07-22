namespace Strategy;

public class WalkStrategy : IRouteStrategy
{
  public void createRoute(Coordinate from, Coordinate to)
  {
    Console.WriteLine("Walk strategy");
  }
}
