using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HopePharmacy.Models
{
    public class InvoiceModel
    {
        public int MedicineId { get; set; }

        public int PatientId { get; set; }

        public int QTY { get; set; }
    }
}
