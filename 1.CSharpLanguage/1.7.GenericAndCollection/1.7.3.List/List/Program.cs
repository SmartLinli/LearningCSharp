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
                new Student("3210707001", "田杰红", Gender.FEMALE, new DateTime(2001, 9, 10));
            List<Student> students = new List<Student>()                                                //定义泛型列表对象，并在初始化器中直接指定各元素；
            {
                studentNo1,
                new Student("3210707002", "刘兰", Gender.FEMALE, new DateTime(2003, 2, 9)),
                new Student("3210707003", "吴争宇", Gender.MALE, new DateTime(2004, 1, 5)),
                new Student("3210707004", "廖丽珍", Gender.FEMALE, new DateTime(2002, 11, 12)),
                new Student("3210707005", "王诗琴", Gender.FEMALE, new DateTime(2003, 10, 28)),
                new Student("3210707006", "罗清香", Gender.FEMALE, new DateTime(2003, 2, 24)),
                new Student("3210707007", "谢晓丹", Gender.FEMALE, new DateTime(2002, 10, 19)),
                new Student("3210707008", "刘浩雄", Gender.MALE, new DateTime(2002, 9, 25)),
                new Student("3210707009", "程琨耀", Gender.MALE, new DateTime(2002, 11, 29)),
                new Student("3210707010", "李健铭", Gender.MALE, new DateTime(2002, 3, 25))
            };
            WriteLine($"当前容量：{students.Capacity}。");
            WriteLine($"当前个数：{students.Count}。");
            students.TrimExcess();                                                                      //删除额外容量；
            WriteLine($"当前容量：{students.Capacity}。");
            
            students.Add                                                                                //添加元素；
                (new Student("3210707011", "陈伟平", Gender.MALE, new DateTime(2003, 6, 1)));
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
                        new Student("3210707012", "胡羽心", Gender.FEMALE, new DateTime(2003, 7, 10)),
                        new Student("3210707013", "李佳佳", Gender.FEMALE, new DateTime(2003, 3, 26)),
                        new Student("3210707014", "钟稚琴", Gender.FEMALE, new DateTime(2002, 9, 24))
                    });
            students.Insert                                                                             //在指定位置插入元素；
                (14, new Student("3210707015", "官祥杰", Gender.MALE, new DateTime(2002, 11, 29)));
            
            /*
            students.Remove                                                                             //查找指定元素并删除；
                (new Student("3210707001", null, 0));                                                   //查找时将调用equals方法进行匹配；若未重写equals方法，将调用object类的equals方法；
            students.RemoveAll                                                                          //查找满足条件的所有元素并删除；
                (s => s.BirthDate.Value.Year >= 2002);                                                  //条件通过委托指定；
            students.Clear();                                                                           //清除所有元素；
            */
            
            string studentNumber = "3210707001";
            if (students.Exists(s => s.Number == studentNumber))                                        //判断满足条件的元素是否存在；
            {
                Student student = students.Find(s => s.Number == studentNumber);                        //返回满足条件的第一项元素；
                WriteLine($"查得学号为{studentNumber}的学生{student.Name}。");
            }
            else
            {
                WriteLine($"该班不存在学号为{studentNumber}的学生。");
            }
            
            WriteLine("查找2003年之前出生的学生：");
            students.FindAll                                                                            //查找满足条件的所有元素；
                (s => s.BirthDate.Value.Year < 2003)                                                    
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