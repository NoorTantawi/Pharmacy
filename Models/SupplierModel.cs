using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HopePharmacy.Models
{
    public class SupplierModel
    {
        public int SupplierId { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "This field is required")]
        public string SupplierName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "This field is required")]
        public string Mobile { get; set; }

        public string Address { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "This field is required")]
        public int ManufactureId { get; set; }

        public string ManufactureName { get; set; }
    }
}
