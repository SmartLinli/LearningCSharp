using System;
using System.Linq;
using static System.Console;

namespace SmartLin.LearningCSharp.BuilderPattern
{
    /// <summary>
    /// 笔试建造者；
    /// </summary>
    public class WrittenExaminationBuilder : IExaminationBuilder
    {
        /// <summary>
        /// 笔试；
        /// </summary>
        public IExamination WrittenExamination => new WrittenExamination();
        /// <summary>
        /// 添加课程；
        /// </summary>
        public void AddCourse()
        {
            Course course = null;
            WriteLine("需要安排笔试的课程有：");
            var availableCourses = from c in CourseRepository.GetAll()
                                   select c;
            foreach (var availableCourse in availableCourses)
            {
                WriteLine($"课程号：{availableCourse.Number,-10}名称：{availableCourse.Name} ");
            }
            Write("请选择课程并输入课程号：");
            var courseNumber = ReadLine();
            if (courseNumber == "")
            {
                return;
            }
            course = (from c in availableCourses
                      where c.Number == courseNumber
                      select c)
                     .FirstOrDefault();
            this.WrittenExamination.Course = course;
        }
        /// <summary>
        /// 添加考场；
        /// </summary>
        public void AddRoom()
        {
            ClassRoom classroom = null;
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
                return;
            }
            classroom = (from r in availableClassrooms
                         where r.Number == classroomNumber
                         select r)
                        .FirstOrDefault();
            this.WrittenExamination.Room = classroom;
        }
        /// <summary>
        /// 添加监考；
        /// </summary>
        public void AddInvigilator()
        {
            Faculty teacher = null;
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
            this.WrittenExamination.Invigilator = teacher;
        }
        /// <summary>
        /// 建造；
        /// </summary>
        /// <returns>考试</returns>
        public IExamination Build()                                             //建造者可同时扮演指挥者，自行调用建造步骤；
        {
            this.AddCourse();
            this.AddRoom();
            this.AddInvigilator();
            return this.WrittenExamination;                                    //返回产品；
        }
    }
}
