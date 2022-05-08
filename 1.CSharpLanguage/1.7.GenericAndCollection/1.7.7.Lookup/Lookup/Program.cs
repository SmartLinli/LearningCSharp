using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace SmartLin.LearningCSharp.GenericTypeAndCollection
{
	class Program
    {
        static void Main()
        {
            Major infomationManagement = new Major("信息管理与信息系统", "信管");
            Class im21 = new Class(infomationManagement, 2021);
            Major publicServiceAdministration = new Major("公共事业管理", "公管");
            Class psa21 = new Class(publicServiceAdministration, 2021);
            List<Student> studentsList = new List<Student>()                                    //定义泛型列表对象；
            {
                new Student("3210707001", "田杰红", Gender.FEMALE, im21),
                new Student("3210707002", "刘兰", Gender.FEMALE, im21),
                new Student("3210707003", "吴争宇", Gender.MALE, im21),
                new Student("3210707004", "廖丽珍", Gender.FEMALE, im21),
                new Student("3210707005", "王诗琴", Gender.FEMALE, im21),
                new Student("3210708001", "唐昆", Gender.MALE, psa21),
                new Student("3210708002", "吴诗怡", Gender.FEMALE, psa21),
                new Student("3210708003", "陈樱", Gender.FEMALE, psa21),
                new Student("3210708004", "郑凯莉", Gender.FEMALE, psa21),
                new Student("3210708005", "王富玉", Gender.MALE, psa21)
            };
            Lookup<Class, Student> studentsLookupByClass =
                (Lookup<Class, Student>)studentsList.ToLookup(s => s.Class);                    //Lookup类必须借助ToLookup方法来创建，并在参数中指定键；创建的结果为ILookup接口，还需通过显式类型转换将之转为Lookup类；
            while (true)
            {
                WriteLine("请输入年级：");
                var inputYear = int.Parse(ReadLine());
                WriteLine("请输入专业简称：");
                var inputMajorShortName = ReadLine();
                Class inputClass = new Class(new Major("", inputMajorShortName), inputYear);
				studentsLookupByClass[inputClass].ToList().ForEach								//Lookup类通过索引器传送参数，并通过循环来迭代查找结果；
					(s => WriteLine($"学号：{s.Number,-15}姓名：{s.Name,-5}\t班级：{s.Class.ShortName}"));	
			}
        }
    }
}
