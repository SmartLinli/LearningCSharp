using System.Collections.Generic;
using System.Linq;
using System;

namespace SmartLin.LearningCSharp.StringBuilder
{
    public  class UserRepository:IRepository<User>
    {
        private  List<User> _Users;
        public  void Insert(User newUser)
        {
            _Users.Add(newUser);
        }
        public  User Get(Predicate<User> expression)
        {
            return _Users.Find(expression);
        }
        public UserRepository()
        {
           this. _Users = new List<User>();
        }
    }
}
