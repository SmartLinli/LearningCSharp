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
            Class im18 = new Class(infomationManagement, 2018);
            Major publicServiceAdministration = new Major("公共事业管理", "公管");
            Class psa18 = new Class(publicServiceAdministration, 2018);
            List<Student> studentsList = new List<Student>()                                    //定义泛型列表对象；
            {                                                                      
                new Student("3180707001", "周林好", Gender.FEMALE, im18)
                , new Student("3180707002", "林钦妹", Gender.FEMALE, im18)
                , new Student("3180707003", "胡方珍", Gender.FEMALE, im18)
                , new Student("3180707004", "谢永成", Gender.MALE, im18)
                , new Student("3180707005", "龙禹吉", Gender.FEMALE, im18)
                , new Student("3180708001", "袁建波", Gender.MALE, psa18)
                , new Student("3180708002", "欧璐谣", Gender.FEMALE, psa18)
                , new Student("3180708003", "贲筠斯", Gender.FEMALE, psa18)
                , new Student("3180708004", "蓝侦衔", Gender.MALE, psa18)
                , new Student("3180708005", "任紫钰", Gender.FEMALE, psa18)
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
