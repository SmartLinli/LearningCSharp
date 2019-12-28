using System.Collections.Generic;

namespace SmartLin.LearningCSharp.Linq
{
    /// <summary>
    /// 教职工仓储；
    /// </summary>
    public static class FacultyRepository
    {
        /// <summary>
        /// 获取所有教职工；
        /// </summary>
        /// <returns>教职工</returns>
        public static List<Faculty> GetAllFaculties()
        {
            List<Faculty> facultiesOfAdministrationSchool = new List<Faculty>()
            {
                 new Faculty("2011044", "黄至辉") { PhoneNumber = "13328216089" }
                , new Faculty("1988012", "陈炜") { PhoneNumber = "13075940686" }
                , new Faculty("1989008", "刘闽碧") { PhoneNumber = "13706969310" } 
                , new Faculty("1988013", "林雨星") { PhoneNumber = "18950450594" }
                , new Faculty("2011031", "黄靖") { PhoneNumber = "13665038204" } 
                , new Faculty("2002002", "高玲") { PhoneNumber = "18905011588" }
                , new Faculty("2011011", "陈缘梅") { PhoneNumber = "18046064230" } 
                , new Faculty("2010049", "沈富儿") { PhoneNumber = "13675002566" }
                , new Faculty("2003031", "王小燕") { PhoneNumber = "15980665080" } 
                , new Faculty("2004042", "郭春珍") { PhoneNumber = "13860666035" }
                , new Faculty("2001015", "刘颖") { PhoneNumber = "13950281787" } 
                , new Faculty("2005054", "钟三宇") { PhoneNumber = "13960818388" }
                , new Faculty("1992018", "张青") { PhoneNumber = "13509353836" } 
                , new Faculty("2008019", "陈宪泽") { PhoneNumber = "13255050978" } 
                , new Faculty("1992012", "王建忠") { PhoneNumber = "13305002603" } 
                , new Faculty("2001018", "张翠萍") { PhoneNumber = "13960817800" }
                , new Faculty("2005003", "陈斯歆") { PhoneNumber = "15959188586" } 
            };
            return facultiesOfAdministrationSchool;
        }
    }
}
