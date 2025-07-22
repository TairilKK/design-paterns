namespace Adapter;

public class SmsSenderAdapter : INotificationSender
{
  private SmsSender _smsSender = new SmsSender();
  public void SendNotification(int userId, Notification notification)
  {
    string userPhoneNumber = null;
    _smsSender.SendSms(userPhoneNumber, $"{notification.Title} {notification.Body}");
  }
}
