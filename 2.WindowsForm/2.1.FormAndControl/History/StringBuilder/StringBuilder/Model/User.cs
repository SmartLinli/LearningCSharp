
namespace SmartLin.LearningCSharp.StringBuilder
{
    public class User
    {
        public string Number
        {
            get;
            private set;
        }
        public string Password
        {
            get;
            private set;
        }
        public ICrypto Crypto
        {
            get;
            private set;
        }
        public static User Create(string number, string password, ICrypto crypto)
        {
            User newUser = new User();
            newUser.Number = number;
            newUser.Crypto = crypto;
            newUser.Password = crypto.Encrypt(password);
            return newUser;
        }
    }
}
