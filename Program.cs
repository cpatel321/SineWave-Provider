using System;
using System.Threading;

namespace hello
{
    class Program
    {
        static void Main(string[] args)
        {
            var soundGenerator = new SineGenerator.SoundGenerator();
            for (int i = 100; i < 3000; i++)
            {
                Thread.Sleep(1);
                soundGenerator.GenerateSound(i);
            }
        }
    }
}
