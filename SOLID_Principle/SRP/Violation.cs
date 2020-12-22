
using System;
using System.ComponentModel.DataAnnotations;

namespace SOLID_Principle.SRP
{
    public class Violation
    {
        public class UserService
        {
            public void Register(string email, string password)
            {
                if (!ValidateEmail(email))
                    throw new ValidationException("Email is not an email");
             
                SendEmail("mysite@nowhere.com");
            }
            public virtual bool ValidateEmail(string email)
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
