namespace SmartLin.LearningCSharp.GenericTypeAndCollection
{
    /// <summary>
    /// 分页服务；
    /// </summary>
    public static class PagingService
    {
        /// <summary>
        /// 获取页；
        /// </summary>
        /// <typeparam name="T">数组类型</typeparam>
        /// <param name="array">数组</param>
        /// <param name="pageSize">分页大小</param>
        /// <param name="pageNumber">目标页的页码</param>
        /// <returns>数组</returns>
        public static T[] GetPage<T>(T[] array, int pageSize, int pageNumber)                           //定义泛型方法；
        {

            int
                maxPageNumber = 0,                                                                      //最大页码；
                 targetPageStartIndex = 0,                                                              //目标页中的数组元素的起始序号；
                 targetPageEndIndex = 0,                                                                //目标页中的数组元素的终止序号；
                 targetPageSize = 0;                                                                    //目标页大小；
            maxPageNumber = array.Length / pageSize + 1;
            targetPageStartIndex = pageSize * (pageNumber - 1);
            if (pageNumber == maxPageNumber)
            {
                targetPageEndIndex = targetPageStartIndex + (array.Length - targetPageStartIndex - 1);
            }
            else
            {
                targetPageEndIndex = targetPageStartIndex + pageSize - 1;
            }
            targetPageSize = targetPageEndIndex - targetPageStartIndex + 1;
            T[] subArray = new T[targetPageSize];
            for (int i = 0, j = targetPageStartIndex; j <= targetPageEndIndex; i++, j++)
            {
                subArray[i] = array[j];
            }
            return subArray;
        }
    }
}
