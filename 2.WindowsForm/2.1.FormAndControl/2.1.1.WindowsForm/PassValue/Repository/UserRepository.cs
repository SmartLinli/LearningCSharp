namespace SmartLin.LearningCSharp.FormAndControl
{
    /// <summary>
    /// 用户仓储；
    /// </summary>
    public static class UserRepository
    {
        /// <summary>
        /// 查找用户；
        /// </summary>
        /// <param name="number">学号/工号</param>
        /// <returns>用户</returns>
        public static User Find(string number)
        {
            User user = new User()
            {
                Number = "3230707001",
                Name = "张三"
            };
            return user;
        }
    }
}