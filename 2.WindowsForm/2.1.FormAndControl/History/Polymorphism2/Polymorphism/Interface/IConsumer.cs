
namespace SmartLin.LearningCSharp.Inheritance
{
    public interface IConsumer
    {
        decimal Balance
        {
            get;
            set;
        }
        decimal PayIn(decimal amount);
        decimal Consume(decimal amount);
    }
}
