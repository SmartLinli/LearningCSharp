﻿using System;
using SmartLin.LearningCSharp.ClassAndObject.Model;                                     //对项目默认命名空间以外的资源访问，可通过添加调用获得便利；

namespace SmartLin.LearningCSharp.ClassAndObject.Model                                  //向文件夹添加的类，所在命名空间默认为项目默认命名空间+文件夹路径；
{
    /// <summary>
    /// 学生；
    /// </summary>
    public partial class Student                                                        //定义部分类；                                                
    {
        /// <summary>
        /// 电子邮件地址；
        /// </summary>
        public string Email
        {
            get;
            set;
        }
        /// <summary>
        /// 创建；
        /// </summary>
        /// <param name="number">学号</param>
        /// <param name="name">姓名</param>
        /// <param name="gender">性别</param>
        /// <returns>学生</returns>
        public static Student Create(string number, string name, Gender gender)         //定义静态方法；
        {
            if (number.Length != 10)
            {
                Console.WriteLine("学号长度应为10位！");
                return null;
            }
            else
            {
                Student student = new Student(number, name, gender);                    //调用私有构造函数；
                return student;
            }
        }
        /// <summary>
        /// 创建；
        /// </summary>
        /// <param name="number">学号</param>
        /// <param name="name">姓名</param>
        /// <param name="gender">性别</param>
        /// <param name="currentClass">班级</param>
        /// <returns>学生</returns>
        public static Student Create(string number, string name, Gender gender, Class currentClass)
        {
            Student student = Create(number, name, gender);                             //调用本类的静态方法；
            if (student!=null)
            {
                student.Class = currentClass;
            }
            return student;
        }
    }
}
