using System;
using System.Linq;

namespace SmartLin.LearningCSharp.FactoryPattern
{
    /// <summary>
    /// 上机考试抽象工厂；
    /// </summary>
    public class ComputerExaminationAbstractFactory : IExaminationAbstractFactory
    {
        /// <summary>
        /// 创建考场；
        /// </summary>
        /// <returns>考场</returns>
        public IExaminationRoom CreateExaminationRoom()
        {
            IExaminationRoom laboratory = null;
            Console.Write("请输入上机考试人数：");
            var examineeCount = int.Parse(Console.ReadLine());
            var availableLaboratorys = from l in LaboratoryRepository.GetAll()
                                       where
                                            (l.HasClapboard && l.SeatAmount > examineeCount + 5)
                                            || (!l.HasClapboard && l.SeatAmount > examineeCount * 2 + 10)
                                       orderby l.SeatAmount, l.Number
                                       select l;
            Console.Write("上机考试可用机房有：");
            foreach (var availableLaboratory in availableLaboratorys)
            {
                Console.Write("{0} ", availableLaboratory.Number);
            }
            Console.Write("\n请选择机房并输入门牌号：");
            var laboratoryNumber = Console.ReadLine();
            laboratory = (from r in availableLaboratorys
                          where r.Number == laboratoryNumber
                          select r).FirstOrDefault();
            return laboratory;
        }
        /// <summary>
        /// 创建监考；
        /// </summary>
        /// <returns>监考</returns>
        public IInvigilator CreateInvigilator()
        {
            IInvigilator laboratoryStaff = null;
            var availableLaboratoryStaffs = from l in LaboratoryStaffRepository.GetAll()
                                            select l;
            Console.WriteLine("上机考试可选监考人员有：");
            foreach (var availableLaboratoryStaff in availableLaboratoryStaffs)
            {
                Console.WriteLine("工号：{0,-10}姓名：{1} ", availableLaboratoryStaff.Number, availableLaboratoryStaff.Name);
            }
            Console.Write("请选择监考人员并输入工号：");
            var laboratoryStaffNumber = Console.ReadLine();
            laboratoryStaff = (from l in availableLaboratoryStaffs
                               where l.Number == laboratoryStaffNumber
                               select l).FirstOrDefault();
            return laboratoryStaff;
        }
    }
}
