using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral.Strategy
{
    public class SecureContent
    {
        private string raw;

        public SecureContent(string raw)
        {
            if (!String.IsNullOrEmpty(raw))
                this.raw = raw;
            else
                throw new Exception();
        }

        public byte[] hashContent(IHashStrategy hashStrategy)
        {
            return hashStrategy.hash(raw);
        }

    }
}
