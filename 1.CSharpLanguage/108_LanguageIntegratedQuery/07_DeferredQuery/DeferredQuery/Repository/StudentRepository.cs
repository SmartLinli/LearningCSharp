using System;
using System.Collections.Generic;

namespace SmartLin.LearningCSharp.Linq
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
        public static List<Student> GetAllStudents()
        {
            Major infomationManagement = new Major("信息管理与信息系统", "信管");
            Class im18 = new Class(infomationManagement, 2018);
            Major publicServiceAdministration = new Major("公共事业管理", "公管");
            Class psa18 = new Class(publicServiceAdministration, 2018);
            Major healthServiceAdministration = new Major("健康服务与管理", "健管");
            Class hsa18 = new Class(healthServiceAdministration, 2018);
            List<Course> coursesForIm = new List<Course>()
            {
                new Course("2060162","计算机科学导论",3f)
                ,new Course("2060316","面向对象程序设计",4.5f)
                ,new Course("2060241","计算机网络",4f)
            };
            List<Course> coursesForPsa = new List<Course>()
            {
                new Course("2060240","管理学基础",4f)
                ,new Course("2060243","财务管理学",3f)
                ,new Course("2060123","公共关系学",2f)
            };
            List<Course> coursesForHsa = new List<Course>()
            {
                new Course("2060240","管理学基础",4f)
                ,new Course("2070058","预防医学",2f)
                ,new Course("2060044","健康心理学",3f)
            };
            List<Student> studentsOfAdministrationSchool = new List<Student>()
            {
                new Student("3180707001", "周林好", Gender.FEMALE, new DateTime(2000, 4, 17), im18)
                    { LearningCourses = coursesForIm, Height = 149.8f, Weight = 38.7f, InstructorNumber = "2011044" }
                , new Student("3180707002", "林钦妹", Gender.FEMALE, new DateTime(1999, 10, 18), im18)
                    { LearningCourses = coursesForIm, Height = 157f, Weight = 43f, InstructorNumber = "2011044" }
                , new Student("3180707003", "胡方珍", Gender.FEMALE, new DateTime(2000, 1, 22), im18)
                    { LearningCourses = coursesForIm, Height = 160.1f, Weight = 47.5f, InstructorNumber = "2011044" }
                , new Student("3180707004", "谢永成", Gender.MALE, new DateTime(2000, 3, 2), im18)
                    { LearningCourses = coursesForIm, Height = 166.1f, Weight = 57.3f, InstructorNumber = "2011044" }
                , new Student("3180707005", "龙禹吉", Gender.FEMALE, new DateTime(1999, 8, 10), im18)
                    { LearningCourses = coursesForIm, Height = 151.6f, Weight = 51.4f, InstructorNumber = "1988012" }
                , new Student("3180707006", "陈雯婷", Gender.FEMALE, new DateTime(2000, 8, 24), im18)
                    { LearningCourses = coursesForIm, Height = 159.5f, Weight = 49.3f, InstructorNumber = "1988012" }
                , new Student("3180707007", "李乐健", Gender.MALE, new DateTime(2000, 7, 10), im18)
                    { LearningCourses = coursesForIm, Height = 173.6f, Weight = 76.7f, InstructorNumber = "1988012" }
                , new Student("3180707008", "李志杰", Gender.MALE, new DateTime(2001, 1, 14), im18)
                    { LearningCourses = coursesForIm, Height = 164.3f, Weight = 49.8f, InstructorNumber = "1988012" }
                , new Student("3180707009", "刘燕婷", Gender.FEMALE, new DateTime(2000, 9, 28), im18)
                    { LearningCourses = coursesForIm, Height = 159.9f, Weight = 56.8f, InstructorNumber = "1989008" }
                , new Student("3180707010", "梁婷", Gender.FEMALE, new DateTime(1999, 6, 12), im18)
                    { LearningCourses = coursesForIm, Height = 145.5f, Weight = 40.7f, InstructorNumber = "1989008" }
                , new Student("3180707011", "刘雪晴", Gender.FEMALE, new DateTime(2000, 7, 5), im18)
                    { LearningCourses = coursesForIm, Height = 156.2f, Weight = 42.4f, InstructorNumber = "1992012" }
                , new Student("3180707012", "关令勇", Gender.MALE, new DateTime(1999, 1, 5), im18)
                    { LearningCourses = coursesForIm, Height = 172.7f, Weight = 82.3f, InstructorNumber = "1989008" }
                , new Student("3180707013", "林燕婕", Gender.FEMALE, new DateTime(2000, 8, 7), im18)
                    { LearningCourses = coursesForIm, Height = 155.9f, Weight = 50.5f, InstructorNumber = "2001018" }
                , new Student("3180707014", "张海展", Gender.MALE, new DateTime(2000, 6, 14), im18)
                    { LearningCourses = coursesForIm, Height = 165.4f, Weight = 57f, InstructorNumber = "2001018" }
                , new Student("3180707015", "丁雅婷", Gender.FEMALE, new DateTime(2000, 4, 2), im18)
                    { LearningCourses = coursesForIm, Height = 156f, Weight = 56.3f, InstructorNumber = "2001018" }
                , new Student("3180708001", "袁建波", Gender.MALE, new DateTime(1999, 9, 20), psa18)
                    { LearningCourses = coursesForPsa, Height = 171.3f, Weight = 59.7f, InstructorNumber = "1989008" }
                , new Student("3180708002", "欧璐谣", Gender.FEMALE, new DateTime(1999, 12, 14), psa18)
                    { LearningCourses = coursesForPsa, Height = 155f, Weight = 49.2f, InstructorNumber = "1989008" }
                , new Student("3180708003", "贲筠斯", Gender.FEMALE, new DateTime(2000, 7, 10), psa18)
                    { LearningCourses = coursesForPsa, Height = 156.1f, Weight = 54.8f, InstructorNumber = "2011031" }
                , new Student("3180708004", "蓝侦衔", Gender.MALE, new DateTime(1999, 10, 30), psa18)
                    { LearningCourses = coursesForPsa, Height = 169.1f, Weight = 53.1f, InstructorNumber = "2011031" }
                , new Student("3180708005", "任紫钰", Gender.FEMALE, new DateTime(2000, 8, 13), psa18)
                    { LearningCourses = coursesForPsa, Height = 159.2f, Weight = 52.6f, InstructorNumber = "2002002" }
                , new Student("3180708007", "徐弢", Gender.MALE, new DateTime(1998, 1, 12), psa18)
                    { LearningCourses = coursesForPsa, Height = 177f, Weight = 58.5f, InstructorNumber = "2002002" }
                , new Student("3180708008", "张皓", Gender.MALE, new DateTime(2000, 11, 12), psa18)
                    { LearningCourses = coursesForPsa, Height = 167.7f, Weight = 85.4f, InstructorNumber = "2011011" }
                , new Student("3180708009", "朱阿琤", Gender.FEMALE, new DateTime(2000, 3, 11), psa18)
                    { LearningCourses = coursesForPsa, Height = 154.3f, Weight = 51.8f, InstructorNumber = "2011011" }
                , new Student("3180708010", "南睿星", Gender.MALE, new DateTime(1998, 11, 18), psa18)
                    { LearningCourses = coursesForPsa, Height = 166.1f, Weight = 70.3f, InstructorNumber = "2010049" }
                , new Student("3180708011", "程晓华", Gender.MALE, new DateTime(2000, 2, 4), psa18)
                    { LearningCourses = coursesForPsa, Height = 177.8f, Weight = 70.3f, InstructorNumber = "2003031" }
                , new Student("3180708012", "陈泽棣", Gender.MALE, new DateTime(1998, 8, 19), psa18)
                    { LearningCourses = coursesForPsa, Height = 169.3f, Weight = 56.2f, InstructorNumber = "2010049" }
                , new Student("3180708014", "黄惠迎", Gender.FEMALE, new DateTime(2000, 6, 20), psa18)
                    { LearningCourses = coursesForPsa, Height = 152.3f, Weight = 45.1f, InstructorNumber = "2005003" }
                , new Student("3180709001", "周俊文", Gender.MALE, new DateTime(1998, 5, 4), hsa18)
                    { LearningCourses = coursesForHsa, Height = 168.5f, Weight = 65f, InstructorNumber = "2004042" }
                , new Student("3180709002", "罗欣昊", Gender.MALE, new DateTime(2000, 6, 25), hsa18)
                    { LearningCourses = coursesForHsa, Height = 176.8f, Weight = 67f, InstructorNumber = "2004042" }
                , new Student("3180709003", "郑颖", Gender.FEMALE, new DateTime(2000, 7, 23), hsa18)
                    { LearningCourses = coursesForHsa, Height = 156.6f, Weight = 49f, InstructorNumber = "2001015" }
                , new Student("3180709004", "陈旭东", Gender.MALE, new DateTime(2000, 10, 19), hsa18)
                    { LearningCourses = coursesForHsa, Height = 171.5f, Weight = 49.5f, InstructorNumber = "2001015" }
                , new Student("3180709005", "徐希婷", Gender.FEMALE, new DateTime(2000, 6, 18), hsa18)
                    { LearningCourses = coursesForHsa, Height = 163.4f, Weight = 60f, InstructorNumber = "2005054" }
                , new Student("3180709006", "邱烽玉", Gender.FEMALE, new DateTime(1999, 8, 6), hsa18)
                    { LearningCourses = coursesForHsa, Height = 156.7f, Weight = 53.9f, InstructorNumber = "2005054" }
                , new Student("3180709007", "杨福顺", Gender.MALE, new DateTime(2000, 3, 16), hsa18)
                    { LearningCourses = coursesForHsa, Height = 171f, Weight = 62.7f, InstructorNumber = "1992018" }
                , new Student("3180707008", "陈佳铭", Gender.FEMALE, new DateTime(1999, 12, 8), hsa18)
                    { LearningCourses = coursesForHsa, Height = 166f, Weight = 59f, InstructorNumber = "1992018" }
                , new Student("3180709009", "廖望", Gender.FEMALE, new DateTime(2000, 11, 18), hsa18)
                    { LearningCourses = coursesForHsa, Height = 161.1f, Weight = 56.1f, InstructorNumber = "2008019" }
            };
            return studentsOfAdministrationSchool;
        }
    }
}
