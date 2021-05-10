using System;

namespace SmartLin.LearningCSharp.GenericTypeAndCollection
{
    /// <summary>
    /// 学生服务；
    /// </summary>
    public static class StudentService
    {
        /// <summary>
        /// 查找；
        /// </summary>
        /// <param name="students">多名学生</param>
        /// <param name="find">匹配</param>
        /// <returns>多名学生</returns>
        public static Student[] Find(this Student[] students, Func<Student, bool> match)                                //使用预定义的泛型委托作为参数；Func泛型委托可指定参数类型与返回类型；
        {
            int resultsCount = 0;
            foreach (var student in students)
            {
                if (match(student))
                    resultsCount++;
            }
            Student[] results = new Student[resultsCount];
            int i = 0;
            foreach (var student in students)
            {
                if (match(student))
                {
                    results[i] = student;
                    i++;
                }
            }
            return results;
        }
        /// <summary>
        /// 计数；
        /// </summary>
        /// <param name="students">多名学生</param>
        /// <param name="predicate">匹配</param>
        /// <returns>个数</returns>
        public static int Count(this Student[] students, Predicate<Student> match)                                      //使用预定义的泛型委托作为参数；Predicate泛型委托可指定参数类型，返回类型则为bool；
        {
            int count = 0;
            foreach (Student student in students)
            {
                if (match(student))
                {
                    count++;
                }
            }
            return count;
        }
        /// <summary>
        /// 修改；
        /// </summary>
        /// <param name="students">多名学生</param>
        /// <param name="modify">修改</param>
        /// <returns>多名学生</returns>
        public static Student[] Modify(this Student[] students, Action<Student> modify)                                 //使用预定义的泛型委托作为参数；Action泛型委托可指定参数类型，无返回值；
        {
            foreach (Student student in students)
            {
                modify(student);                                                                                        //调用委托；
            }
            return students;
        }
        /// <summary>
        /// 排序；
        /// </summary>
        /// <param name="students">多名学生</param>
        /// <param name="comparison">比较</param>
        /// <returns>多名学生</returns>
        public static Student[] Sort(this Student[] students, Comparison<Student> comparison)
        {
            Array.Sort(students, comparison);
            return students;
        }
        /// <summary>
        /// 查找最大；
        /// </summary>
        /// <param name="students">多名学生</param>
        /// <param name="getProperty">获取指定属性的值</param>
        /// <returns>学生</returns>
        public static Student Max<T>(this Student[] students, Func<Student, T> getProperty) where T : IComparable   //使用自定义的泛型委托作为参数；
        {
            Student maxStudent = students[0];
            foreach (Student student in students)
            {
                if (getProperty(student).CompareTo(getProperty(maxStudent)) >= 0)                                       //调用委托；
                {
                    maxStudent = student;
                }
            }
            return maxStudent;
        }
    }
}
