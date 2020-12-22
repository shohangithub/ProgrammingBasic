
using System;
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;

namespace SOLID_Principle.SRP
{
    public class Implementation
    {
        public class UserService
        {
            EmailService _emailService;
          
            public UserService(EmailService aEmailService)
            {
                _emailService = aEmailService;
            }
            public void Register(string email, string password)
            {
                if (!_emailService.ValidateEmail(email))
                    throw new ValidationException("Email is not an email");

                _emailService.SendEmail("myname@mydomain.com");

            }
        }
        public class EmailService
        {
            public bool  ValidateEmail(string email)
            {
                return email.Contains("@");
            }
            public void SendEmail(string message)
            {
                Console.WriteLine($"Send mail into {message}");
            }
        }
    }
}
