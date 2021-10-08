using System.Collections.Generic;

namespace Design_Patterns.Behavioral.Observer
{
    public class Observable
    {
        private readonly List<Observer> _observers = new List<Observer>();

        public void Attach(Observer observer)
        {
            _observers.Add(observer);
        }
        public void Dettach(Observer observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyAllObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update();
            }
        }
    }

}
