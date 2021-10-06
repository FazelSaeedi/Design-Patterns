using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Structural.Bridge
{
    ///
    /// The Bridge or Implementor interface 
    ///
    public interface IEmailSender
    {
        void SendEmail(string subject, string body);
        
    }

}
