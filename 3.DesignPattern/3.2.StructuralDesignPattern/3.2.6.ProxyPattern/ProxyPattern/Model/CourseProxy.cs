using static System.Console;

namespace SmartLin.LearningCSharp.ProxyPattern
{
    /// <summary>
    /// 课程代理；
    /// </summary>
    public class CourseProxy : ICourse                              //代理角色宜与真实角色继承统一基类（抽象类）或接口；
    {
        /// <summary>
        /// 课程；
        /// </summary>
        private ICourse _Course;                                    //引用真实对象；
        /// <summary>
        /// 课程号；
        /// </summary>
        public string Number { get; set; }
        /// <summary>
        /// 名称；
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 学分；
        /// </summary>
        public float Credit { get; set; }
        /// <summary>
        /// 更新前；
        /// </summary>
        private void BeforeUpdate()
        {
            WriteLine($"课程修改前：{this._Course.Number}《{this._Course.Name}》（{this._Course.Credit}）已备份。");
        }
        /// <summary>
        /// 更新后；
        /// </summary>
        private void AfterUpdate()
        {
            WriteLine($"课程修改后：{this._Course.Number}《{this._Course.Name}》（{this._Course.Credit}）已记录日志。");
        }
        /// <summary>
        /// 更新；
        /// </summary>
        public void Update()
        {
            this.BeforeUpdate();
            this._Course.Update();                                  //调用真实对象的方法；
            this.AfterUpdate();
        }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="course">课程</param>
        public CourseProxy(ICourse course)
        {
            this._Course = course;
        }
    }
}
