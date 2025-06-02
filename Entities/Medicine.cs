using System;
using System.Collections.Generic;

#nullable disable

namespace HopePharmacy.Entities
{
    public partial class Medicine
    {
        public Medicine()
        {
            MedicineSuppliers = new HashSet<MedicineSupplier>();
        }

        public int MedicineId { get; set; }
        public string MedicineName { get; set; }

        public virtual ICollection<MedicineSupplier> MedicineSuppliers { get; set; }
    }
}
