using System.Text;
using System.Security.Cryptography;

namespace Design_Patterns.Behavioral.Strategy
{
    public class MD5Hash : IHashStrategy
    {
        public byte[] hash(string raw)
        {
            using (MD5 md5Hash = MD5.Create())
            {
                return md5Hash.ComputeHash(Encoding.UTF8.GetBytes(raw));
            }
        }
    }
}
