using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var spaceCraft = new SpaceCraft();
            var random = new Random();
            for(int i =0; i<5; i++)
            {
                var relaySatellite = new RelaySatellite(spaceCraft, random.Next(10));
                relaySatellite.AskRegistration();
            }
            for(int i=0; i<=11; i++)
            {
                spaceCraft.Alpha = i;
            }
            Console.ReadKey(true);
        }
    }
}
