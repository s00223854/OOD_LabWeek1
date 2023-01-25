using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_LabWeek1
{
    public abstract class Band :IComparable
    {
        //properties
        public int bandDateFormed { get; set; }

        public string memberName { get; set; }

        public string bandName { get; set; }

        public List<Album> albumList { get; set; }

        //constructers
        public Band(int banddateformed,string membername, string bandname)
        {
            bandDateFormed = banddateformed;
            memberName = membername;
            bandName = bandname;

            albumList = new List<Album>();
        }

        public Band() : this (1960, "Unknown", "Unknown") { }

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

    public class RockBand : Band
    {
        public override string ToString()
        {
            return base.ToString() + " - Rock Band";
        }
    }

    public class PopBand : Band
    {
        public override string ToString()
        {
            return base.ToString() + " - Pop Band";
        }

    }

    public class ElectronicBand : Band
    {
        public override string ToString()
        {
            return base.ToString() + " - Electronic Band";
        }

    }

    public class IndieBand : Band
    {
        public override string ToString()
        {
            return base.ToString() + " - Indie Band";
        }

    }
}
