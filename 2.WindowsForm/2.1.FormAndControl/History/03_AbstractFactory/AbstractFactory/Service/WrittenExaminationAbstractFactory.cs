using System;
using System.Linq;

namespace SmartLin.LearningCSharp.FactoryPattern
{
    /// <summary>
    /// 笔试抽象工厂；
    /// </summary>
    public class WrittenExaminationAbstractFactory : IExaminationAbstractFactory
    {
        /// <summary>
        /// 创建考场；
        /// </summary>
        /// <returns>考场</returns>
        public IExaminationRoom CreateExaminationRoom()
        {
            IExaminationRoom classroom = null;
            Console.Write("请输入笔试人数：");
            var examineeCount = int.Parse(Console.ReadLine());
            var availableClassrooms = from c in ClassRoomRepository.GetAll()
                                      where c.SeatAmount > examineeCount * 2 + 10
                                      orderby c.SeatAmount, c.Number
                                      select c;
            Console.Write("符合人数要求的教室有：");
            foreach (var availableClassroom in availableClassrooms)
            {
                Console.Write("{0}（被占用星期：{1}） ", availableClassroom.Number, availableClassroom.OccupiedWeekDay.ToString());
            }
            Console.Write("\n请选择教室并输入门牌号：");
            var classroomNumber = Console.ReadLine();
            if (classroomNumber == "")
            {
                return null;
            }
            classroom = (from r in availableClassrooms
                         where r.Number == classroomNumber
                         select r).FirstOrDefault();
            return classroom;
        }
        /// <summary>
        /// 创建监考；
        /// </summary>
        /// <returns>监考</returns>
        public IInvigilator CreateInvigilator()
        {
            IInvigilator teacher = null;
            var availableTeachers = from t in TeacherRepository.GetAll()
                                    select t;
            Console.WriteLine("笔试可选监考人员有：");
            foreach (var availableTeacher in availableTeachers)
            {
                Console.WriteLine("工号：{0,-10}姓名：{1} ", availableTeacher.Number, availableTeacher.Name);
            }
            Console.Write("请选择监考人员并输入工号称：");
            var teacherNumber = Console.ReadLine();
            teacher = (from t in availableTeachers
                       where t.Number == teacherNumber
                       select t).FirstOrDefault();
            return teacher;
        }
        /// <summary>
        /// 创建考试
        /// </summary>
        /// <param name="courseName">课程名称</param>
        /// <returns>考试</returns>
        public IExamination CreateExamination(string courseName)
        {
            IExamination writtenExamination = null;
            Console.WriteLine("《{0}》笔试安排申报：", courseName);
            IExaminationRoom examinationRoom = this.CreateExaminationRoom();
            IInvigilator invigilator = this.CreateInvigilator();
            if (examinationRoom == null)
            {
                return null;
            }
            if (invigilator == null)
            {
                return null;
            }
            writtenExamination = new WrittenExamination()
            {
                CourseName = courseName,
                Room = examinationRoom,
                Invigilator = invigilator
            };
            return writtenExamination;
        }
    }
}
