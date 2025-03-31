namespace BLL.Utils
{
    public interface IPasswordEnryptorDecryptor
    {
        public string Encrypt(string password, string keyString);
        public string Decrypt(string encrypted, string keyString);
    }
}
