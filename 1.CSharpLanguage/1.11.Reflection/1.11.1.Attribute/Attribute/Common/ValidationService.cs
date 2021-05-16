namespace SmartLin.LearningCSharp.Reflection
{
    /// <summary>
    /// 验证服务；
    /// </summary>
    public class ValidationService
    {
        /// <summary>
        /// 验证；
        /// </summary>
        /// <typeparam name="T">对象类型</typeparam>
        /// <param name="obj">对象</param> 
        public static void Validate<T>(T obj)
        {
            var type = obj.GetType();                                                               //获取对象的类型；
            var properties = type.GetProperties();                                                  //获取类型的所有属性；
            foreach (var property in properties)                                                    //遍历所有属性；
            {
                var attributes = property.GetCustomAttributes(false);                               //获取属性的所有自定义特性；
                foreach (var attribute in attributes)                                               //遍历所有自定义特性；
                {
                    if (attribute is IValidationAttribute validator)                                //若特性是验证特性，则将特性转为验证特性；
					{                        
                        var propertyValue = property.GetValue(obj, null);                           //获取属性的值；
                        validator.Validate(propertyValue);                                          //验证属性的值；
                    }
                }
            }
        }
    }
}
