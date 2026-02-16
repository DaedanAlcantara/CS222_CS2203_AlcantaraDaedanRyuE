using System;
using System.ComponentModel.Design;
using static MusicPlaylistOrganizer;

class MusicPlaylistOrganizer
{
    static void Main()
    {
        Console.Write("Songs to add: ");
        int numberOfSongs = Convert.ToInt32(Console.ReadLine());
        Song[] songs = new Song[numberOfSongs];
        for (int i = 0; i < numberOfSongs; i++)
        {
            Console.WriteLine("Song #{0}", i + 1);
            Console.Write("Title: ");
            string Title = Console.ReadLine();
            Console.Write("Artist: ");
            string Artist = Console.ReadLine();
            Console.Write("Duration (minutes): ");
            string Duration = Console.ReadLine();
            if (string.IsNullOrEmpty(Artist) && string.IsNullOrEmpty(Title))
            {
                Song inputsong = new Song();
                songs[i] = inputsong;
            }
            else if (string.IsNullOrEmpty(Artist) && string.IsNullOrEmpty(Duration))
            {
                Song inputsong = new Song(Title);
                songs[i] = inputsong;
            }
            else if (string.IsNullOrEmpty(Duration))
            {
                Song inputsong = new Song(Title, Artist);
                songs[i] = inputsong;
            }
         
            else
            {
                Song inputsong = new Song(Title, Artist, Duration);
                songs[i] = inputsong;
            }


            
        }
        Console.WriteLine("=== || MY PLAYLIST || ===");
        Console.WriteLine("{0,-20}{1,-15}{2,-6}", "Title", "Artist", "Duration");
        Console.WriteLine(new string('-', 60));
        float totalDuration = 0;
        foreach (var song in songs)
        {

            song.DisplaySong();
            if (song.Duration != "Unknown")
            {
                totalDuration += float.Parse(song.Duration);
            }


        }

        Console.WriteLine("Total Duration: {0:F2} mins", totalDuration);
        float averageDuration = totalDuration / numberOfSongs;
        Console.WriteLine("Average Duration: {0:F2} mins", averageDuration);
    }

    public class Song
    {
        public string Title;
        public string Artist;
        public string Duration;
        //default
        public Song()
        {
            Title = "Unknown";
            Artist = "Unknown";
            Duration = "Unknown";
        }

        //parameterized (three-parameter)
        public Song(string title, string artist, string duration)
        {
            this.Title = title;
            this.Artist = artist;
            this.Duration = duration;
        }

        //two-parameter constructor
        public Song(string title, string artist)
        {
            this.Title = title;
            this.Artist = artist;
            this.Duration = "0.00";
        }

        // one-parameter constructor delegating to the three-parameter constructor
        public Song(string title) : this(title, "Unknown", "0.00")
        {
        }

        
        public void DisplaySong()
        {
            Console.WriteLine($"{Title,-20}{Artist,-15}{Duration,-6}");
        }
    }
}

