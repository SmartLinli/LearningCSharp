using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace SmartLin.LearningCSharp.Installer
{
    /// <summary>
    /// XML课程仓储；
    /// </summary>
    public class XmlCourseRepository : IRepository<Course>
    {
        /// <summary>
        /// XML文件名；
        /// </summary>
        private const string _XmlFileName = @"Xml\Courses.xml";
        /// <summary>
        /// 查找所有；
        /// </summary>
        /// <returns>课程列表</returns>
        public List<Course> FindAll()
        {
            List<Course> courses = new List<Course>();
            XDocument xDocument = XDocument.Load(_XmlFileName);                                     //载入XML文档；
            var courseElements = from c in xDocument.Descendants("Course")                          //通过LINQ to XML查询XML文档中指定名称的所有元素；
                                 select c;
            foreach (var courseElement in courseElements)                                           //遍历所有元素；
            {
                Course course = new Course
                    (courseElement.Element("Number").Value                                          //获取当前元素的指定子元素的值；
                    , courseElement.Element("Name").Value
                    , decimal.Parse(courseElement.Element("Credit").Value));
                courses.Add(course);
            }
            /*尚未对各课程的其它属性赋值，仅用于展示课程名称列表；*/
            return courses;
        }
        /// <summary>
        /// 查找；
        /// </summary>
        /// <param name="number">编号</param>
        /// <returns>课程</returns>
        public Course FindBy(string number)
        {
            XDocument xDocument = XDocument.Load(_XmlFileName);
            var courseElement = (from c in xDocument.Descendants("Course")
                                 where c.Element("Number").Value == number
                                 select c)
                                 .FirstOrDefault<XElement>();
            if (courseElement == null)
            {
                return null;
            }
            List<string> formativeAssessments = new List<string>();
            courseElement
                .Element("FormativeAssessments")
                .Elements("FormativeAssessment")
                .ToList<XElement>()
                .ForEach(e => formativeAssessments.Add(e.Value));
            Course course = new Course
                (courseElement.Element("Number").Value
                , courseElement.Element("Name").Value
                , decimal.Parse(courseElement.Element("Credit").Value))
                {
                    TheoreticalHour = int.Parse(courseElement.Element("TheoreticalHour").Value),
                    IsAvailable = bool.Parse(courseElement.Element("IsAvailable").Value),
                    HasExperiment = bool.Parse(courseElement.Element("HasExperiment").Value),
                    HasMooc = bool.Parse(courseElement.Element("HasMooc").Value),
                    FormativeAssessments = formativeAssessments.ToArray<string>(),
                    Type = courseElement.Element("Type").Value,
                    LearningType = courseElement.Element("LearningType").Value,
                    AppraisalType = courseElement.Element("AppraisalType").Value,
                    AppraisalForm = courseElement.Element("AppraisalForm").Value
                };
            return course;
        }
        /// <summary>
        /// 更新；
        /// </summary>
        /// <param name="oldNumber">旧编号</param>
        /// <param name="course">课程</param>
        public void Update(string oldNumber, Course course)
        {
            XDocument xDocument = XDocument.Load(_XmlFileName);
            var courseElement = (from c in xDocument.Descendants("Course")
                                 where c.Element("Number").Value == oldNumber
                                 select c).FirstOrDefault<XElement>();
            courseElement.Element("Number").Value = course.Number;
            courseElement.Element("Name").Value = course.Name;
            courseElement.Element("Credit").Value = course.Credit.ToString();
            courseElement.Element("TotalHour").Value = course.TotalHour.ToString();
            courseElement.Element("TheoreticalHour").Value = course.TheoreticalHour.ToString();
            courseElement.Element("ExperimentalHour").Value = course.ExperimentalHour.ToString();
            courseElement.Element("IsAvailable").Value = course.IsAvailable.ToString();
            courseElement.Element("HasExperiment").Value = course.HasExperiment.ToString();
            courseElement.Element("HasMooc").Value = course.HasMooc.ToString();
            courseElement.Element("FormativeAssessments").RemoveAll();
            course
                .FormativeAssessments
                .ToList<string>()
                .ForEach
                (s => courseElement
                        .Element("FormativeAssessments")
                        .Add(new XElement("FormativeAssessment", s)));                              //向父元素添加子元素；
            courseElement.Element("Type").Value = course.Type.ToString();
            courseElement.Element("LearningType").Value = course.LearningType.ToString();
            courseElement.Element("AppraisalType").Value = course.AppraisalType.ToString();
            courseElement.Element("AppraisalForm").Value = course.AppraisalForm.ToString();
            xDocument.Save(_XmlFileName);                                                           //保存XML文档；
        }
    }
}
