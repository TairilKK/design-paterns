namespace Adapter;

public class PushSender : INotificationSender
{
  public void SendNotification(int userId, Notification notification)
  {
    Console.WriteLine($"Sending push notification, to: {userId}, Title: {notification.Title}, Body: {notification.Body}");
  }
}
