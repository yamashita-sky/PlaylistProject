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
        /// <summary>
        /// Adds a song
        /// </summary>
        /// <param name="song"></param>
        public void AddSong(Song song)
        {
            Songs.Add(song);
            Console.WriteLine($"Added '{song.title}' by {song.artist} to the playlist.");
        }
        /// <summary>
        /// Removes a song
        /// </summary>
        /// <param name="song"></param>
        public void RemoveSong(Song song)
        {
            Songs.Remove(song);
            Console.WriteLine($"Removed '{song.title}' by {song.artist} from the playlist");
        }
        /// <summary>
        /// Shuffles the playlist
        /// </summary>
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
        /// <summary>
        /// Displays a specific song
        /// </summary>
        /// <param name="song"></param>
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
