using System;
using System.Linq;

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
            Console.WriteLine("\n需要安排上机考试的课程有：");
            var availableCourses = from c in CourseRepository.GetAll()
                                   select c;
            foreach (var availableCourse in availableCourses)
            {
                Console.WriteLine("课程号：{0,-10}名称：{1} ", availableCourse.Number, availableCourse.Name);
            }
            Console.Write("请选择课程并输入课程号：");
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
            Console.Write("\n请输入上机考试人数：");
            var examineeCount = int.Parse(Console.ReadLine());
            var availableLaboratorys = from l in LaboratoryRepository.GetAll()
                                       where (l.HasClapboard && l.SeatAmount > examineeCount + 5)
                                            || (!l.HasClapboard && l.SeatAmount > examineeCount * 2 + 10)
                                       orderby l.SeatAmount, l.Number
                                       select l;
            Console.Write("上机考试可用机房有：");
            foreach (var availableLaboratory in availableLaboratorys)
            {
                Console.Write("{0} ", availableLaboratory.Number);
            }
            Console.Write("\n请选择机房并输入门牌号：");
            var laboratoryNumber = Console.ReadLine();
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
            Console.WriteLine("\n上机考试可选监考人员有：");
            foreach (var availableLaboratoryStaff in availableLaboratoryStaffs)
            {
                Console.WriteLine("工号：{0,-10}姓名：{1} ", availableLaboratoryStaff.Number, availableLaboratoryStaff.Name);
            }
            Console.Write("请选择监考人员并输入工号：");
            var laboratoryStaffNumber = Console.ReadLine();
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
            Console.WriteLine("\n请上传试卷文件至机房FTP……");
            Console.WriteLine("上传完毕。");
            Console.ReadLine();
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
