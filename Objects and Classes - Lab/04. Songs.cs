using System;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;
using System.Globalization;

namespace mid_exam
{
    class Song
    {
        public string List { get; set; }
        public string Name { get; set; }
        public string time { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int songsCount = int.Parse(Console.ReadLine());

            List<Song> songs = new List<Song>();
            for (int i = 0; i < songsCount; i++)
            {
                string[] data = Console.ReadLine().Split("_");
                string type = data[0];
                string name = data[1];
                string time = data[2];

                Song song = new Song();
                {
                    song.List = type;
                    song.Name = name;
                    song.time = time;
                }
                songs.Add(song);

            }
            string typelist = Console.ReadLine();
            if (typelist=="all")
            {
                foreach (Song song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (Song song in songs)
                {
                    if (song.List==typelist )
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }
           
        }
    }
}
