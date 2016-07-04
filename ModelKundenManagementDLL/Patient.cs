using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelKundenManagementDLL
{
    public class Patient
    {
        public int patient_id { get; set; }
        public string Name { get; set; }
        public string Vorname { get; set; }
        public string Bluttgruppe { get; set; }
        public string Erkrankung { get; set; }

        public override string ToString()
        {
            return patient_id + ": " + Vorname + " " + Name;
        }

    }
}
