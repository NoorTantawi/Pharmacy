using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HopePharmacy.Controllers
{
    public class SupplierController : Controller
    {
        Entities.HopeDecemberPharmacyContext _context = new Entities.HopeDecemberPharmacyContext();
        public IActionResult GetAllSuppliers()
        {
            List<Models.SupplierModel> lst = new List<Models.SupplierModel>();
            lst = (from obj in _context.Suppliers.Include(x => x.Manufacture)
                   select new Models.SupplierModel
                   {
                       SupplierId = obj.SupplierId,
                       SupplierName = obj.SupplierName,
                       Mobile = obj.Mobile,
                       Address = obj.Address,
                       ManufactureId = obj.ManufactureId,
                       ManufactureName = obj.Manufacture.ManufactureName,

                   }).ToList();

            return View(lst);
        }

        public IActionResult Create()
        {
            ViewBag.Manufacture = _context.Manufactures.ToList();

            return View();
        }

        public IActionResult AddNewSupplier(Models.SupplierModel supplierModel)
        {
            Entities.Supplier obj = new Entities.Supplier();
            obj.SupplierName = supplierModel.SupplierName;
            obj.Mobile = supplierModel.Mobile;
            obj.Address = supplierModel.Address;
            obj.ManufactureId = supplierModel.ManufactureId;

            _context.Suppliers.Add(obj);
            _context.SaveChanges();

           return RedirectToAction("GetAllSuppliers");
        }
        public IActionResult Edit(int Id)
        {

            Models.SupplierModel supplierModel = new Models.SupplierModel();
            Entities.Supplier supplier = new Entities.Supplier();
            supplier = _context.Suppliers.Where(x => x.SupplierId == Id).FirstOrDefault();

            supplierModel.SupplierId = supplier.SupplierId;
            supplierModel.SupplierName = supplier.SupplierName;
            supplierModel.Mobile = supplier.Mobile;
            supplierModel.Address = supplier.Address;
            supplierModel.ManufactureId = supplier.ManufactureId;

            ViewBag.Manufacture = _context.Manufactures.ToList();

            return View(supplierModel);
        }

        public IActionResult UpdateSupplier(Models.SupplierModel supplierModel)
        {

            Entities.Supplier obj = new Entities.Supplier();
            obj = _context.Suppliers.Where(x => x.SupplierId == supplierModel.SupplierId).FirstOrDefault();

            obj.SupplierName = supplierModel.SupplierName;
            obj.Mobile = supplierModel.Mobile;
            obj.Address = supplierModel.Address;
            obj.ManufactureId = supplierModel.ManufactureId;

            _context.SaveChanges();
            return RedirectToAction("GetAllSuppliers");
        }

        public IActionResult Delete(int Id)
        {
           
            Entities.Supplier supplier = new Entities.Supplier();
            supplier = _context.Suppliers.Where(x => x.SupplierId == Id).FirstOrDefault();

            _context.Suppliers.Remove(supplier);
            _context.SaveChanges();

            return RedirectToAction("GetAllSuppliers");

        }
    }
}
