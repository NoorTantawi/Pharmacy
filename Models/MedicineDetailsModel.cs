using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HopePharmacy.Models
{
    public class MedicineDetailsModel
    {
        public int MedicineSupplierId { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "This field is required")]
        public int SupplierId { get; set; }
        public int MedicineId { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "This field is required")]
        public decimal CostPrice { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "This field is required")]
        public decimal SellingPrice { get; set; }
        public DateTime ExpirayDate { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "This field is required")]
        public int OrginalQuantity { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "This field is required")]
        public int LeftQuantity { get; set; }
        public string Description { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "This field is required")]
        public decimal DiscountValue { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "This field is required")]
        public decimal TaxValue { get; set; }

        public string MedicineName { get; set; }

        public string SupplierName { get; set; }
    }
}
