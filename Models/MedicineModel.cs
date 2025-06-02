using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HopePharmacy.Models
{
    public class MedicineModel
    {
        public int MedicineId { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "This field is required")]
        public string MedicineName { get; set; }
    }
}
