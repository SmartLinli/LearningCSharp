using System;
using System.Collections.Generic;

namespace SmartLin.LearningCSharp.GenericTypeAndCollection
{
    class Program
    {
        static void Main()
        {
            Student studentNo1 = 
                new Student("3180707001", "周林好", Gender.FEMALE, new DateTime(2000, 4, 17));
            List<Student> students = new List<Student>()                                                //定义泛型列表对象，并在初始化器中直接指定各元素；
            {                                                                      
                studentNo1
                , new Student("3180707002", "林钦妹", Gender.FEMALE, new DateTime(1999, 10, 18))
                , new Student("3180707003", "胡方珍", Gender.FEMALE, new DateTime(2000, 1, 22))
                , new Student("3180707004", "谢永成", Gender.MALE, new DateTime(2000, 3, 2))
                , new Student("3180707005", "龙禹吉", Gender.FEMALE, new DateTime(1999, 8, 10))
                , new Student("3180707006", "陈雯婷", Gender.FEMALE, new DateTime(2000, 8, 24))
                , new Student("3180707007", "李乐健", Gender.MALE, new DateTime(2000, 1, 10))
                , new Student("3180707008", "李志杰", Gender.MALE, new DateTime(2001, 1, 14))
                , new Student("3180707009", "刘燕婷", Gender.FEMALE, new DateTime(2000, 9, 28))
                , new Student("3180707010", "梁婷", Gender.FEMALE, new DateTime(1999, 6, 12))
            };
            Console.WriteLine("当前容量：{0}。", students.Capacity);
            Console.WriteLine("当前个数：{0}。", students.Count);
            students.TrimExcess();                                                                      //删除额外容量；
            Console.WriteLine("当前容量：{0}。", students.Capacity);
            students.Add                                                                                //添加元素；
                (new Student("3180707011", "刘雪晴", Gender.FEMALE, new DateTime(2000, 7, 5)));            
            if (!students.Contains(studentNo1))                                                         //判断是否包含指定元素；
            {
                students.Add(studentNo1);
                Console.WriteLine("新增学生{0}。", studentNo1.Name);
            }
            else
            {
                Console.WriteLine("已有学生{0}，请勿重复添加。", studentNo1.Name);
            }
            students.AddRange                                                                           //批量添加元素；
                (new List<Student>()                                                                    //除添加列表，还可添加数组；
                    {                                                                      
                        new Student("3180707012", "关令勇", Gender.MALE, new DateTime(1999, 1, 5))
                        , new Student("3180707013", "林燕婕", Gender.FEMALE, new DateTime(2000, 8, 7))
                        , new Student("3180707015", "丁雅婷", Gender.MALE, new DateTime(2000, 4, 2))               
                    });
            students.Insert                                                                             //在指定位置插入元素；
                (13, new Student("3180707014", "张海展", Gender.MALE, new DateTime(2000, 6, 14)));
            /*
            students.Remove                                                                             //查找指定元素并删除；
                (new Student("3180707001", null, 0));                                                   //查找时将调用equals方法进行匹配；若未重写equals方法，将调用object类的equals方法；
            students.RemoveAll                                                                          //查找满足条件的所有元素并删除；
                (s => s.BirthDate.Value.Year >= 2000);                                                  //条件通过委托指定；
            students.Clear();                                                                           //清除所有元素；
            */
            students.FindAll                                                                            //查找满足条件的所有元素；
                (s => s.BirthDate.Value.Year < 2000)                                                    //若调用Find方法，则只返回满足条件的第一项元素；
                .ForEach                                                                                //迭代每个元素；
                (s => Console.WriteLine                                                                 //并通过委托执行指定的操作；
                        ("学号：{0,-15}姓名：{1,-5}\t生日：{2}"
                        , s.Number
                        , s.Name
                        , s.BirthDate.Value.ToLongDateString()));                                       
            string studentNumber = "31800707100";
            Console.WriteLine
                ("该班{0}存在学号为{1}的学生。"
                , students.Exists(s => s.Number == studentNumber) ? "" : "不"                           //满足条件的元素是否存在；
                , studentNumber);
            students.Sort();                                                                            //元素必须实现IComparable接口，方可调用无参的Sort方法；
            students.Sort((s, s2) => s.Name.CompareTo(s2.Name));                                        //通过委托指定排序选项；
            students.Reverse();                                                                         //倒转顺序；
            students.ForEach                                                                            
                (s => Console.WriteLine
                        ("学号：{0,-15}姓名：{1,-5}\t生日：{2}"
                        , s.Number
                        , s.Name
                        , s.BirthDate.Value.ToLongDateString()));
            Console.Read();
        }
    }
}
