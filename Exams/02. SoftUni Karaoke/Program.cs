using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SoftUni_Karaoke
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> participants = Console.ReadLine()
                .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            List<string> songs = Console.ReadLine()
                .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            Dictionary<string, HashSet<string>> participantsDic = new Dictionary<string, HashSet<string>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "dawn")
                {
                    break;
                }

                string[] inputArgs = input
                    .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

                string singer = inputArgs[0];
                string song = inputArgs[1];
                string award = inputArgs[2];

                if (!participants.Contains(singer) || !songs.Contains(song))
                {
                    continue;
                }

                if (!participantsDic.ContainsKey(singer))
                {
                    participantsDic.Add(singer, new HashSet<string>());
                }

                participantsDic[singer].Add(award);
            }

            if (participantsDic.Count == 0)
            {
                Console.WriteLine("No awards");
            }

            else
            {
                foreach (var participant in participantsDic.OrderByDescending(p => p.Value.Count))
                {
                    Console.WriteLine($"{participant.Key}: {participant.Value.Count} awards");

                    foreach (var award in participant.Value.OrderByDescending(a => a))
                    {
                        Console.WriteLine($"--{award}");
                    }
                }
            }
        }
    }
}
