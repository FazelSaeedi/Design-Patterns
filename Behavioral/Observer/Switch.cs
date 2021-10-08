namespace Design_Patterns.Behavioral.Observer
{
    public class Switch : Observable
    {
        private bool _state;

        public bool ChangeState
        {
            set
            {
                _state = value;
                NotifyAllObservers();
            }
            get { return _state; }
        }
    }
}
