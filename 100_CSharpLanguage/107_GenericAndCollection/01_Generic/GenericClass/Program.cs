
namespace SmartLin.LearningCSharp.GenericTypeAndCollection
{
    class Program
    {
        static void Main()
        {
            SurveyQuestion<char> singleChoiceQuestion1 = new SurveyQuestion<char>();
            singleChoiceQuestion1.Question = "经过学习，你对面向对象程序设计有多少了解？A、不得要领 B、略懂一二 C、基本理解 D、熟练掌握";
            singleChoiceQuestion1.Answer = 'A';

            SurveyQuestion<string> multiChoiceQuestion1 = new SurveyQuestion<string>();
            multiChoiceQuestion1.Question = "你觉得最大的学习困难是什么？A、缺乏抽象思维 B、编程基础薄弱 C、缺少学习氛围 D、缺少实践机会";
            multiChoiceQuestion1.Answer = "AC";

            SurveyQuestion<int> numericQuestion3 = new SurveyQuestion<int>();
            numericQuestion3.Question = "你对目前学习效果打多少分？（0～10分）";
            numericQuestion3.Answer = 8;

            SurveyQuestion<bool> trueOrFalseQuestion4 = new SurveyQuestion<bool>();
            trueOrFalseQuestion4.Question = "若该课程为选修课，你还愿意选它吗？";
            trueOrFalseQuestion4.Answer = true;
        }
    }
}