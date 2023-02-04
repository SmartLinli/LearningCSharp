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
            Class im22 = new Class(infomationManagement, 2022);
            Major publicServiceAdministration = new Major("公共事业管理", "公管");
            Class psa22 = new Class(publicServiceAdministration, 2022);
            List<Student> studentsList = new List<Student>()                                    //定义泛型列表对象；
            {
                new Student("3220707001", "曾羽", Gender.MALE, im22),
                new Student("3220707002", "纪凝", Gender.MALE, im22),
                new Student("3220707003", "宋明杰", Gender.MALE, im22),
                new Student("3220707004", "温歆滢", Gender.FEMALE, im22),
                new Student("3220707005", "连云飞", Gender.MALE, im22),
                new Student("3220708001", "邱旭", Gender.MALE, psa22),
                new Student("3220708002", "林珑", Gender.FEMALE, psa22),
                new Student("3220708003", "钟秋婷", Gender.FEMALE, psa22),
                new Student("3220708004", "王钰芬", Gender.FEMALE, psa22),
                new Student("3220708005", "简丹丹", Gender.FEMALE, psa22)
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
