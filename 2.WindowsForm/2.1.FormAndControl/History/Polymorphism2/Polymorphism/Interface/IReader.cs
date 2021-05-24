
namespace SmartLin.LearningCSharp.Inheritance
{
    public interface IReader
    {
        int QuantityLimit
        {
            get;
            set;
        }
        int TimeLimit
        {
            get;
            set;
        }
        void Borrow();
        void Return();
    }
}
