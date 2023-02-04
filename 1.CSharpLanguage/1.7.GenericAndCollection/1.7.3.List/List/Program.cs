using System;
using System.Collections.Generic;
using static System.Console;

namespace SmartLin.LearningCSharp.GenericTypeAndCollection
{
    class Program
    {
        static void Main()
        {
            Student studentNo1 =
                new Student("3220707001", "曾羽", Gender.MALE, new DateTime(2004, 10, 10));
            List<Student> students = new List<Student>()                                                //定义泛型列表对象，并在初始化器中直接指定各元素；
            {
                studentNo1,
                new Student("3220707002", "纪凝", Gender.MALE, new DateTime(2003, 11, 11)),
                new Student("3220707003", "宋明杰", Gender.MALE, new DateTime(2004, 8, 28)),
                new Student("3220707004", "温歆滢", Gender.FEMALE, new DateTime(2004, 6, 14)),
                new Student("3220707005", "连云飞", Gender.MALE, new DateTime(2004, 5, 7)),
                new Student("3220707006", "张吉恒煊", Gender.MALE, new DateTime(2003, 12, 22)),
                new Student("3220707007", "徐思亮", Gender.MALE, new DateTime(2004, 1, 29)),
                new Student("3220707008", "林艺玲", Gender.FEMALE, new DateTime(2003, 10, 25)),
                new Student("3220707009", "张君英", Gender.FEMALE, new DateTime(2003, 5, 5)),
                new Student("3220707010", "张昕楠", Gender.FEMALE, new DateTime(2004, 9, 8)
            };
            WriteLine($"当前容量：{students.Capacity}。");
            WriteLine($"当前个数：{students.Count}。");
            students.TrimExcess();                                                                      //删除额外容量；
            WriteLine($"当前容量：{students.Capacity}。");
            
            students.Add                                                                                //添加元素；
                (new Student("3220707011", "吴梓炫", Gender.MALE, new DateTime(2004, 9, 2)));
            if (!students.Contains(studentNo1))                                                         //判断是否包含指定元素；
            {
                students.Add(studentNo1);
                WriteLine($"新增学生{studentNo1.Name}。");
            }
            else
            {
                WriteLine($"已有学生{studentNo1.Name}，请勿重复添加。");
            }
            students.AddRange                                                                           //批量添加元素；
                (new List<Student>()                                                                    //除添加列表，还可添加数组；
                    {
                        new Student("3220707012", "陈希彦", Gender.FEMALE, new DateTime(2004, 8, 5)),
                        new Student("3220707013", "卓雅洁", Gender.FEMALE, new DateTime(2004, 2, 13)),
                        new Student("3220707014", "周俊", Gender.MALE, new DateTime(2002, 11, 29))
                    });
            students.Insert                                                                             //在指定位置插入元素；
                (14, new Student("3210707015", "张淑炀", Gender.FEMALE, new DateTime(2004, 1, 21)));
            
            /*
            students.Remove                                                                             //查找指定元素并删除；
                (new Student("3220707001", null, 0));                                                   //查找时将调用equals方法进行匹配；若未重写equals方法，将调用object类的equals方法；
            students.RemoveAll                                                                          //查找满足条件的所有元素并删除；
                (s => s.BirthDate.Value.Year >= 2004);                                                  //条件通过委托指定；
            students.Clear();                                                                           //清除所有元素；
            */
            
            string studentNumber = "3220707001";
            if (students.Exists(s => s.Number == studentNumber))                                        //判断满足条件的元素是否存在；
            {
                Student student = students.Find(s => s.Number == studentNumber);                        //返回满足条件的第一项元素；
                WriteLine($"查得学号为{studentNumber}的学生{student.Name}。");
            }
            else
            {
                WriteLine($"该班不存在学号为{studentNumber}的学生。");
            }
            
            WriteLine("查找2004年之前出生的学生：");
            students.FindAll                                                                            //查找满足条件的所有元素；
                (s => s.BirthDate.Value.Year < 2004)                                                    
                .ForEach                                                                                //迭代每个元素；
                (s => WriteLine                                                                         //并通过委托执行指定的操作；
                        ($"学号：{s.Number,-15}姓名：{s.Name,-5}\t生日：{s.BirthDate.Value.ToLongDateString()}"));
            
            WriteLine("排序结果：");
            students.Sort();                                                                            //元素必须实现IComparable接口，方可调用无参的Sort方法；
            students.Sort((s, s2) => s.Name.CompareTo(s2.Name));                                        //通过委托指定排序选项；
            students.Reverse();                                                                         //倒转顺序；
            students.ForEach
                (s => WriteLine
                        ($"学号：{s.Number,-15}姓名：{s.Name,-5}\t生日：{s.BirthDate.Value.ToLongDateString()}"));
            Read();
        }
    }
}