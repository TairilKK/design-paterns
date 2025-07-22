public class ScanFacade
{
  private QualityScanner _qualityScanner = new QualityScanner();
  private SecurityScanner _securityScanner = new SecurityScanner();
  private DependencyScanner _dependencyScanner = new DependencyScanner();
  private ReportGenerator _reportGenerator = new ReportGenerator();
  public void Scan(string githubUrl)
  {
    Console.WriteLine("Scanning " + githubUrl);
    var qualityScanErrors = _qualityScanner.QualityScan(githubUrl);
    var securityScanErrors = _securityScanner.SecurityScan(githubUrl);
    var dependencyScanErrors = _dependencyScanner.DependencyScan(githubUrl);

    Console.WriteLine("Scan report");
    _reportGenerator.GenerateReport(qualityScanErrors, securityScanErrors, dependencyScanErrors);
  }
}
