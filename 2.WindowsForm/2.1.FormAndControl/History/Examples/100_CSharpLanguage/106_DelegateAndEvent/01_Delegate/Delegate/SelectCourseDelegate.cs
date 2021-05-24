
namespace SmartLin.LearningCSharp.DelegateAndEvent
{
    /// <summary>
    /// 选课后续；
    /// </summary>
    /// <param name="student">学生</param>
    /// <param name="courseName">课程名称</param>
    public delegate void AfterSelectCourseDelegate(Student student, string courseName);     //定义委托；委托实为派生自System.MulticastDelegate的新类；
}
