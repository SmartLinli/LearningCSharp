using System;
using System.Reflection;

namespace SmartLin.LearningCSharp.FormAndControl
{
    /// <summary>
    /// 验证映射特性；
    /// 将本特性所应用的元素映射至指定的类型与属性，以便从指定属性进一步获取用于验证的特性；
    /// 还可通过消息控件名称，获取指定的消息控件，用于输出验证消息；
    /// </summary>
    [AttributeUsage(AttributeTargets.Field)]                                                //仅用于窗体内的控件字段；
    public class ValidationMappingAttribute : Attribute
    {
        /// <summary>
        /// 类型；
        /// </summary>
        public Type Type
        {
            get;
            set;
        }
        /// <summary>
        /// 属性；
        /// </summary>
        public PropertyInfo Property
        {
            get;
            set;
        }
        /// <summary>
        /// 消息控件名称；
        /// </summary>
        public string MessageControlName                                                    //特性的属性仅支持基本类型等类型；
        {
            get;
            set;
        }
        /// <summary>
        /// 构造函数；
        /// </summary>
        /// <param name="typeName"></param>
        /// <param name="propertyName"></param>
        public ValidationMappingAttribute(string typeName, string propertyName)
        {
            string namespaceName = MethodBase.GetCurrentMethod().DeclaringType.Namespace;
            this.Type = Type.GetType(namespaceName + "." + typeName);
            this.Property = this.Type.GetProperty(propertyName);
        }
    }
}
