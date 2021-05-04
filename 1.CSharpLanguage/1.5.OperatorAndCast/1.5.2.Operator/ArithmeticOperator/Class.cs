using System.Collections;

namespace SmartLin.LearningCSharp.OperatorAndCast
{
    /// <summary>
    /// 班级；
    /// </summary>
    public class Class
    {
        /// <summary>
        /// 初始学生人数；
        /// </summary>
        private int _InitialStudentCount = 5;                                       //初始学生人数；
        /// <summary>
        /// 当前学生人数；
        /// </summary>
        private int _CurrentStudentCount = 0;                                       //当前学生人数；
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
        /// <param name="newStudents">新学生</param>
        public void AddStudents(Student[] newStudents)
        {
            foreach (Student student in newStudents)
            {
                this.AddStudent(student);
            }
        }
        /// <summary>
        /// 获取枚举器；
        /// </summary>
        /// <returns>枚举器</returns>
        public IEnumerator GetEnumerator()
        {
            foreach (Student student in this.Students)
            {
                yield return student;
            }
        }
        /// <summary>
        /// 添加学生；
        /// </summary>
        /// <param name="currentClass">班级</param>
        /// <param name="newStudent">新学生</param>
        /// <returns>班级</returns>
        public static Class operator +(Class currentClass, Student newStudent)      //重载算术运算符+；+作为二元运算符，必须提供2个参数；
        {
            currentClass.AddStudent(newStudent);
            return currentClass;
        }
        /// <summary>
        /// 添加多名学生；
        /// </summary>
        /// <param name="currentClass">班级</param>
        /// <param name="newStudents">新学生</param>
        /// <returns>班级</returns>
        public static Class operator +(Class currentClass, Student[] newStudents)   //重载算术运算符+；
        {
            currentClass.AddStudents(newStudents);
            return currentClass;
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
