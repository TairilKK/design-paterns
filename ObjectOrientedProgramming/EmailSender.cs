namespace ObjectOrientedProgramming;

public class EmailSender
{
  public void ConnectToSmtpServer()
  {
    Console.WriteLine("Connecting to smtp server");
  }
  public void InsertCredentials()
  {
    Console.WriteLine("Inserting credentials");
  }
  public void SendEmail(string to, string title, string body)
  {
    Console.WriteLine($"Sending email to: {to}, {title}, {body}");
  }
  public void Disconnect()
  {
    Console.WriteLine("Disconnected from the server");
  }
}
