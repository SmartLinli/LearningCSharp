using System.Collections;

namespace SmartLin.LearningCSharp.OperatorAndCast
{
    /// <summary>
    /// 班级；
    /// </summary>
    public class Class
    {
        /// <summary>
        /// 最大学生人数；
        /// </summary>
        private int _MaxStudentCount = 5;
        /// <summary>
        /// 当前学生人数；
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
            if (this._CurrentStudentCount >= this._MaxStudentCount)
            {
                this._MaxStudentCount *= 2;
                Student[] newStudents = new Student[this._MaxStudentCount];
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
        public Student this[string number]                                          //通过索引运算符实现索引器；索引运算符的输入参数将作为查找元素的条件；
        {                                                                           //索引器与属性相似；索引器亦支持重载；
            get                                                                     //在get访问器中，遍历数组，查找是否存在符合条件的元素；若存在，则返回该元素，否则返回空值；           
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
            set                                                                     //在set访问器中，遍历数组，查找是否存在符合条件的元素；若存在，则替换该元素，否则添加新元素；
            {
                for (int i = 0; i < this.Students.Length; i++)                      //此处不可使用foreach循环，因为foreach的循环变量是只读的；
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
            this.Students = new Student[this._MaxStudentCount];
            this._CurrentStudentCount = 0;
        }
    }
}
