using System;
using System.Collections.Generic;

namespace SmartLin.LearningCSharp.BuilderPattern
{
    /// <summary>
    /// 教室仓储；
    /// </summary>
    public class ClassRoomRepository
    {
        /// <summary>
        /// 获取所有；
        /// </summary>
        /// <returns>教室</returns>
        public static List<ClassRoom> GetAll()
        {
            List<ClassRoom> rooms = new List<ClassRoom>()
            {               
                   new ClassRoom()
                   {
                       Number = "1402",
                       SeatAmount = 60,
                       OccupiedWeekDay = DayOfWeek.Monday
                   },
                   new ClassRoom()
                   {
                       Number = "1410",
                       SeatAmount = 120,
                       OccupiedWeekDay = DayOfWeek.Wednesday
                   },
                   new ClassRoom()
                   {
                       Number = "1310",
                       SeatAmount = 150,
                       OccupiedWeekDay = DayOfWeek.Friday
                   }
            };
            return rooms;
        }
    }
}