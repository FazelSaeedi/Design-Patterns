using System;

namespace Design_Patterns.Structural.Bridge
{
    ///
    /// The ConcreteImplementor class 
    ///
    public class WebServiceEmailSender : IEmailSender
    {
        public void SendEmail(string subject, string body)
        {
            Console.WriteLine("Sending Email using WebService:\n{0}\n{1}\n", subject, body);
        }
    }

}
