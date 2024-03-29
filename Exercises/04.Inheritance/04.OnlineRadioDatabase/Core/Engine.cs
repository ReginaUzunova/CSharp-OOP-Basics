﻿using OnlineRadioDatabase.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;


namespace OnlineRadioDatabase.Core
{
    public class Engine
    {
        private List<Song> songs;

        public Engine()
        {
            this.songs = new List<Song>();
        }

        public void Run()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                try
                {
                    string[] input = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);

                    if (input.Length != 3)
                    {
                        throw new InvalidSongException();
                    }

                    string artistName = input[0];
                    string songName = input[1];
                    string[] songLength = input[2].Split(":");

                    bool isMinutes = int.TryParse(songLength[0], out int minutes);
                    bool isSeconds = int.TryParse(songLength[1], out int seconds);

                    if (!isMinutes)
                    {
                        throw new InvalidSongLengthException();
                    }

                    if (!isSeconds)
                    {
                        throw new InvalidSongLengthException();
                    }

                    Song song = new Song(artistName, songName, minutes, seconds);
                    songs.Add(song);
                    Console.WriteLine("Song added.");
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
               
            }

            Print();
        }

        private void Print()
        {
            Console.WriteLine($"Songs added: {songs.Count}");

            int totalSeconds = songs.Sum(x => (x.Minutes * 60) + x.Seconds);
            TimeSpan time = TimeSpan.FromSeconds(totalSeconds);

            Console.WriteLine($"Playlist length: {time.Hours}h {time.Minutes}m {time.Seconds}s");
        }
    }
}
