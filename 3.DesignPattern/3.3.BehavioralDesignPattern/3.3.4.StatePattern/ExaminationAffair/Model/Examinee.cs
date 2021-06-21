using System;
using static System.Console;

namespace ExaminationAffair
{
    /// <summary>
    /// 状态；
    /// </summary>
    public enum State
    {
        NORMAL,                                    //正常；
        RESIT,                                     //补考；
        RETAKING,                                  //重修；
        PASSED,                                    //及格；
    }
    /// <summary>
    /// 考生；
    /// </summary>
    public class Examinee : Student
    {
        /// <summary>
        /// 状态；
        /// </summary>
        public State State { get; private set; }
        /// <summary>
        /// 成绩
        /// </summary>
        public decimal Score { get; set; }
        /// <summary>
        /// 是否及格； 
        /// </summary>
        public bool IsPassed
        =>  this.Score >= 60;
        /// <summary>
        /// 评分；
        /// </summary>
        /// <param name="score">成绩</param>
        public void Grading(decimal score)
        {
            this.Score = score;
            switch (this.State)
            {
                case State.NORMAL:
                    {
                        WriteLine($"考生{this.Name}：考试{(this.IsPassed ? "已" : "未")}及格{(this.IsPassed ? "" : "，应参加补考")}。");
                        this.State = this.IsPassed ? State.PASSED : State.RESIT;
                    }
                    break;
                case State.RESIT:
                    {
                        WriteLine($"考生{this.Name}：补考{(this.IsPassed ? "已" : "未")}及格{(this.IsPassed ? "" : "，应参加重修")}。");
                        this.State = this.IsPassed ? State.PASSED : State.RETAKING;
                    }
                    break;
                case State.RETAKING:
                    {
                        WriteLine($"考生{this.Name}：重修{(this.IsPassed ? "已" : "未")}及格{(this.IsPassed ? "" : "，应继续参加重修")}。");
                        this.State = this.IsPassed ? State.PASSED : State.RETAKING;
                    }
                    break;
                case State.PASSED:
                    {
                        throw new ApplicationException($"考生{this.Name}已及格！");
                    }
                default:
                    break;
            }
        }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="number">学号</param>
        /// <param name="name">姓名</param>
        public Examinee(string number, string name)
            : base(number, name)
        {
            this.State = State.NORMAL;
        }
    }
}
