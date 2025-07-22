public class QualityScanner
{
  public IEnumerable<string> QualityScan(string githubUrl)
  {
    Console.WriteLine("Quality scan");

    return new List<string>() { "error1", "error2" };
  }
}
