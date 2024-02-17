using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaylistProject
{
    public class Album : SongList
    {
        /// <summary>
        /// Album class that stores songs within it (inherits fields from Songlist.cs)
        /// </summary>
        public List<Song> Songs { get; set; }
        public string Name { get; set; }
        public string BandName {  get; set; }
        public List<string> BandMembers { get; set; }
        public string releasedate { get; set; }
        public Album(string Aname)
        {
            this.Name = Aname;

            Songs = new List<Song>();
        }


    }
}
