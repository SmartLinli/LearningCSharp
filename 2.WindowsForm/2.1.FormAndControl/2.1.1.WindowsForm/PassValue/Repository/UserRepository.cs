using System;
using System.Collections.Generic;

namespace SmartLin.LearningCSharp.FormAndControl
{
    /// <summary>
    /// 用户仓储；
    /// </summary>
    public static class UserRepository
    {
        /// <summary>
        /// 获取用户；
        /// </summary>
        /// <param name="number">学号/工号</param>
        /// <returns>用户</returns>
        public static User GetUser(string number)
        {
            User user = new User()
            {
                Number = "3210707001",
                Name = "张三"
            };
            return user;
        }
    }
}