using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_LabWeek1
{
    public class Band :IComparable
    {
        //properties
        public int bandDateFormed { get; set; }

        public string memberName { get; set; }

        public string bandName { get; set; }

        //constructers
        public Band(int banddateformed,string membername, string bandname)
        {
            bandDateFormed = banddateformed;
            memberName = membername;
            bandName = bandname;
        }

        public Band()
        {

        }

        //methods

        public override string ToString()
        {
            return bandName;
        }

        public int CompareTo(object obj)
        {
            Band otherBand = obj as Band;

            return this.bandName.CompareTo(otherBand.bandName);
        }
    }
}
