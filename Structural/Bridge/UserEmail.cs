﻿namespace Design_Patterns.Structural.Bridge
{
    ///
    /// The RefinedAbstraction class 
    ///
    public class UserEmail : Email
    {
        public override void Send()
        {
            string emailSubject = string.Format("Subject: {0} from User", Subject);
            string emailBody = string.Format("Email Body:\n{0}", Body);
            MessageSender.SendEmail(emailSubject, emailBody);
        }

    }

}
