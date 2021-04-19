using System;

namespace SmartLin.LearningCSharp.TemplateMethod
{
    /// <summary>
    /// 考试安排抽象模板；
    /// </summary>
    public abstract class ExaminationArrangementTemplate                                        //定义抽象模板；
    {
        /// <summary>
        /// 考试；
        /// </summary>
        protected IExamination _Examination;                                                    
        /// <summary>
        /// 指定课程；
        /// </summary>
        protected abstract void AssignCourse();                                                 //抽象模板中的基本方法可为抽象方法，由派生类重写；
        /// <summary>
        /// 指定考场；
        /// </summary>
        protected abstract void AssignExaminationRoom();
        /// <summary>
        /// 指定监考人员；
        /// </summary>
        protected abstract void AssignInvigilator();
        /// <summary>
        /// 印制试卷；
        /// </summary>
        protected virtual void PrintPaper()                                                     //抽象模板中的基本方法可为虚方法，由派生类重写或继承；
        {
            Console.WriteLine("请上传试卷文件……");
            Console.ReadLine();
            Console.Write("输入印制份数：");
            Console.ReadLine();
        }
        /// <summary>
        /// 通知监考人员；
        /// </summary>
        protected virtual void InformInvigilator()
        {
            Console.WriteLine
                ("发送短信至手机{0}：{1}老师，您有监考任务，请登录系统查看详细安排。\n"
                , this._Examination.Invigilator.PhoneNumber
                , this._Examination.Invigilator.Name);
        }
        /// <summary>
        /// 申报考试；
        /// </summary>
        /// <returns></returns>
        public IExamination DeclareExamination()                                                //抽象模板中的模板方法用于汇总基本方法；
        {
            this.AssignCourse();
            this.AssignExaminationRoom();
            this.AssignInvigilator();
            this.PrintPaper();
            this.InformInvigilator();
            return this._Examination;                                     
        }
    }
}
