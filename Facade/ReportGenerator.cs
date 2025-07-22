public class ReportGenerator
{
  public void GenerateReport(IEnumerable<string> qualityScanErrors,
    IEnumerable<string> securityScanErrors, IEnumerable<string> dependencycanErrors)
  {
    Console.WriteLine("Quality Scan Errors: ");
    Console.WriteLine(string.Join(", ", qualityScanErrors));

    Console.WriteLine("Security Scan Errors: ");
    Console.WriteLine(string.Join(", ", securityScanErrors));

    Console.WriteLine("Dependency Scan Errors: ");
    Console.WriteLine(string.Join(", ", dependencycanErrors));
  }
}
