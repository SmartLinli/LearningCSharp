using SmartLin.LearningCSharp.ClassAndObject.Model;                                             //对项目默认命名空间以外的资源访问，可通过添加调用获得便利；

namespace SmartLin.LearningCSharp.ClassAndObject.Model                                          //向文件夹添加的类，所在命名空间默认为项目默认命名空间+文件夹路径；
{
    /// <summary>
    /// 专业；
    /// </summary>
    public class Major
    {
        /// <summary>
        /// 名称；
        /// </summary>
        public string Name
        {
            get;
            private set;
        }
        /// <summary>
        /// 简称；
        /// </summary>
        public string ShortName
        {
            get;
            private set;
        }
        /// <summary>
        /// 构造函数；
        /// </summary>
        /// <param name="name">名称</param>
        /// <param name="shortName">简称</param>
        public Major(string name, string shortName)
        {
            this.Name = name;
            this.ShortName = shortName;
        }
    }
}
