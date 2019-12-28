using System;

namespace SmartLin.LearningCSharp.GenericTypeAndCollection
{
    /// <summary>
    /// 学生服务；
    /// </summary>
    public static class StudentService
    {
        /// <summary>
        /// 泛型委托；
        /// </summary>
        /// <typeparam name="TParameter">参数类型</typeparam>
        /// <typeparam name="TParameter2">参数类型2</typeparam>
        /// <typeparam name="TReturn">返回值类型</typeparam>
        /// <param name="parameter">参数</param>
        /// <param name="parameter2">参数2</param>
        /// <returns>返回值</returns>
        public delegate TReturn Function<TParameter, TParameter2, TReturn>(TParameter parameter, TParameter2 parameter2);
        /// <summary>
        /// 查找最大；
        /// </summary>
        /// <param name="students">多名学生</param>
        /// <param name="greaterThan">大于</param>
        /// <returns>学生</returns>
        public static Student Max(this Student[] students, Function<Student, Student, bool> greaterThan)             //使用自定义的泛型委托作为参数；
        {
            Student maxStudent = students[0];
            foreach (Student student in students)
            {
                if (greaterThan(student, maxStudent))                                                        //调用委托；
                {
                    maxStudent = student;
                }
            }
            return maxStudent;
        }
        /// <summary>
        /// 查找；
        /// </summary>
        /// <param name="students">多名学生</param>
        /// <param name="find">匹配</param>
        /// <returns>多名学生</returns>
        public static Student[] Find(this Student[] students, Func<Student, bool> match)                    //使用预定义的泛型委托作为参数；Func泛型委托可指定参数类型与返回类型；
        {
            Student[] tempResults = new Student[students.Length];
            int tempResultCount = 0;
            foreach (Student student in students)
            {
                if (match(student))                                                                         //调用委托；
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
        /// 计数；
        /// </summary>
        /// <param name="students">多名学生</param>
        /// <param name="predicate">匹配</param>
        /// <returns>个数</returns>
        public static int Count(this Student[] students, Predicate<Student> match)                          //使用预定义的泛型委托作为参数；Predicate泛型委托可指定参数类型，返回类型则为bool；
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
        public static Student[] Modify(this Student[] students, Action<Student> modify)                     //使用预定义的泛型委托作为参数；Action泛型委托可指定参数类型，无返回值；
        {
            foreach (Student student in students)
            {
                modify(student);                                                                            //调用委托；
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
    }
}
