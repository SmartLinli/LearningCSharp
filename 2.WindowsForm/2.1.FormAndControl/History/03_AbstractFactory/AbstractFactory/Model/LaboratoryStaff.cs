using System;

namespace SmartLin.LearningCSharp.FactoryPattern
{
    /// <summary>
    /// 实验员；
    /// </summary>
    public class LaboratoryStaff : IInvigilator
    {
        /// <summary>
        /// 工号；
        /// </summary>
        public string Number
        {
            get;
            set;
        }
        /// <summary>
        /// 姓名；
        /// </summary>
        public string Name
        {
            get;
            set;
        }
        public void ShowResult()
        {
            Console.WriteLine("\n上机考试监考人员为：{0}\n", this.Name);
        }
    }
}
