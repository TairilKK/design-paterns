using Singleton;

var cfg1 = Configuration.GetInstance();
var cfg2 = Configuration.GetInstance();

if (ReferenceEquals(cfg1, cfg2))
{
  Console.WriteLine("Configuration is singleton");
}
