using System;

namespace SmartLin.LearningCSharp.Array
{
    class Program
    {
        static void Main()
        {
            /*定义教材；*/
            Book cSharpFoundationBook = new Book("9787302360476", "C#语言程序设计基础（第3版）");
            Book cSharpExperimentBook = new Book("9787302382744", "C#语言程序设计基础实验指导（第3版）");
            Book databaseSystemBook = new Book("9787040195835", "数据库系统概论（第5版）");
            Book databaseExperimentBook = new Book("9787508476377", "数据库系统概论（第5版）习题解析与实验指导");
            /*定义课程；*/
            Course Oop = new Course("2060238", "面向对象程序设计");
            Course databaseTheory = new Course("2060308", "数据库原理");
            Course[] courses = { Oop, databaseTheory };                             //声明并（使用初始化器）初始化数组；声明数组后，将自动创建派生于Array抽象类的新类；
            Oop.Books = new Book[] { cSharpFoundationBook, cSharpExperimentBook };  //作为对象数据成员的数组已被声明过，此处需使用new初始化，不能单独使用初始化器；
            databaseTheory.Books = new Book[2];                                     //初始化时必须直接或（使用初始化器）间接指定数组大小；
            databaseTheory.Books[0] = databaseSystemBook;                           //通过索引器传送元素号，访问数组元素；
            databaseTheory.Books[1] = databaseExperimentBook;
            /*定义学生；*/
            Student[] students =                                                    
            {                                                                       //在数组初始化器中直接实例化各对象；
                new Student("3180707001", "周林好")
                ,new Student("3180707002", "林钦妹")
                ,new Student("3180707003", "胡方珍")
                ,new Student("3180707004", "谢永成")
                ,new Student("3180707005", "龙禹吉")
            };
            for (int i = 0; i < students.Length; i++)                               //调用基类Array的Lengh方法，返回数组元素个数；
            {
                students[i].LearningCourses = courses;                              //对数组进行赋值；
            }
            /*显示所有学生的课程、教材；*/
            foreach (Student student in students)                                   //使用foreach语句（单向只读）迭代数组中的所有元素；
            {
                Console.WriteLine("{0,-12}{1,-5}本学期课程：", student.Number, student.Name);
                foreach (Course course in student.LearningCourses)
                {
                    Console.WriteLine("--《{0}》", course.Name);
                    foreach (Book book in course.Books)
                    {
                        Console.WriteLine("----教材《{0}》", book.Name);
                    }
                }
            }
            Console.Read();
        }
    }
}
