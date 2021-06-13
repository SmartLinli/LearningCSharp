using System;
using System.Linq;
using static System.Console;

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
            Write("请输入笔试人数：");
            var examineeCount = int.Parse(ReadLine());
            var availableClassrooms = from c in ClassRoomRepository.GetAll()
                                      where c.SeatAmount > examineeCount * 2 + 10
                                      orderby c.SeatAmount, c.Number
                                      select c;
            Write("符合人数要求的教室有：");
            foreach (var availableClassroom in availableClassrooms)
            {
                Write($"{availableClassroom.Number}（被占用星期：{availableClassroom.OccupiedWeekDay}） ");
            }
            Write($"{Environment.NewLine}请选择教室并输入门牌号：");
            var classroomNumber = ReadLine();
            if (classroomNumber == "")
            {
                return null;
            }
            classroom = (from r in availableClassrooms
                         where r.Number == classroomNumber
                         select r)
                         .FirstOrDefault();
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
            WriteLine("笔试可选监考人员有：");
            foreach (var availableTeacher in availableTeachers)
            {
                WriteLine($"工号：{availableTeacher.Number,-10}姓名：{availableTeacher.Name} ");
            }
            Write("请选择监考人员并输入工号称：");
            var teacherNumber = ReadLine();
            teacher = (from t in availableTeachers
                       where t.Number == teacherNumber
                       select t)
                       .FirstOrDefault();
            return teacher;
        }
    }
}
