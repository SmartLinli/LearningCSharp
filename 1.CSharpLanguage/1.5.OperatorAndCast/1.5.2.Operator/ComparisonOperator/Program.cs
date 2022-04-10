using static System.Console;

namespace SmartLin.LearningCSharp.OperatorAndCast
{
    class Program
    {
        static void Main()
        {
            Student
                student = new Student("3220707001", "张三")
                , sameStudent = new Student("3220707001", "<空>")
                , student2 = new Student("3220305001", "张三");
			WriteLine
				($"{student.Number}号{student.Name}同学"
				+ $"与{sameStudent.Number}号{sameStudent.Name}同学"
				+ $"{(student == sameStudent ? "" : "不")}是同一人。");   //调用比较运算符==的重载，判断双方是否相等；
			WriteLine
				($"{student.Number}号{student.Name}同学"
				+ $"与{student2.Number}号{student2.Name}同学"
				+ $"{(student == student2 ? "" : "不")}是同一人。");
			Read();
        }
    }
}
