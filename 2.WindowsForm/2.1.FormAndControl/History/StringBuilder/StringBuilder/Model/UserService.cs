
namespace SmartLin.LearningCSharp.StringBuilder
{
    public static class UserService
    {
        private static ICrypto _Crypto;
        private static IRepository<User> _UserRepository;
        public static User SignUp(string number, string password)
        {
            User newUser = User.Create(number, password, _Crypto);
            _UserRepository.Insert(newUser);
            return newUser;
        }
        public static User Login(string number, string password)
        {
            User user = _UserRepository.Get(u => u.Number == number && u.Password == _Crypto.Encrypt(password));
            return user;
        }
        static UserService()
        {
            _Crypto = new SimpleCrypto();
            _UserRepository = new UserRepository();
        }
    }
}
