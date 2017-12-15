using System;
using System.Speech.Synthesis;

namespace FireSomeone_
{
    class Program
    {
        static void Main(string[] args)
        {
            const string someone = "Serkan";

            using (SpeechSynthesizer synth = new SpeechSynthesizer())
            {
                synth.SetOutputToDefaultAudioDevice();

                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(i.ToString());
                    synth.Speak($"{someone} you are Fired!");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}

