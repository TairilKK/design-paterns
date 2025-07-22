var pizzaBase = new MediumPizza();

var mediumPizzaWithCheee = new CheesePizzaDecorator(pizzaBase);

Console.WriteLine(mediumPizzaWithCheee.CalculatePrice());

var p2 = new SalamiPizzaDecorator(mediumPizzaWithCheee);

Console.WriteLine(p2.CalculatePrice());
