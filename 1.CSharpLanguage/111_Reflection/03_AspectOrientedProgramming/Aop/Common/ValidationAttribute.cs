using System;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;

namespace SmartLin.LearningCSharp.Reflection
{
    /// <summary>
    /// 验证特性；
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]                                                        //该特性仅用于类；
    public class ValidationAttribute : ContextAttribute, IContributeObjectSink                      //继承ContextAttribute类；实现IContributeObjectSink接口，用于向远程访问的程序发送消息；
    {
        /// <summary>
        /// 构造函数；
        /// </summary>
        public ValidationAttribute(string className)
            : base(className)
        {
            ;
        }
        /// <summary>
        /// 将对象的消息接收器连接到给定的消息接收器链；
        /// </summary>
        /// <param name="obj">连接到消息接收器的对象</param>
        /// <param name="nextSink">消息接收器</param>
        /// <returns>消息接收器</returns>
        public IMessageSink GetObjectSink(MarshalByRefObject obj, IMessageSink nextSink)            //实现IContributeObjectSink接口的方法；
        {
            return new ValidationAop(obj, nextSink);
        }

    }
}
