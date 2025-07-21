namespace SOLID;

public interface IPrinter
{
  void PrintGray(string content);
  void PrintColor(string content);
  void Scan(string content);
  void Fax(string content);
}
