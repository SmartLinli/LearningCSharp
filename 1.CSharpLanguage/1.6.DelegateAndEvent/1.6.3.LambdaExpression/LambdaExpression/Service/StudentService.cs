using System;

namespace SmartLin.LearningCSharp.DelegateAndEvent
{
    /// <summary>
    /// 学生服务；
    /// </summary>
    public static partial class StudentService
    {
        /// <summary>
        /// 按学号查找；
        /// </summary>
        /// <param name="students">多名学生</param>
        /// <param name="studentNumber">学号</param>
        /// <returns>学生</returns>
        public static Student FindByNumber(this Student[] students, string studentNumber)
        {
            Student result = null;
            foreach (Student student in students)
            {
                if (student.Number == studentNumber)
                {
                    result = student;
                    break;
                }
            }
            return result;
        }
        /// <summary>
        /// 按姓名查找；
        /// </summary>
        /// <param name="students">多名学生</param>
        /// <param name="studentName">姓名</param>
        /// <returns>多名学生</returns>
        public static Student[] FindByName(this Student[] students, string studentName)
        {
            int resultsCount = 0;
            foreach (var student in students)
            {
                if (student.Name == studentName)
                    resultsCount++;
            }
            Student[] results = new Student[resultsCount];
            int i = 0;
            foreach (var student in students)
            {
                if (student.Name == studentName)
                {
                    results[i] = student;
                    i++;
                }
            }
            return results;
        }
        /// <summary>
        /// 按性别查找；
        /// </summary>
        /// <param name="students">多名学生</param>
        /// <param name="gender">性别</param>
        /// <returns>多名学生</returns>
        public static Student[] FindByGender(this Student[] students, string gender)
        {
            int resultsCount = 0;
            foreach (var student in students)
            {
                if (student.Gender == gender)
                    resultsCount++;
            }
            Student[] results = new Student[resultsCount];
            int i = 0;
            foreach (var student in students)
            {
                if (student.Gender == gender)
                {
                    results[i] = student;
                    i++;
                }
            }
            return results;
        }
        /// <summary>
        /// 按生日早于某日查找；
        /// </summary>
        /// <param name="students">多名学生</param>
        /// <param name="date">日期</param>
        /// <returns>多名学生</returns>
        public static Student[] FindByBirthDateEarlierThan(this Student[] students, DateTime date)
        {
            int resultsCount = 0;
            foreach (var student in students)
            {
                if (student.BirthDate <= date)
                    resultsCount++;
            }
            Student[] results = new Student[resultsCount];
            int i = 0;
            foreach (var student in students)
            {
                if (student.BirthDate <= date)
                {
                    results[i] = student;
                    i++;
                }
            }
            return results;
        }
    }
}
