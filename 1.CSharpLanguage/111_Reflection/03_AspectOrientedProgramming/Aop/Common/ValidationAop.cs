using System;
using System.Runtime.Remoting.Messaging;

namespace SmartLin.LearningCSharp.Reflection
{
    /// <summary>
    /// 基于面向切面的验证；
    /// </summary>
    public class ValidationAop : IMessageSink                                                   //实现IMessageSink接口，用于消息接收器；
    {
        /// <summary>
        /// 连接到消息接收器的对象；
        /// </summary>
        private MarshalByRefObject _Object;
        /// <summary>
        /// 当前特性；
        /// </summary>
        private Attribute _CurrentAttribute;
        /// <summary>
        /// 接收器链中的下一个消息接收器；
        /// </summary>
        private IMessageSink _NextSink;
        public IMessageSink NextSink
        {
            get
            {
                return this._NextSink;
            }
        }
        /// <summary>
        /// 调用方法前验证；
        /// </summary>
        /// <param name="msg">消息</param>
        public void ValidateBeforeMethod(IMessage message)
        {
            StringValidationAttribute validator =                                               //将当前的方法特性转为验证器；
                this._CurrentAttribute as StringValidationAttribute;
            IMethodCallMessage callMessage = message as IMethodCallMessage;                     //获取方法调用消息；            
            object[] newValues = callMessage.Args;                                              //获取方法的参数集合；
            foreach (object newValue in newValues)                                              //遍历参数；
            {
                try
                {
                    validator.Validate(newValue as string);                                     //执行验证；
                }
                catch (ApplicationException)
                {
                    throw;
                }
            }
        }
        /// <summary>
        /// 调用方法后；
        /// </summary>
        /// <param name="message">消息</param>
        public void AfterMethod(IMessage message)
        {
            IMethodReturnMessage returnMessage = message as IMethodReturnMessage;				//获取方法返回值消息；
        }
        /// <summary>
        /// 同步处理消息；
        /// </summary>
        /// <param name="message">消息</param>
        /// <returns>答复消息</returns>
        public IMessage SyncProcessMessage(IMessage message)
        {
            IMessage nextMessage = null;
            IMethodCallMessage callMessage = message as IMethodCallMessage;
            Attribute stringValidationAttribute =                                               //从消息中的方法获取指定特性；
                Attribute.GetCustomAttribute
                (callMessage.MethodBase, typeof(StringValidationAttribute));
            if (callMessage == null || stringValidationAttribute == null)
            {
                nextMessage = this.NextSink.SyncProcessMessage(message);                        //下一条消息；
            }
            else
            {
                this._CurrentAttribute = stringValidationAttribute;
                ValidateBeforeMethod(message);
                nextMessage = this.NextSink.SyncProcessMessage(message);
                AfterMethod(nextMessage);
            }
            return nextMessage;
        }
        /// <summary>
        /// 异步处理消息；
        /// </summary>
        /// <param name="msg">消息</param>
        /// <param name="replySink">答复消息接收器</param>
        /// <returns>控制消息方法</returns>
        public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink)
        {
            throw new NotImplementedException();                                                //未实现；
        }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="obj">连接到消息接收器的对象</param>
        /// <param name="nextSink">消息接收器</param>
        public ValidationAop(MarshalByRefObject obj, IMessageSink nextSink)
        {
            this._Object = obj;
            this._NextSink = nextSink;
        }
    }
}