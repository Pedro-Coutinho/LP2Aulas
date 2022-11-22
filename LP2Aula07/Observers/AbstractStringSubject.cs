using System.Collections.Generic;

namespace Observers
{
    public abstract class AbstractStringSubject : ISubject<AbstractStringSubject>
    {
        private readonly ICollection<IObserver<AbstractStringSubject>> observers;
        
        private string item;
        public string Item
        {
            get
            {
                return item;
            }

            protected set
            {
                item = value;
                foreach (IObserver<AbstractStringSubject> obs in observers)
                {
                    obs.Update(this);
                }

            }
        }

        public void RegisterObserver(IObserver<AbstractStringSubject> obs)
        {
            observers.Add(obs);
        }
        public void RemoveObserver(IObserver<AbstractStringSubject> obs)
        {
            observers.Remove(obs);
        }

        public AbstractStringSubject()
        {
            observers = new List<IObserver<AbstractStringSubject>>();
        }

    }
}