using System.Collections.Generic;

namespace SmartLin.LearningCSharp.CompositePattern
{
    /// <summary>
    /// 学生仓储；
    /// </summary>
    public static class StudentRepository
    {
        /// <summary>
        /// 获取所有学生；
        /// </summary>
        /// <returns>学生</returns>
        public static List<Student> GetAll()
        {
            List<Student> students = new List<Student>()
            {
                new StudentCadre("3180707001", "周林好")
                    { Department = "学院团委", Duty = "副书记" }
                , new StudentCadre("3180707002", "林钦妹")
                    { Department = "学院学生会", Duty = "主席" }
                , new StudentCadre("3180707003", "胡方珍")
                    { Department = "学院学生会", Duty = "副主席" }
                , new StudentCadre("3180707004", "谢永成")
                    { Department = "学院学生会", Duty = "副主席" }
                , new StudentCadre("3180707005", "龙禹吉")
                    { Department = "学院学生会", Duty = "副主席" }
                , new StudentStaff("3180707006", "陈雯婷")
                , new StudentStaff("3180707007", "李乐健")
                , new StudentStaff("3180707008", "李志杰")
                , new StudentStaff("3180707009", "刘燕婷")
                , new StudentStaff("3180707010", "梁婷")
                , new StudentCadre("3180708001", "袁建波")
                    { Department = "组织部", Duty = "部长" }
                , new StudentCadre("3180708002", "欧璐谣")
                    { Department = "学习部", Duty = "部长" }
                , new StudentCadre("3180708003", "贲筠斯")
                    { Department = "宣传部", Duty = "部长" }
                , new StudentCadre("3180708004", "蓝侦衔")
                    { Department = "外联部", Duty = "部长" }
                , new StudentCadre("3180708005", "任紫钰")
                    { Department = "生活部", Duty = "部长" }
                , new StudentStaff("3180708007", "徐弢")
                , new StudentStaff("3180708008", "张皓")
                , new StudentStaff("3180708009", "朱阿琤")
                , new StudentStaff("3180708010", "南睿星")
                , new StudentStaff("3180708011", "程晓华")
                , new StudentCadre("3180708012", "陈泽棣")
                    { Department = "体育部", Duty = "部长" }
                , new StudentCadre("3180708014", "黄惠迎")
                    { Department = "文艺部", Duty = "部长" }
                , new StudentCadre("3180709001", "周俊文")
                    { Department = "女生部", Duty = "部长" }
                , new StudentCadre("3180709002", "罗欣昊")
                    { Department = "权益部", Duty = "部长" }
                , new StudentCadre("3180709003", "郑颖")
                    { Department = "社团联合会", Duty = "秘书长" }
                , new StudentStaff("3180709004", "陈旭东")
                , new StudentStaff("3180709005", "徐希婷")
                , new StudentStaff("3180709006", "邱烽玉")
                , new StudentStaff("3180709007", "杨福顺")
                , new StudentStaff("3180707008", "陈佳铭")
                , new StudentStaff("3180709009", "廖望") 
            };
            ((StudentCadre)students[0]).Add(students[1]);                                   //向各节点添加子节点或叶节点；

            ((StudentCadre)students[1]).Add(students[2]);
            ((StudentCadre)students[1]).Add(students[3]);
            ((StudentCadre)students[1]).Add(students[4]);

            ((StudentCadre)students[2]).Add(students[10]);
            ((StudentCadre)students[2]).Add(students[11]);
            ((StudentCadre)students[2]).Add(students[12]);
            ((StudentCadre)students[3]).Add(students[13]);
            ((StudentCadre)students[3]).Add(students[14]);
            ((StudentCadre)students[3]).Add(students[20]);
            ((StudentCadre)students[4]).Add(students[21]);
            ((StudentCadre)students[4]).Add(students[22]);
            ((StudentCadre)students[4]).Add(students[23]);
            ((StudentCadre)students[4]).Add(students[24]);

            ((StudentCadre)students[10]).Add(students[5]);
            ((StudentCadre)students[10]).Add(students[6]);
            ((StudentCadre)students[11]).Add(students[7]);
            ((StudentCadre)students[11]).Add(students[8]);
            ((StudentCadre)students[12]).Add(students[9]);
            ((StudentCadre)students[13]).Add(students[15]);
            ((StudentCadre)students[14]).Add(students[16]);
            ((StudentCadre)students[14]).Add(students[17]);
            ((StudentCadre)students[20]).Add(students[18]);
            ((StudentCadre)students[20]).Add(students[19]);
            ((StudentCadre)students[21]).Add(students[25]);
            ((StudentCadre)students[22]).Add(students[26]);
            ((StudentCadre)students[22]).Add(students[27]);
            ((StudentCadre)students[23]).Add(students[28]);
            ((StudentCadre)students[24]).Add(students[29]);
            ((StudentCadre)students[24]).Add(students[30]);
            return students;
        }
    }
}
