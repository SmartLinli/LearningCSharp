using System;

namespace SmartLin.LearningCSharp.GenericTypeAndCollection
{
    /// <summary>
    /// 分页服务；
    /// </summary>
    public static class PagingService
    {
        /// <summary>
        /// 获取数组的分页；
        /// </summary>
        /// <typeparam name="T">数组元素的类型</typeparam>
        /// <param name="array">要分页的数组</param>
        /// <param name="pageSize">分页大小</param>
        /// <param name="pageNumber">目标页的页码</param>
        /// <returns>目标页元素构成的新数组</returns>
        public static T[] GetPage<T>(this T[] array, int pageSize, int pageNumber)                      //定义泛型方法；
        {
            int
                maxPageNumber,                                                                          //最大页码；
                targetPageStartIndex,                                                                   //目标页中的元素的起始序号；
                targetPageEndIndex,                                                                     //目标页中的元素的终止序号；
                targetPageSize;                                                                         //目标页大小；
            maxPageNumber = (int)Math.Ceiling((double)array.Length / pageSize);
            targetPageStartIndex = pageSize * (pageNumber - 1);
            if (pageNumber == maxPageNumber)
                targetPageEndIndex = array.Length - 1;
            else
                targetPageEndIndex = targetPageStartIndex + pageSize - 1;
            targetPageSize = targetPageEndIndex - targetPageStartIndex + 1;
            T[] currentPageArray = new T[targetPageSize];
            for (int i = 0, j = targetPageStartIndex; j <= targetPageEndIndex; i++, j++)
            {
                currentPageArray[i] = array[j];
            }
            return currentPageArray;
        }
    }
}
