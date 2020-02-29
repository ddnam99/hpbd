using System;
using System.Collections.Generic;

namespace hpbd
{
    class Program
    {
        private static Dictionary<string, (int, int)> MusicNotes = new Dictionary<string, (int, int)>();

        static void Main(string[] args)
        {
            MusicNotes.Add("Do", (523, 382));
            MusicNotes.Add("Re", (587, 340));
            MusicNotes.Add("Mi", (659, 304));
            MusicNotes.Add("Fa", (698, 286));
            MusicNotes.Add("Sol", (740, 270));
            MusicNotes.Add("La", (880, 228));
            MusicNotes.Add("Si", (988, 220));

            string hpbd = "Do,Do,Re,Do,Fa,Mi,Do,Do,Re,Do,Sol,Fa,Do,Do,Do,La,Fa,Mi,Re,Si,Si,La,Fa,Sol,Fa";
            string kcbv = "Do,Re,Mi,Do,Do,Re,Mi,Do,Mi,Fa,Sol,Mi,Fa,Sol,Sol,La,Sol,Fa,Mi,Do,Sol,La,Sol,Fa,Mi,Do,Do,Sol,Do,Do,Sol,Do";

            foreach (var i in kcbv.Split(","))
            {
                var (frequency, duration) = MusicNotes[i];
                Console.WriteLine($"{i}: {frequency}, {duration}");
                Console.Beep(frequency, duration);
            }
        }
    }
}