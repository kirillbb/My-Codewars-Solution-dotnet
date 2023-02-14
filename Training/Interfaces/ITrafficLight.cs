using Training.Classes;

namespace Training.Interfaces
{
    internal interface ITrafficLight
    {
        bool IsAmberOn { get; }

        bool IsGreenOn { get; }
        
        bool IsRedOn { get; }
        
        void Set(State state);
    }
}
