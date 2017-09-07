using System.Collections.Generic;

namespace Observer
{
    class SpaceCraft : ISubject
    {
        private double _alpha;
        public SpaceCraft()
        {
            Observers = new List<IObserver>();
        }
        public double Alpha
        {
            get { return _alpha; }
            set
            {
                _alpha = value;
                NotifyObservers();
            }
        }
        public List<IObserver> Observers 
        { get; set; }
        public void NotifyObservers()
        {
            int currentIndex = Observers.Count-1;
            //int currentLength = Observers.Count;
            while(currentIndex>=0)
            {
                Observers[currentIndex].Update(Alpha);
                currentIndex--;
            }
        }

        public void RegisterObserver(IObserver newObserver)
        {
            Observers.Add(newObserver);
        }

        public void RemoveObserver(IObserver observer)
        {
            Observers.Remove(observer);
        }
    }
}
