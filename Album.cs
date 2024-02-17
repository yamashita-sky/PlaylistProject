using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaylistProject
{
    public class Album : SongList
    {
        public List<Song> Songs { get; set; }
        public string Name { get; set; }
        public string BandName {  get; set; }
        public List<string> BandMembers { get; set; }
        public string releasedate { get; set; }
        //List<string> Songs { get; set; }

        /*public Album(string BandName, List<string> BandMembers, string ReleaseDate)
        {
            this.BandName = BandName;
            this.BandMembers = BandMembers;
            this.releasedate = ReleaseDate;

        }*/
        public Album(string Aname)
        {
            this.Name = Aname;

            Songs = new List<Song>();
        }


    }
}
