using System.Collections.Generic;

namespace SmartLin.LearningCSharp.FactoryPattern
{
    /// <summary>
    /// 实验员仓储；
    /// </summary>
    public class LaboratoryStaffRepository
    {
        /// <summary>
        /// 获取所有；
        /// </summary>
        /// <returns>实验员</returns>
        public static List<LaboratoryStaff> GetAll()
        {
            List<LaboratoryStaff> laboratoryStaffs = new List<LaboratoryStaff>()
            {
               new LaboratoryStaff()
               {
                   Number="1996012",
                   Name="李胜旭"
               },
               new LaboratoryStaff()
               {
                   Number="2018121",
                   Name="黄焯"
               }
            };
            return laboratoryStaffs;
        }
    }
}
