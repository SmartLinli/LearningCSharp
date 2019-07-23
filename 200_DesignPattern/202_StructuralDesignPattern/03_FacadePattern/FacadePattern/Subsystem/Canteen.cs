using System;

namespace SmartLin.LearningCSharp.FacadePattern
{
    /// <summary>
    /// 食堂；
    /// </summary>
    public class Canteen
    {
        /// <summary>
        /// 充值
        /// </summary>
        /// <param name="newStudent">新生</param>
        public static void PayIn(Student newStudent)
        {
            Console.Write("请输入充值金额：");
            var amount = decimal.Parse(Console.ReadLine());
            Console.WriteLine("{0}成功充值{1}元。\n", newStudent.Name, amount);
        }
    }
}
