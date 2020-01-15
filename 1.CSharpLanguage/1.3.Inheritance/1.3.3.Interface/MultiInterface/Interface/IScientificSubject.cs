namespace SmartLin.LearningCSharp.Inheritance
{
    /// <summary>
    /// 科研课题；
    /// </summary>
    public interface IScientificSubject
    {
        /// <summary>
        /// 课题选题；
        /// </summary>
        string SubjectTitle { get; set; }                           //接口的属性中的get、set访问器不能包含实现；
        /// <summary>
        /// 申报课题；
        /// </summary>
        void SubmitSubject();
    }
}
