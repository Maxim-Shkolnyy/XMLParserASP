using System.Security.Cryptography;
using System.Text;

namespace xmlParserASP.Services.UpdateServices.XmlToGammaUpload_OLD.StringCleanerServices;

public static class HashPasswordHelper
{
    public static string HashPassword(string password)
    {
        using (var sha256 = SHA256.Create())
        {
            var hashedByts = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            return BitConverter.ToString(hashedByts).Replace("-", "").ToLower();
        }
    }
}