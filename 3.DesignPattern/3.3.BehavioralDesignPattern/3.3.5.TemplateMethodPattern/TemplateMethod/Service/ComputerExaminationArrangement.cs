using System;
using System.Linq;
using static System.Console;

namespace SmartLin.LearningCSharp.TemplateMethod
{
    /// <summary>
    /// 上机考试安排；
    /// </summary>
    public class ComputerExaminationArrangement : ExaminationArrangementTemplate                            //定义具体模板；继承抽象模板；
    {
        /// <summary>
        /// 指定课程；
        /// </summary>
        protected override void AssignCourse()                                                              //重写抽象模板的抽象方法；
        {
            Course course = null;
            WriteLine("\n需要安排上机考试的课程有：");
            var availableCourses = from c in CourseRepository.GetAll()
                                   select c;
            foreach (var availableCourse in availableCourses)
            {
                WriteLine($"课程号：{availableCourse.Number,-10}名称：{availableCourse.Name} ");
            }
            Write("请选择课程并输入课程号：");
            var courseNumber = Console.ReadLine();
            if (courseNumber == "")
            {
                return;
            }
            course = (from c in availableCourses
                      where c.Number == courseNumber
                      select c).FirstOrDefault();
            this._Examination.Course = course;
        }
        /// <summary>
        /// 指定考场；
        /// </summary>
        protected override void AssignExaminationRoom()
        {
            IExaminationRoom laboratory = null;
            Write("\n请输入上机考试人数：");
            var examineeCount = int.Parse(ReadLine());
            var availableLaboratorys = from l in LaboratoryRepository.GetAll()
                                       where (l.HasClapboard && l.SeatAmount > examineeCount + 5)
                                            || (!l.HasClapboard && l.SeatAmount > examineeCount * 2 + 10)
                                       orderby l.SeatAmount, l.Number
                                       select l;
            Write("上机考试可用机房有：");
            foreach (var availableLaboratory in availableLaboratorys)
            {
                Write($"{availableLaboratory.Number} ");
            }
            Write("\n请选择机房并输入门牌号：");
            var laboratoryNumber = ReadLine();
            laboratory = (from r in availableLaboratorys
                          where r.Number == laboratoryNumber
                          select r).FirstOrDefault();
            this._Examination.Room = laboratory;
        }
        /// <summary>
        /// 指定监考人员；
        /// </summary>
        protected override void AssignInvigilator()
        {
            IFaculty laboratoryStaff = null;
            var availableLaboratoryStaffs = from l in LaboratoryStaffRepository.GetAll()
                                            select l;
            WriteLine("\n上机考试可选监考人员有：");
            foreach (var availableLaboratoryStaff in availableLaboratoryStaffs)
            {
                WriteLine($"工号：{availableLaboratoryStaff.Number,-10}姓名：{availableLaboratoryStaff.Name} ");
            }
            Write("请选择监考人员并输入工号：");
            var laboratoryStaffNumber = ReadLine();
            laboratoryStaff = (from l in availableLaboratoryStaffs
                               where l.Number == laboratoryStaffNumber
                               select l).FirstOrDefault();
            this._Examination.Invigilator = laboratoryStaff;
        }
        /// <summary>
        /// 印制试卷；
        /// </summary>
        protected override void PrintPaper()                                                                //重写抽象模板的虚方法；
        {
            WriteLine("\n请上传试卷文件至机房FTP……");
            WriteLine("上传完毕。");
            ReadLine();
        }
        /// <summary>
        /// 构造函数
        /// </summary>        
        public ComputerExaminationArrangement()
        {
            this._Examination = new ComputerExamination();
        }
    }
}
