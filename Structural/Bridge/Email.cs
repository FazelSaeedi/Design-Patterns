namespace Design_Patterns.Structural.Bridge
{
    ///
    /// The Abstraction class 
    ///
    public abstract class Email
    {
        public IEmailSender MessageSender { get; set; }
        public string Subject{ get; set;  }
        public string Body { get; set; }
        public abstract void Send();
    }

}
