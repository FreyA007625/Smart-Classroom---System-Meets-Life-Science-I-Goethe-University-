using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartClassRoom_Panel.Models
{
    public class Classroom
    {
        public int ID { get; set; }
        public string CO2_Concentration { get; set; }
        public DateTime Time { get; set; }
        public int Temperature { get; set; }
        public string Location { get; set; }
    }
}
