using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartLin.LearningCSharp.Oop
{
    public class StudentRate : IRate<LearningTask>
    {
        //private LearningTask _Target;
        public LearningTask Target
        {
            get;
            set;
        }
        private bool _HasRated;
        public bool HasRated
        {
            get
            {
                return this._HasRated;
            }
        }
        public string RateStatus
        {
            get
            {
                string rateStatus = "";
                if (!this.HasRated)
                {
                    rateStatus = "未评教";
                }
                return rateStatus;
            }
        }
        private LearningStatus _LearningStatus;
        //private DateTime _ClosingDate;
        public DateTime OpeningDate
        {
            get;
            set;
        }
        public DateTime ClosingDate
        {
            get;
            set;
        }
        private string _Result;
        public string Result
        {
            get
            {
                return this._Result;
            }
        }
        private string _Warning;
        public string Warning
        {
            get
            {
                return this._Warning;
            }
        }
        public ValidationResult ValidateBeforeInput()
        {
            ValidationResult result = new ValidationResult();
            IValidator firstValidator = StudentRateValidatorBeforeInputFactory.Create(this);
            try
            {
                firstValidator.Check();
                result.Type = ResultType.OK;
            }
            catch (ValidationException ex)
            {
                result.Error = ex.Message;
                result.Type = ResultType.FAIL;
            }
            return result;
        }
        private string Input()
        {
            Console.Write("\t请输入评教成绩：");
            var input = Console.ReadLine();
            if (input == "")
            {
                throw new EmptyInputException();
            }
            return input;
        }
        private void Output(bool isValid, float rate)
        {
            if (isValid)
            {
                this._Result += "\t结果：评教成绩" + rate.ToString() + "已于" + DateTime.Now.ToLongDateString() + "成功保存。\n";
                this._HasRated = true;
                Console.Write(this.Result + this.Warning);
            }
            else
            {
                this._Result += "\t结果：无法保存" + rate.ToString() + "。\n";
                this._Warning = "\t警告：" + this.Warning + "\n";
                Console.Write(this.Result + this.Warning);
            }
        }
        public ValidationResult ValidateAfterInput()
        {
            ValidationResult result = new ValidationResult();

            return result;
        }
        public bool Save()
        {
            bool isValid = true;
            float rate = 0;
            this._Result = "";
            this._Warning = "";
            DateTime now = DateTime.Now;
            try
            {
                ValidatorBeforeInputRate preValidator = ValidatorBeforeInputRate.PreValidatorProvider(this._LearningStatus, this._ClosingDate);
                preValidator.Check();
                string input = this.Input();
                NumericFormatter numericFormatter = new NumericFormatter(input);
                rate = numericFormatter.Output();
                ValidatorAfterInput validator = ValidatorAfterInput.ValidatorProvider(rate);
                validator.Check();
            }
            catch (ValidationBeforeInputException ex)
            {
                isValid = false;
            }
            catch (EmptyInputException)
            {
                isValid = false;
                return isValid;
            }
            catch (ValidationException ex)
            {
                isValid = false;
                this._Warning += ex.Message;
            }
            finally
            {
                this.Output(isValid, rate);
            }
            //if (commentNeeded)
            {

            }
            /*若评教满分或不合格，则必须填写20字以上的评语*/
            /*大于4学分的课程为主干课程，必须填写20字以上的评语*/
            return isValid;
        }
        public StudentRate()
        {
            ;
        }
        //public StudentRate(LearningStatus learningStatus, DateTime closingDate)
        //{
        //    this._LearningStatus = learningStatus;
        //    this._ClosingDate = closingDate;
        //    this._Result = "";
        //    this._Warning = "";
        //}
        //public StudentRate(LearningTask learningTask, DateTime closingDate)
        //{
        //    this._Target = learningTask;
        //    this._ClosingDate = closingDate;
        //}
    }
    public class EmptyInputException : ApplicationException
    {
        public EmptyInputException()
            : base()
        {
            ;
        }
    }
}
