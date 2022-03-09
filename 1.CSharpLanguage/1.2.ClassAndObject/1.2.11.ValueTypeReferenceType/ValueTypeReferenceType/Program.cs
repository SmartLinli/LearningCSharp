using System;
using static System.Console;

namespace SmartLin.LearningCSharp.ClassAndObject
{
	class Program
	{
		static void Main()
		{
			int i = 1, j = 1;												//整型（含整数、字符）、浮点型、逻辑型均属于内置类型中的简单类型，亦属于值类型；
			WriteLine($"i{(i == j ? "等于" : "不等于")}j");					//值类型的比较只比较值；
			i++;
			j = i;															//值类型的赋值只复制值；
			WriteLine($"i{(i == j ? "等于" : "不等于")}j");
			i++;
			WriteLine($"i{(i == j ? "等于" : "不等于")}j");

			DateTime today = DateTime.Now;									//.NET框架提供诸多自定义类型，但使用前需引用相应的命名空间；
																			//自定义类型均为引用类型；
			Student															//使用自行创建的自定义类型；
				boy = new Student("3220707001", "张三")
				, sameBoy = new Student("3220707001", "张三");
			WriteLine($"boy{(boy == sameBoy ? "等于" : "不等于")}Sameboy");  //引用类型的默认比较方式只比较引用（即地址）；
			sameBoy = boy;                                                  //引用类型的默认赋值方式只复制引用（即地址）；
			boy.Name = "李四";
			WriteLine($"boy{(boy == sameBoy ? "等于" : "不等于")}Sameboy");
			Read();
		}
	}
}
