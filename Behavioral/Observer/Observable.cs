using System.Collections.Generic;
using System.Linq;

namespace Design_Patterns.Behavioral.Observer
{
    public class Observable
    {
        private readonly List<Observer> _observers = new List<Observer>();

        public void Attach(Observer observer)
        {
            if(!_observers.Contains(observer))
                _observers.Add(observer);
        }

        public void AttachList(List<Observer> observers)
        {
            _observers.AddRange(observers?.Except(_observers));
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
