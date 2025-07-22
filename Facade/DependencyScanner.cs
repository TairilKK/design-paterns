public class DependencyScanner
{
  public IEnumerable<string> DependencyScan(string githubUrl)
  {
    Console.WriteLine("Dependency scan");

    return new List<string>() { "dependency error1" };
  }
}
