using System;

namespace SmartLin.LearningCSharp.DelegateAndEvent
{
    /// <summary>
    /// 学生服务；
    /// </summary>
    public static partial class StudentService
    {
        /// <summary>
        /// 匹配（包含条件值）；
        /// </summary>
        /// <param name="student">学生</param>
        /// <param name="value">条件值</param>
        /// <returns>是否匹配</returns>
        public delegate bool MatchWithValue(Student student, object value);                             //定义委托；
        /// <summary>
        /// 按指定条件值查找；
        /// </summary>
        /// <param name="students">学生</param>
        /// <param name="match">匹配（包含条件值）</param>
        /// <param name="value">条件值</param>
        /// <returns>多名学生</returns>
        public static Student[] FindBy(this Student[] students, MatchWithValue match, object value)    //使用委托作为参数；
        {
            Student[] tempResults = new Student[students.Length];
            int tempResultCount = 0;
            foreach (Student student in students)
            {
                if (match(student, value))                                                             //调用委托；
                {
                    tempResults[tempResultCount] = student;
                    tempResultCount++;
                }
            }
            Student[] results = new Student[tempResultCount];
            int resultsCount = 0;
            foreach (Student student in tempResults)
            {
                if (student != null)
                {
                    results[resultsCount] = student;
                    resultsCount++;
                }
            }
            return results;
        }
        /// <summary>
        /// 姓名作为条件；
        /// </summary>
        /// <param name="student">学生</param>
        /// <param name="value">条件值</param>
        /// <returns>是否满足</returns>
        public static bool FindByName(Student student, object value)
        {
            string studentName = value as string;
            return student.Name == studentName;
        }
        /// <summary>
        /// 性别作为条件；
        /// </summary>
        /// <param name="student">学生</param>
        /// <param name="value">条件值</param>
        /// <returns>是否满足</returns>
        public static bool FindByGender(Student student, object value)
        {
            string studentGender = value as string;
            return student.Gender == studentGender;
        }
        /// <summary>
        /// 生日早于某日作为条件；
        /// </summary>
        /// <param name="student">学生</param>
        /// <param name="value">条件值</param>
        /// <returns>是否满足</returns>
        public static bool FindByBirthDateEarlierThan(Student student, object value)
        {
            DateTime studentBirthDate = (DateTime)value;
            return student.BirthDate <= studentBirthDate;
        }
    }
}
