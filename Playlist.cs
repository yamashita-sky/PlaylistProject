using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaylistProject
{
    internal class Playlist : SongList
    {
        public List<Song> Songs { get; set; }

        public Playlist()
        {
            Songs = new List<Song>();
        }

        public void AddSong(Song song)
        {
            Songs.Add(song);
            Console.WriteLine($"Added '{song.title}' by {song.artist} to the playlist.");
        }

        public void RemoveSong(Song song)
        {
            Songs.Remove(song);
            Console.WriteLine($"Removed '{song.title}' by {song.artist} from the playlist");
        }

        public void DisplayPlaylist()
        {
            Console.WriteLine("Playlist:");
            foreach (var song in Songs)
            {
                Console.WriteLine($"Title: {song.title}, Artist: {song.artist}, Duration: {song.runtime} minutes");
            }
        }

        public void Shuffle()
        {
            Random random = new Random();
            int n = Songs.Count;

            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                Song value = Songs[k];
                Songs[k] = Songs[n];
                Songs[n] = value;
            }
        }
        public void DisplayASong(Song song)
        {
            if (Songs.Contains(song))
            {
                Console.WriteLine($"Title: {song.title}, Artist: {song.artist}, Duration: {song.runtime} minutes");
            }
            else
            {
                Console.WriteLine($"Song '{song.title}' by {song.artist} not found in the playlist.");
            }
        }
    }
}
