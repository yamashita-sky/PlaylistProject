using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaylistProject
{
    /// <summary>
    /// Abstract class that Album.cs and Playlist.cs inherit from
    /// </summary>
    public abstract class SongList
    {
        List<Song> Songlist;
        string title;
        int NumberOfSongs;
        double TotalPlayTime;
    }
}
