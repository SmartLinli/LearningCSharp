using System.Collections.Generic;

namespace SmartLin.LearningCSharp.FactoryPattern
{
    /// <summary>
    /// 机房仓储；
    /// </summary>
    public class LaboratoryRepository
    {
        /// <summary>
        /// 获取所有；
        /// </summary>
        /// <returns>机房</returns>
        public static List<Laboratory> GetAll()
        {
            List<Laboratory> rooms = new List<Laboratory>()
            {
               new Laboratory()
               {
                   Number = "1318",
                   SeatAmount = 80,
                   HasClapboard = false
               },
               new Laboratory()
               {
                   Number = "1313B",
                   SeatAmount = 80,
                   HasClapboard = true
               },
               new Laboratory()
               {
                   Number = "1313A",
                   SeatAmount = 120,
                   HasClapboard = true
               }
            };
            return rooms;
        }
    }
}
