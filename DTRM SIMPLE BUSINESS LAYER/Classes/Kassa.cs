using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using POSLayer.Models;

namespace DTRMNS {
    public class Kassa {

        public Employee Manager { get; set; }
        public Employee Controller { get; set; }
        public DateTime DayDate { get; set; }
       // public ShiftTypes ShiftType { get; set; }

    }
}
