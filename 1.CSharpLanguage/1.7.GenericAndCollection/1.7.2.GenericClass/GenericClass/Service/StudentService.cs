namespace SmartLin.LearningCSharp.GenericTypeAndCollection
{
	/// <summary>
	/// 学生服务；
	/// </summary>
	public static class StudentService
    {
        /// <summary>
        /// 注册；
        /// </summary>
        /// <param name="student">学生</param>
        public static void Register(this Student student)                     
        {
            student.Status = "已注册";
        }
    }
}
