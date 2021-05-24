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
            Student[] tempResults = new Student[students.Length];
            int tempResultCount = 0;
            foreach (Student student in students)
            {
                if (student.Name == studentName)
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
        /// 按性别查找；
        /// </summary>
        /// <param name="students">多名学生</param>
        /// <param name="gender">性别</param>
        /// <returns>多名学生</returns>
        public static Student[] FindByGender(this Student[] students, Gender gender)
        {
            Student[] tempResults = new Student[students.Length];
            int tempResultCount = 0;
            foreach (Student student in students)
            {
                if (student.Gender == gender)
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
        /// 按生日早于某日查找；
        /// </summary>
        /// <param name="students">多名学生</param>
        /// <param name="date">日期</param>
        /// <returns>多名学生</returns>
        public static Student[] FindByBirthDateEarlierThan(this Student[] students, DateTime date)
        {
            Student[] tempResults = new Student[students.Length];
            int tempResultCount = 0;
            foreach (Student student in students)
            {
                if (student.BirthDate <= date)
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
    }
}
