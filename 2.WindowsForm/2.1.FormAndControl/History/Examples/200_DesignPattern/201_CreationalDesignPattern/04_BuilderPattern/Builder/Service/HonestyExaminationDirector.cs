
namespace SmartLin.LearningCSharp.BuilderPattern
{
    /// <summary>
    /// 诚信考试指挥者；
    /// </summary>
    public class HonestyExaminationDirector
    {
        /// <summary>
        /// 笔试建造者；
        /// </summary>
        private WrittenExaminationBuilder _WrittenExaminationBuilder = new WrittenExaminationBuilder();
        /// <summary>
        /// 构建；
        /// </summary>
        /// <returns>考试</returns>
        public IExamination Construct()
        {
            this._WrittenExaminationBuilder.AddCourse();                                //由指挥者调用建造者的建造步骤；
            this._WrittenExaminationBuilder.AddRoom();
            return this._WrittenExaminationBuilder.WrittenExamination;                  //返回产品；
        }
    }
}
