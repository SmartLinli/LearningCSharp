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
        /// 选课事件；
        /// </summary>
        public event SelectCourseEventHandler SelectCourseEvent;                            //定义事件；事件即多播委托；事件必须定义在类内部；
        /// <summary>
        /// 触发选课事件；
        /// </summary>
        /// <param name="courseName">课程名称</param>
        private void OnSelectCourse(string courseName)
        {
			this.SelectCourseEvent?.Invoke(this, new SelectCourseEventArgs(courseName));    //触发事件，即调用多播委托中注册的所有事件处理函数；事件必须在类内部触发；还需根据需要创建事件参数；
		}
        /// <summary>
        /// 选课；
        /// </summary>
        private void SelectCourse()
        {
            WriteLine("请输入课程名称：");
            var courseName = ReadLine();
            this.OnSelectCourse(courseName);												//调用能触发事件的方法；
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
