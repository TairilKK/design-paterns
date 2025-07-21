namespace SOLID;

public class AuthenticationManager
{
  private INotificationSender _notificationSender;

  public AuthenticationManager(INotificationSender notificationSender)
  {
    _notificationSender = notificationSender;
  }

  public void Authenticate(User user, string email, string password)
  {
    if (user.Email == email && user.Password == password)
    {
      _notificationSender.SendNotification(user);
    }
  }
}
