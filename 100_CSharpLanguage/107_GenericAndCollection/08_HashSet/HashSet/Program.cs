using System;
using System.Collections.Generic;
using System.Linq;

namespace SmartLin.LearningCSharp.GenericTypeAndCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Student>                                                                    //定义散列集；
                students = new HashSet<Student>()
                {
                    new Student("3180707001", "周林好", Gender.FEMALE)
                    , new Student("3180707002", "林钦妹", Gender.FEMALE)
                    , new Student("3180707003", "胡方珍", Gender.FEMALE)
                    , new Student("3180707004", "谢永成", Gender.MALE)
                    , new Student("3180707005", "龙禹吉", Gender.FEMALE)
                    , new Student("3180708001", "袁建波", Gender.MALE)
                    , new Student("3180708002", "欧璐谣", Gender.FEMALE)
                    , new Student("3180708003", "贲筠斯", Gender.FEMALE)
                }
                , students2 = new HashSet<Student>()
                {
                    new Student("3180707004", "谢永成", Gender.MALE)
                    , new Student("3180707005", "龙禹吉", Gender.FEMALE)
                    , new Student("3180707006", "陈雯婷", Gender.FEMALE)
                    , new Student("3180708002", "欧璐谣", Gender.FEMALE)
                    , new Student("3180708003", "贲筠斯", Gender.FEMALE)
                    , new Student("3180708004", "蓝侦衔", Gender.MALE)
                    , new Student("3180708005", "任紫钰", Gender.FEMALE)
                }
                , students3 = new HashSet<Student>()
                {
                    new Student("3180707006", "陈雯婷", Gender.FEMALE)
                    , new Student("3180708002", "欧璐谣", Gender.FEMALE)
                };
            Console.WriteLine("差集：");
            students.Except<Student>(students2).ToList<Student>().ForEach                       //调用Except泛型方法获取2个集的差集；散列集可转为列表，调用ForEach方法迭代访问各元素；
                (s => Console.WriteLine
                        ("学号：{0,-15}姓名：{1,-5}\t性别：{2}"
                        , s.Number
                        , s.Name
                        , s.Gender == Gender.MALE ? "男" : "女"));
            Console.WriteLine("交集：");
            students.Intersect<Student>(students2).ToList<Student>().ForEach                    //调用Intersect泛型方法获取2个集的差集；
                (s => Console.WriteLine
                        ("学号：{0,-15}姓名：{1,-5}\t性别：{2}"
                        , s.Number
                        , s.Name
                        , s.Gender == Gender.MALE ? "男" : "女"));
            Console.WriteLine("并集：");
            students.Union<Student>(students2).ToList<Student>().ForEach                        //调用Union泛型方法获取2个集的并集；
                (s => Console.WriteLine
                        ("学号：{0,-15}姓名：{1,-5}\t性别：{2}"
                        , s.Number
                        , s.Name
                        , s.Gender == Gender.MALE ? "男" : "女"));
            Console.WriteLine
                ("students3{0}是students2的子集。"
                , students3.IsSubsetOf(students2) ? "" : "不");                                 //调用IsSubsetOf方法判断是否子集；
            Console.WriteLine
                ("students2{0}是students3的超集。"
                , students2.IsSupersetOf(students3) ? "" : "不");                               //调用IsSupersetOf方法判断是否超集；
            Console.Read();
        }
    }
}
