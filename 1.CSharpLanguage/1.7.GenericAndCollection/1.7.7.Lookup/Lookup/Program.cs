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
            Class im20 = new Class(infomationManagement, 2020);
            Major publicServiceAdministration = new Major("公共事业管理", "公管");
            Class psa20 = new Class(publicServiceAdministration, 2020);
            List<Student> studentsList = new List<Student>()                                    //定义泛型列表对象；
            {
                new Student("3200707001", "闭敏媛", Gender.FEMALE, im20),
                new Student("3200707002", "储艺", Gender.FEMALE, im20),
                new Student("3200707003", "胡江彬", Gender.FEMALE, im20),
                new Student("3200707004", "林金川", Gender.MALE, im20),
                new Student("3200707005", "王泉井", Gender.FEMALE, im20),
                new Student("3200708001", "陈静怡", Gender.FEMALE, psa20),
                new Student("3200708002", "程黄朝", Gender.MALE, psa20),
                new Student("3200708003", "金国燕", Gender.FEMALE, psa20),
                new Student("3200708004", "李毅", Gender.FEMALE, psa20),
                new Student("3200708005", "李成芳", Gender.FEMALE, psa20)
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
