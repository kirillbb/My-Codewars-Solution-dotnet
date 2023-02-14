using Training.Interfaces;

namespace Training.Classes
{

    internal class TrafficLight : ITrafficLight
    {
        public bool IsAmberOn => state == State.RedAmber || state == State.Amber;

        public bool IsGreenOn => state == State.Green;

        public bool IsRedOn => state == State.Standby || state == State.Red || state == State.RedAmber;

        public void Set(State state) => this.state = state;

        private State state = State.Standby;
    }
}
