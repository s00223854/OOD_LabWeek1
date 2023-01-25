using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_LabWeek1
{
    public class Album
    {
        //properties

        public string albumName { get; set; }

        public int releasedDate { get; set; }

        public int sales { get; set; }
        //constructers

        public Album(string albumname, int releasedate, int Sales)
        {
            albumName = albumname;
            releasedDate = releasedate;
            sales = Sales;
        }
        public Album()
        {

        }

        //methods

        public override string ToString()
        {
            return string.Format($"{albumName} - released in {releasedDate}, sold {sales} copies");
        }

    }
}
