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
                new Student("3200707001", "闭敏媛", Gender.FEMALE, new DateTime(2001, 7, 21));
            List<Student> students = new List<Student>()                                                //定义泛型列表对象，并在初始化器中直接指定各元素；
            {
                studentNo1,
                new Student("3200707002", "储艺", Gender.FEMALE, new DateTime(2001, 7, 12)),
                new Student("3200707003", "胡江彬", Gender.FEMALE, new DateTime(2000, 9, 6)),
                new Student("3200707004", "林金川", Gender.MALE, new DateTime(2001, 7, 18)),
                new Student("3200707005", "王泉井", Gender.FEMALE, new DateTime(2000, 10, 12)),
                new Student("3200707006", "刘伯铭", Gender.FEMALE, new DateTime(2002, 2, 17)),
                new Student("3200707007", "王子驭", Gender.MALE, new DateTime(2002, 7, 29)),
                new Student("3200707009", "郑喻文", Gender.MALE, new DateTime(2002, 5, 11)),
                new Student("3200707010", "朱素清", Gender.FEMALE, new DateTime(2002, 5, 17)),
                new Student("3200707011", "何延斌", Gender.FEMALE, new DateTime(2002, 12, 17))
            };
            WriteLine($"当前容量：{students.Capacity}。");
            WriteLine($"当前个数：{students.Count}。");
            students.TrimExcess();                                                                      //删除额外容量；
            WriteLine($"当前容量：{students.Capacity}。");
            students.Add                                                                                //添加元素；
                (new Student("3200707012", "江紫燕", Gender.FEMALE, new DateTime(2001, 10, 3)));            
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
                        new Student("3200707013", "钟永莉", Gender.FEMALE, new DateTime(2002, 6, 10))
                        , new Student("3200707015", "徐凯扬", Gender.MALE, new DateTime(2002, 11, 5))
                        , new Student("3200707016", "邓倩", Gender.FEMALE, new DateTime(2002, 8, 5))               
                    });
            students.Insert                                                                             //在指定位置插入元素；
                (13, new Student("3200707014", "谢蓝叶", Gender.FEMALE, new DateTime(2002, 7, 10)));
			/*
            students.Remove                                                                             //查找指定元素并删除；
                (new Student("3200707001", null, 0));                                                   //查找时将调用equals方法进行匹配；若未重写equals方法，将调用object类的equals方法；
            students.RemoveAll                                                                          //查找满足条件的所有元素并删除；
                (s => s.BirthDate.Value.Year >= 2002);                                                  //条件通过委托指定；
            students.Clear();                                                                           //清除所有元素；
            */
			students.FindAll                                                                            //查找满足条件的所有元素；
				(s => s.BirthDate.Value.Year < 2002)                                                    //若调用Find方法，则只返回满足条件的第一项元素；
				.ForEach                                                                                //迭代每个元素；
				(s => WriteLine                                                                         //并通过委托执行指定的操作；
						($"学号：{s.Number,-15}姓名：{s.Name,-5}\t生日：{s.BirthDate.Value.ToLongDateString()}"));                                      
            string studentNumber = "3200707100";
			WriteLine																					//满足条件的元素是否存在；
				($"该班{(students.Exists(s => s.Number == studentNumber) ? "" : "不")}存在学号为{studentNumber}的学生。");
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
