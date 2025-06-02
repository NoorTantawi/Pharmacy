using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HopePharmacy.Controllers
{
    public class MedicineController : Controller
    {
        Entities.HopeDecemberPharmacyContext _context = new Entities.HopeDecemberPharmacyContext();

        public IActionResult AddNewMedicine(Models.MedicineModel medicineModel)
        {
            Entities.Medicine medicine = new Entities.Medicine();
            medicine.MedicineName = medicineModel.MedicineName;

            _context.Medicines.Add(medicine);
            _context.SaveChanges();


            return RedirectToAction("GetAllMedicines");
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult GetAllMedicines()
        {
            List<Models.MedicineModel> lst = new List<Models.MedicineModel>();

            lst = (from obj in _context.Medicines
                   select new Models.MedicineModel
                   {
                       MedicineId = obj.MedicineId,
                       MedicineName = obj.MedicineName,
                   }).ToList();

            return View(lst);
        }

        public IActionResult Details(int Id)
        {

            ViewBag.Supplier = _context.Suppliers.ToList();
            ViewBag.MedicineId = Id;

            return View();
        }

        public IActionResult AddMedicineDetails(Models.MedicineDetailsModel medicineDetailsModel)
        {
            Entities.MedicineSupplier obj = new Entities.MedicineSupplier();

            obj.MedicineId = medicineDetailsModel.MedicineId;
            obj.SupplierId = medicineDetailsModel.SupplierId;
            obj.CostPrice = medicineDetailsModel.CostPrice;
            obj.SellingPrice = medicineDetailsModel.SellingPrice;
            obj.ExpirayDate = medicineDetailsModel.ExpirayDate;
            obj.OrginalQuantity = medicineDetailsModel.OrginalQuantity;
            obj.LeftQuantity = medicineDetailsModel.LeftQuantity;
            obj.DiscountValue = medicineDetailsModel.DiscountValue;
            obj.TaxValue = medicineDetailsModel.TaxValue;
            obj.Description = medicineDetailsModel.Description;

            _context.MedicineSuppliers.Add(obj);
            _context.SaveChanges();

            return RedirectToAction("GetAllDetails");

        }

        public IActionResult GetAllDetails()
        {
            List<Models.MedicineDetailsModel> lst = new List<Models.MedicineDetailsModel>();

            lst = (from obj in _context.MedicineSuppliers.Include(x => x.Medicine).Include(x => x.Supplier)
                   select new Models.MedicineDetailsModel
                   {
                       MedicineName = obj.Medicine.MedicineName,
                       SupplierName = obj.Supplier.SupplierName,
                       CostPrice = obj.CostPrice,
                       SellingPrice = obj.SellingPrice,
                       OrginalQuantity = obj.OrginalQuantity,
                       LeftQuantity = obj.LeftQuantity,
                       DiscountValue = obj.DiscountValue,
                       TaxValue = obj.TaxValue,
                       Description = obj.Description,

                   }).ToList();

            return View(lst);
        }
    }
}
