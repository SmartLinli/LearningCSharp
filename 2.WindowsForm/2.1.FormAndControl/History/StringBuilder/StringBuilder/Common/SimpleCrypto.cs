
namespace SmartLin.LearningCSharp.StringBuilder
{
    public class SimpleCrypto : ICrypto
    {
        public string Encrypt(string plainText)
        {
            string cipherText = plainText;
            for (int i = 'a'; i < 'z'; i++)
            {
                char
                    oldLowerCaseLetter = (char)i
                    , newLowerCaseLetter = (char)(i - 1);
                cipherText = cipherText.Replace(oldLowerCaseLetter, newLowerCaseLetter);
            }
            for (int i = 'A'; i < 'Z'; i++)
            {
                char
                    oldUpperCaseLetter = (char)i
                    , newUpperCaseLetter = (char)(i - 1);
                cipherText = cipherText.Replace(oldUpperCaseLetter, newUpperCaseLetter);
            }
            for (int i = '0'; i < '9'; i++)
            {
                char
                    oldDigit = (char)i
                    , newDigit = (char)(i - 1);
                cipherText = cipherText.Replace(oldDigit, newDigit);
            }
            return cipherText;
        }
    }
}
