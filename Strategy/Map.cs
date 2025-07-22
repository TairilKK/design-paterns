namespace Strategy;

public class Map
{
  private IRouteStrategy _routeStrategy;
  public Map(IRouteStrategy routeStrategy)
  {
    _routeStrategy = routeStrategy;
  }
  public void createRoute(Coordinate from, Coordinate to)
  {
    _routeStrategy.createRoute(from, to);
  }
}
