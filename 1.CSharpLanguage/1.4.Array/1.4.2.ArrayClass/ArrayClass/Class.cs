
namespace SmartLin.LearningCSharp.ArrayClass
{
    /// <summary>
    /// 班级；
    /// </summary>
    public class Class
    {
        /// <summary>
        /// 最大学生数；
        /// </summary>
        private int _MaxStudentCount = 5;
        /// <summary>
        /// 当前学生数；
        /// </summary>                         
        private int _CurrentStudentCount = 0;
        /// <summary>
        /// 简称；
        /// </summary>
        public string ShortName { get; set; }
        /// <summary>
        /// 学生；
        /// </summary>
        public Student[] Students { get; private set; }
        /// <summary>
        /// 添加学生；
        /// </summary>
        /// <param name="newStudent">新学生</param>
        public void AddStudent(Student newStudent)
        {
            if (this._CurrentStudentCount >= this._MaxStudentCount)                 //若当前学生人数达到最大学生人数；
            {
                this._MaxStudentCount *= 2;                                         //增加最大学生人数；
                Student[] newStudents = new Student[this._MaxStudentCount];         //基于新的最大学生人数，定义新数组；
                this.Students.CopyTo(newStudents, 0);                               //调用Array类的CopyTo方法，将源数组的元素复制至新数组；
                this.Students = newStudents;                                        //将数组属性指向新数组；
            }
            this.Students[this._CurrentStudentCount] = newStudent;                  //将新学生赋予数组中的最后元素；
            this._CurrentStudentCount++;                                            //当前学生人数递增；
        }
        /// <summary>
        /// 添加多名学生；
        /// </summary>
        /// <param name="newStudents">学生数组</param>
        public void AddStudents(Student[] newStudents)
        {
            foreach (Student student in newStudents)
            {
                this.AddStudent(student);
            }
        }
        /// <summary>
        /// 构造函数；
        /// </summary>
        /// <param name="shortName">简称</param>
        public Class(string shortName)
        {
            this.ShortName = shortName;
            this.Students = new Student[this._MaxStudentCount];
            this._CurrentStudentCount = 0;
        }
    }
}
