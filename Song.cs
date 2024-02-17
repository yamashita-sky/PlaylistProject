using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaylistProject
{
    /// <summary>
    /// Song subclass to be used by Album
    /// </summary>
    public class Song
    {
        public string title { get; set; }
        public string artist { get; set; }
        public double runtime { get; set; }

        public Song(string title, string artist, double runtime)
        {
            this.title = title;
            this.artist = artist;
            this.runtime = runtime;
        }
        

        /*public Song(string title, string artist, double runtime)
        {
            this.title += title;
            this.artist = artist;
            this.runtime = runtime;
        }*/
    }
}
   