using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HopePharmacy.Controllers
{
    public class InvoiceController : Controller
    {
        Entities.HopeDecemberPharmacyContext _context = new Entities.HopeDecemberPharmacyContext();
        public IActionResult AddNewInvoice()
        {
            return View();
        }


        public IActionResult Create()
        {
            ViewBag.Patient = _context.Patients.ToList();

            ViewBag.Medicine = (from obj in _context.MedicineSuppliers.Include(x => x.Medicine).Include(x => x.Supplier)
                                select new
                                {
                                    Id = obj.MedicineId,
                                    Name = obj.Medicine.MedicineName + " - " + obj.Supplier.SupplierName,
                                }).ToList();

            return View();
        }
    }
}
