using System;
using System.Collections.Generic;
using System.Linq;

namespace SmartLin.LearningCSharp.Linq
{
    class Program
    {
        static void Main()
        {
            List<Student> students = StudentRepository.GetAllStudents();            

            Console.WriteLine("\n查询各班的学生人数：");
            var results5 = from s in students
                           group s by s.Class.ShortName into grouping                       //groupby子句对每个元素按照指定的属性进行分组，该属性将作为分组的键；最后定义新的范围变量取代原有范围变量，该变量为IGrouping泛型类型，包含group与by分别指定的对象与分组键，用于保存分组结果；
                           select new                                                       //定义匿名类型，作为查询结果；
                           {                                                                //groupby子句之后只能通过新的范围变量访问分组结果，不能再访问原有范围变量；
                               ClassName = grouping.Key,                                    //访问分组键，按组获取各分组的键值（即各班简称）；    
                               StudentCount = grouping.Count()                              //调用IGrouping泛型类型提供的合计函数，按组计算各分组的合计值（即各班人数）；
                           };
            foreach (var currentClass in results5)
            {
                Console.WriteLine
                        ("班级：{0,-6}人数：{1}"
                        , currentClass.ClassName
                        , currentClass.StudentCount);
            }

            Console.WriteLine("\n查询各班的学生人数与名单：");
            var results6 = from s in students
                           group s by s.Class into grouping                                 
                           select new
                           {
                               ClassName = grouping.Key,
                               StudentCount = grouping.Count(),
                               StudentNames = from s in grouping                            //通过独立查询，访问分组结果中包含的由先前group指定的对象；
                                              orderby s.Number
                                              select s.Name                                 //该查询返回包含各班学生姓名的字符串集合；
                           };
            foreach (var currentClass in results6)
            {
                Console.WriteLine
                        ("【班级：{0,-6}人数：{1}】"
                        , currentClass.ClassName
                        , currentClass.StudentCount);
                foreach (var studentName in currentClass.StudentNames)
                {
                    Console.Write("{0} ", studentName);
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n查询人数在10人以上的班级与学生人数，并按人数降序排序：");
            var results7 = from s in students
                           group s by s.Class into grouping
                           where grouping.Count() >= 10                                     //对分组结果进行筛选；
                           orderby grouping.Count() descending                              //对分组结果进行排序；
                           select new
                           {
                               ClassName = grouping.Key,
                               StudentCount = grouping.Count()
                           };
            foreach (var currentClass in results7)
            {
                Console.WriteLine
                        ("班级：{0,-6}人数：{1}"
                        , currentClass.ClassName
                        , currentClass.StudentCount);
            }

            Console.WriteLine("\n查询各班学生的平均身高、体重：");
            var results8 = from s in students
                           group s by s.Class into grouping
                           select new
                           {
                               Class = grouping.Key,
                               HeightAverage = (from s in grouping                         
                                                select s.Height)
                                                .Average(),                                 //该查询返回包含各班学生身高的集合，随后调用集合提供的合计函数；
                               WeightAverage = (from s in grouping 
                                                select s.Weight)
                                                .Average()
                           };
            foreach (var currentClass in results8)
            {
                Console.WriteLine
                        ("班级：{0,-6}平均身高：{1,-8:F}平均体重：{2:F}"
                        , currentClass.Class                                                //班级类重写了ToString方法，可直接输出；
                        , currentClass.HeightAverage
                        , currentClass.WeightAverage);
            }

            Console.WriteLine("\n查询各班男生的平均体重，并筛选出平均体重在62以上的班级：");
            var results9 = from s in students
                           where s.Gender == Gender.MALE                                    //分组前的筛选；
                           group s by s.Class into grouping
                           where (from s in grouping select s.Weight).Average() > 62f       //分组后的筛选；
                           select new
                           {
                               Name = grouping.Key,
                               WeightAverage = (from s in grouping select s.Weight).Average()
                           };
            foreach (var currentClass in results9)
            {
                Console.WriteLine
                        ("班级：{0,-6}男生平均体重：{1:F}"
                        , currentClass.Name
                        , currentClass.WeightAverage);
            }

            Console.WriteLine("\n查询各班男女生的平均身高、体重：");
            var results10 = from s in students
                            group new { s.Class.ShortName, s.Gender, s.Height, s.Weight }   //若需在分组结果中包含指定属性，则需定义匿名类型； 
                                by new { s.Class, s.Gender }                                //若需将多个属性作为分组键，则需定义匿名类型； 
                                into grouping
                            orderby grouping.Key.Class descending, grouping.Key.Gender descending
                            select new
                            {
                                Name = grouping.Key.Class,                                  //访问分组键中的指定属性；
                                Gender = grouping.Key.Gender == Gender.MALE ? "男" : "女",
                                HeightAverage = (from s in grouping select s.Height).Average(),
                                WeightAverage = (from s in grouping select s.Weight).Average()
                            };
            foreach (var currentClass in results10)
            {
                Console.WriteLine
                        ("班级：{0,-6}{1}生平均身高：{2,-8:F}{1}生平均体重：{3:F}"
                        , currentClass.Name
                        , currentClass.Gender
                        , currentClass.HeightAverage
                        , currentClass.WeightAverage);
            };

            Console.Read();
        }
    }
}
