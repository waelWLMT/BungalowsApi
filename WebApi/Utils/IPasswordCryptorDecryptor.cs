namespace WebApi.Utils
{
    public interface IPasswordCryptorDecryptor
    {
        public string CryptPassword(string password);
        public string DecryptPassword(string cryptedPassword);

    }
}
