using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BPMCounter
{
    class BPMCounter
    {
        static void Main(string[] args)
        {
            int bpm = int.Parse(Console.ReadLine());
            int numberOfBeats = int.Parse(Console.ReadLine());

            double bars = Math.Round(numberOfBeats / 4.0, 1);
            double time = ((bars * 4) / bpm) * 60;
            Console.WriteLine($"{bars} bars - {Math.Truncate(time / 60)}m {Math.Truncate(time % 60)}s");
        }
    }
}
