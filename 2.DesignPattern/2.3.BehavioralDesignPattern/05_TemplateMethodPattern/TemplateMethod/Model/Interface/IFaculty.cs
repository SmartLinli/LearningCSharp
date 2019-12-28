
namespace SmartLin.LearningCSharp.TemplateMethod
{
    /// <summary>
    /// 监考；
    /// </summary>
    public interface IFaculty
    {
        /// <summary>
        /// 工号；
        /// </summary>
        string Number
        {
            get;
            set;
        }
        /// <summary>
        /// 姓名；
        /// </summary>
        string Name
        {
            get;
            set;
        }
        /// <summary>
        /// 手机号码；
        /// </summary>
        string PhoneNumber
        {
            get;
            set;
        }
    }
}
