using ObjectOrientedProgramming;

EmailSender emailSender = new EmailSender();

emailSender.ConnectToSmtpServer();
emailSender.InsertCredentials();
emailSender.SendEmail("to@mail.com", "title", "body");
emailSender.Disconnect();
