using System;

namespace Observer
{
    class RelaySatellite : IObserver
    {
        private double _limit;
        private ISubject _subject;
        public RelaySatellite(ISubject subject, double limit)
        {
            _subject = subject;
            _limit = limit;
        }
        public void Update(object obj)
        {
            var alpha = (double)obj;
            if (alpha > _limit)
            {
                _subject.RemoveObserver(this);
                Console.WriteLine("Receives {0}, sighed off", alpha);
            }
            else
                Console.WriteLine("Receives {0}", alpha);

        }
        public void AskRegistration()
        {
            _subject.RegisterObserver(this);
            Console.WriteLine("Signed up");
        }
    }
}
