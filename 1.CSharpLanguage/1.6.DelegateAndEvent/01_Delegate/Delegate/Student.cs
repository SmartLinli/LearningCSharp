using static System.Console;

namespace SmartLin.LearningCSharp.DelegateAndEvent
{
    /// <summary>
    /// 学生；
    /// </summary>
    public class Student
    {
        /// <summary>
        /// 学号；
        /// </summary>
        public string Number
        {
            get;
            private set;
        }
        /// <summary>
        /// 姓名；
        /// </summary>
        public string Name
        {
            get;
            set;
        }
        /// <summary>
        /// 手机号码；
        /// </summary>
        public string PhoneNumber
        {
            get;
            set;
        }
        /// <summary>
        /// 选课后续；
        /// </summary>
        public AfterSelectCourseDelegate AfterSelectCourse                  //定义委托对象；
        {
            get;
            set;
        }
        /// <summary>
        /// 选课；
        /// </summary>
        private void SelectCourse()
        {
            WriteLine("请输入课程名称：");
            var courseName = ReadLine();
            if (this.AfterSelectCourse != null)                             //若委托对象非空；
            {
                this.AfterSelectCourse(this, courseName);                   //执行委托，并按委托签名提供参数；多播委托将依次调用各个函数，但只能返回最后1个函数的结果；
            }
        }
        /// <summary>
        /// 评教；
        /// </summary>
        private void Evaluate()
        {
            WriteLine("请输入评教分数：");
            ReadLine();
        }
        /// <summary>
        /// 显示菜单；
        /// </summary>
        public void ShowMenu()
        {
            WriteLine("教务系统学生端菜单：\n1、选课\n2、评教");
            var input = int.Parse(ReadLine());
            switch (input)
            {
                case 1:
                    {
                        this.SelectCourse();
                    }
                    break;
                case 2:
                    {
                        this.Evaluate();
                    }
                    break;
                default:
                    break;
            }
        }
        /// <summary>
        /// 构造函数；
        /// </summary>
        /// <param name="number">学号</param>
        /// <param name="name">姓名</param>
        public Student(string number, string name)
        {
            this.Number = number;
            this.Name = name;
        }

    }
}
