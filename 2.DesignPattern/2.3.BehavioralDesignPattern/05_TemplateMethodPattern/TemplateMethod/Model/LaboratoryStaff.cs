
namespace SmartLin.LearningCSharp.TemplateMethod
{
    /// <summary>
    /// 实验员；
    /// </summary>
    public class LaboratoryStaff : IFaculty
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
        /// <summary>
        /// 手机号码；
        /// </summary>
        public string PhoneNumber
        {
            get;
            set;
        }
    }
}
