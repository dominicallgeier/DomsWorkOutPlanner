using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomsWorkOutPlanner
{
    internal class Exercise
    {
        public Cardio Cardio { get; set; }
        public Legs Legs { get; set; }
        public Arms Arms { get; set; }  
    }

    internal class Cardio
    {
        public string Running { get; set; }
        public string Swimming { get; set; }
        public string Biking { get; set; }

    }
    internal class Legs
    {
        public string Squatting { get; set; }
        public string Lunging { get; set; }
        public string LegPress { get; set; }
    }
    internal class Arms
    {
        public string Bench { get; set; }
        public string Curls { get; set; }
        public string Incline { get; set; }
    }

}
