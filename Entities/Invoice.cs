using System;
using System.Collections.Generic;

#nullable disable

namespace HopePharmacy.Entities
{
    public partial class Invoice
    {
        public int InvoiceId { get; set; }
        public int PatientId { get; set; }
        public int MedicineId { get; set; }
        public decimal SellingPrice { get; set; }
        public decimal ProfitPrice { get; set; }
        public DateTime TrasnactionDate { get; set; }
        public int EmployeeId { get; set; }
    }
}
