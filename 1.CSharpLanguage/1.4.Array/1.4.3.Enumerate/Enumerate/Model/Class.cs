using System.Collections;                                                           //添加引用，以便使用枚举器；

namespace SmartLin.LearningCSharp.Array
{
    /// <summary>
    /// 班级；
    /// </summary>
    public class Class
    {
        /// <summary>
        /// 初始学生数；
        /// </summary>
        private int _InitialStudentCount = 5;
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
            if (this._CurrentStudentCount >= this._InitialStudentCount)
            {
                this._InitialStudentCount *= 2;
                Student[] newStudents = new Student[this._InitialStudentCount];
                this.Students.CopyTo(newStudents, 0);
                this.Students = newStudents;
            }
            this.Students[this._CurrentStudentCount] = newStudent;
            this._CurrentStudentCount++;
        }
        /// <summary>
        /// 添加多名学生；
        /// </summary>
        /// <param name="newStudents">新学生数组</param>
        public void AddStudents(Student[] newStudents)
        {
            foreach (Student student in newStudents)
            {
                this.AddStudent(student);
            }
        }
        /// <summary>
        /// 获取枚举
        /// </summary>
        /// <returns>枚举</returns>
        public IEnumerator GetEnumerator()                                          //实现IEnumerable接口的GetEnumerator方法（但类无需实现IEnumerable接口）；
        {
            foreach (Student student in this.Students)
            {
                if (student is null)                                                //foreach无法跳过空值元素，若不加以判断可能导致异常；
                    continue;
                yield return student;                                               //yield用于创建枚举器，供foreach语句迭代访问；
            }
        }
        /// <summary>
        /// 构造函数；
        /// </summary>
        /// <param name="shortName">简称</param>
        public Class(string shortName)
        {
            this.ShortName = shortName;
            this.Students = new Student[_InitialStudentCount];
            this._CurrentStudentCount = 0;
        }
    }
}
