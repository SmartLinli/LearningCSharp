using System;

namespace SmartLin.LearningCSharp.ProxyPattern
{
    class Program
    {
        static void Main()
        {

            Course oop = new Course("2060316", "面向对象程序设计", 4.5f);               //定义真实对象；
            CourseProxy oopProxy = new CourseProxy(oop);                                //定义代理对象；
            oopProxy.Update();                                                          //调用代理对象的方法；
            Console.Read();
        }
    }
}
