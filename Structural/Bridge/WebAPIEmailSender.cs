using System;

namespace Design_Patterns.Structural.Bridge
{
    ///
    /// The ConcreteImplementor class 
    ///
    public class WebAPIEmailSender : IEmailSender
    {
        public void SendEmail(string subject, string body)
        {
            Console.WriteLine("Sending Email using Web API:\n{0}\n{1}\n", subject, body);
        }
    }

}
