using System;
using System.Collections.Generic;

#nullable disable

namespace HopePharmacy.Entities
{
    public partial class Patient
    {
        public int PatientId { get; set; }
        public string PatientName { get; set; }
        public string Mobile { get; set; }
    }
}
