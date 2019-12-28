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
        private int _InitialStudentCount = 5;                                      
        /// <summary>
        /// 当前学生人数；
        /// </summary>
        private int _CurrentStudentCount = 0;                                      
        /// <summary>
        /// 简称；
        /// </summary>
        public string ShortName
        {
            get;
            set;
        }
        /// <summary>
        /// 学生；
        /// </summary>
        public Student[] Students
        {
            get;
            private set;
        }
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
        public static Class operator +(Class currentClass, Student newStudent)      
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
        public static Class operator +(Class currentClass, Student[] newStudents)   
        {
            currentClass.AddStudents(newStudents);
            return currentClass;
        }
        /// <summary>
        /// 根据学号访问学生；
        /// </summary>
        /// <param name="number">学号</param>
        /// <returns>学生</returns>
        public Student this[string number]                                          //通过索引运算符实现索引器；
        {
            get                                                                     //索引器与属性相似；
            {
                foreach (Student student in this.Students)
                {
                    if (student.Number == number)
                    {
                        return student;
                    }
                }
                return null;
            }
            set
            {
                for (int i = 0; i < this.Students.Length; i++)
                {
                    if (this.Students[i].Number == number)
                    {
                        this.Students[i] = value;
                        return;
                    }
                }
                this.AddStudent(value);
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
