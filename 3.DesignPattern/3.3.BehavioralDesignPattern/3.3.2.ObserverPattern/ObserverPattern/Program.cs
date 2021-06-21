using static System.Console;

namespace SmartLin.LearningCSharp.ObserverPattern
{
    class Program
    {
        static void Main()
        {            
            Student student = new Student("3180707001", "周林好");
            Faculty mrLin = new Faculty("2004034", "林立");
            mrLin.PhoneNumber = "13599055941";
            Score score = new Score(85.5m);
            SmsManager smsManager = new SmsManager();
            student.EvaluateEvent += score.Open;                        //为事件注册处理函数；事件不能通过=赋值，必须通过+=注册（订阅）；
            student.EvaluateEvent += smsManager.Inform;
            score.GetScore();
            student.Evaluate(mrLin);                                    //事件只能由类的方法来触发；
            score.GetScore();
            Read();
        }
    }
}
