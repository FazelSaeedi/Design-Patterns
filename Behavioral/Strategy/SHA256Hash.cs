using System.Text;
using System.Security.Cryptography;

namespace Design_Patterns.Behavioral.Strategy
{
    public class SHA256Hash : IHashStrategy
    {
        public byte[] hash(string raw)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                return sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(raw));
            }
        }
    }
}
