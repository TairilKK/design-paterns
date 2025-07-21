namespace Singleton;

public class Configuration
{
  private static Configuration _instance = null;
  private static object obj = new object();
  public string StringProperty { get; set; }
  public int IntProperty { get; set; }
  private Configuration()
  {

  }
  public static Configuration GetInstance()
  {
    lock (obj)
    {
      if (_instance is null)
      {
        _instance = new Configuration();
      }
    }
    return _instance;
  }
}
