namespace Adapter;

public class SmsSender
{
  public void SendSms(string to, string message)
  {
    Console.WriteLine($"Sending SMS to: {to}");
  }
}
