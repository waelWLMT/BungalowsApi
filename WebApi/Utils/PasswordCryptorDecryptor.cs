namespace WebApi.Utils
{
    public class PasswordCryptorDecryptor : IPasswordCryptorDecryptor
    {
        public string CryptPassword(string password)
        {
            return "crypted password as test";
        }

        public string DecryptPassword(string cryptedPassword)
        {
            return "decrypted password as test";
        }
    }
}
