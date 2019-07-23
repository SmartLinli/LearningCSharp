using System;
using System.Reflection;
using System.Windows.Forms;

namespace SmartLin.LearningCSharp.FormAndControl
{
    /// <summary>
    /// 验证服务；
    /// </summary>
    public class ValidationService
    {
        /// <summary>
        /// 获取验证映射特性；
        /// </summary>
        /// <typeparam name="C">控件类型</typeparam>
        /// <param name="form">窗体</param>
        /// <param name="control">控件</param>
        /// <returns>验证映射特性</returns>
        private static ValidationMappingAttribute GetValidationMappingAttribute<C>(Form form, C control) where C : Control
        {
            var formType = form.GetType();                                                          //获取窗体的类型；
            var controlField =
                formType.GetField                                                                   //从窗体类型中，根据控件名称，获取控件所在字段；
                    (control.Name
                    , BindingFlags.NonPublic | BindingFlags.Instance);                              //查找标志为非公有（控件字段一般为私有）、实例；
            var validationMappingAttribute =
                controlField.GetCustomAttributes                                                    //从控件所在字段获取验证映射特性；
                    (typeof(ValidationMappingAttribute), false)[0]
                as ValidationMappingAttribute;
            return validationMappingAttribute;
        }
        /// <summary>
        /// 获取用于输出验证消息的控件；
        /// </summary>
        /// <typeparam name="C">控件类型</typeparam>
        /// <param name="form">窗体</param>
        /// <param name="control">控件</param>
        /// <returns>控件</returns>
        private static Control GetMessageControl<C>(Form form, C control) where C : Control
        {
            var formType = form.GetType();                                                          //获取窗体的类型；
            var validationMappingAttribute = GetValidationMappingAttribute(form, control);          //获取验证映射特性；
            var messageControlField =
                formType.GetField                                                                   //从窗体类型中，根据消息控件的名称，获取用于显示验证消息的控件所在字段；
                    (validationMappingAttribute.MessageControlName
                    , BindingFlags.NonPublic | BindingFlags.Instance);
            var messageControl =
                messageControlField.GetValue(form)                                                  //获取显示验证消息的控件；
                as Control;
            return messageControl;
        }
        /// <summary>
        /// 获取验证特性；
        /// </summary>
        /// <typeparam name="C">控件类型</typeparam>
        /// <param name="form">窗体</param>
        /// <param name="control">控件</param>
        /// <returns>验证特性</returns>
        private static IValidationAttribute GetValidationAttribute<C>(Form form, C control) where C : Control
        {
            var validationMappingAttribute = GetValidationMappingAttribute(form, control);          //获取验证映射特性；
            var validateTargtProperty = validationMappingAttribute.Property;                        //从验证映射特性获取控件对应的验证目标属性；
            var currentNamespace =
                MethodBase.GetCurrentMethod().DeclaringType.Namespace;                              //获取当前命名空间；
            var validationAttributeTypeName =
                validateTargtProperty.PropertyType.Name;                                            //获取验证目标属性的类型的名称；
            validationAttributeTypeName =
                currentNamespace + "." + validationAttributeTypeName + "ValidationAttribute";       //获取验证特性的完整类型名称；
            var validationAttributeType =
                Type.GetType(validationAttributeTypeName);                                          //根据验证特性的完整类型名称，获取验证特性的类型；
            var validationAttribute =
                validateTargtProperty.GetCustomAttributes                                           //从验证目标属性中，根据验证特性的类型，获取自定义特性；
                    (validationAttributeType, false)[0]
                as IValidationAttribute;                                                            //将自定义特性转为验证特性接口；
            return validationAttribute;
        }
        /// <summary>
        /// 获取控件内容；
        /// </summary>
        /// <param name="control">控件</param>
        /// <returns>内容</returns>
        private static object GetControlContent(Control control)
        {
            object controlContent = control.Text;                                                   //默认获取控件文本；
            if (control is NumericUpDown numericUpDown)                                             //若控件为数值增减框；
            {
                controlContent = numericUpDown.Value;												//则获取数值增减框的值；
            }
            return controlContent;
        }
        /// <summary>
        /// 验证控件；
        /// </summary>
        /// <typeparam name="C">控件类型</typeparam>
        /// <param name="form">窗体</param>
        /// <param name="control">控件</param>  
        public static void ValidateControl<C>(Form form, C control) where C : Control               //约束类型参数必须为控件；
        {
            var validationAttribute = GetValidationAttribute(form, control);                        //获取验证特性；
            var messageControl = GetMessageControl(form, control);                                  //获取用于输出验证消息的控件；
            var controlContent = GetControlContent(control);                                        //获取控件内容；
            try
            {
                validationAttribute.Validate(controlContent);                                       //验证控件内容；
                messageControl.Text = "";                                                           //设置验证消息；
            }
            catch (ApplicationException ex)
            {
                messageControl.Text = ex.Message;
                throw ex;
            }
        }
    }
}