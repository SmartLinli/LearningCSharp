using static System.Console;

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
            Write("请输入充值金额：");
            var amount = decimal.Parse(ReadLine());
            WriteLine($"{newStudent.Name}成功充值{amount}元。\n");
        }
    }
}
