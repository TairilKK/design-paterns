
namespace SOLID;

public class AuthenticationManager
{
  public void Authenticate(User user, string email, string password)
  {
    if (user.Email == email && user.Password == password)
    {
      EmailNotification emailNotification = new EmailNotification();
      emailNotification.SendNotification(user);
    }
  }
}
