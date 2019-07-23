using System;

namespace SmartLin.LearningCSharp.OperatorAndCast
{
    class Program
    {
        static void Main()
        {
            Student[] newStudents =                                                    
            {                                                                      
                new Student("3180707001", "周林好")
                ,new Student("3180707002", "林钦")
                ,new Student("3180707003", "胡方珍")
                ,new Student("3180707004", "谢永成")
                ,new Student("3180707005", "龙禹吉")
            };
            Class im18 = new Class("18信管");
            im18 += newStudents;
            /*查找学生*/
            Console.WriteLine
                ("查得学生{0}。"
                , im18["3180707001"].Name);                                             //通过索引器获取数组元素；
            /*修改学生*/
            im18["3180707002"].Name = "林钦妹";                                         //通过索引器获取数组元素，并修改其属性；             
            Console.WriteLine
                ("学生已更名为{0}。"
                , im18["3180707002"].Name);
            /*添加学生*/
            im18["3180707006"] = new Student("3180707006", "陈雯婷");                   //通过索引器对数组元素赋值；
            Console.WriteLine
                ("新增学生{0}。"
                , im18["3180707006"].Name);
            Console.Read();
        }
    }
}
