using Strategy;

var map = new Map(GetStrategy());
var from = new Coordinate();
var to = new Coordinate();

map.createRoute(from, to);

static IRouteStrategy GetStrategy()
{
  return new BikeStrategy();
}
