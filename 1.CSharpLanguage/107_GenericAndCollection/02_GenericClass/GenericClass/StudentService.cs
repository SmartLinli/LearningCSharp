namespace SmartLin.LearningCSharp.GenericTypeAndCollection
{
	/// <summary>
	/// 学生服务；
	/// </summary>
	public class StudentService
    {
        /// <summary>
        /// 注册；
        /// </summary>
        /// <param name="student">学生</param>
        public static void Register(Student student)                     
        {
            student.Status = "已注册";
        }
    }
}
