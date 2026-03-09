using System.Security.Cryptography;
using System.Text;

public class Hash
{
    public static string GerarHash(string senha)
    {
        SHA1 sha = SHA1.Create();
        byte[] bytes = Encoding.UTF8.GetBytes(senha);
        byte[] hash = sha.ComputeHash(bytes);

        StringBuilder sb = new StringBuilder();

        foreach (byte b in hash)
        {
            sb.Append(b.ToString("x2"));
        }

        return sb.ToString();
    }
}