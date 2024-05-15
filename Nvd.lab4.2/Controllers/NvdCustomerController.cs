using Nvd.lab4._2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nvd.lab4._2.Controllers
{
    public class NvdCustomerController : Controller
    {
        //khai báo biến CustomerRepository
        static NvdCustomer listCustomer;
        public NvdCustomerController()
        {
            //khởi tạo CustomerRepository
            listCustomer = new NvdCustomer();
        }
        // GET: /Customer/GetCustomers
        public ActionResult GetCustomers()
        {
            return View();
        }
        //POST: /Customer/GetCustomers
        [HttpPost]
        public ActionResult GetCustomers(string name)
        {
            return View();
        }
        // GET: /Customer/Details/5
        public ActionResult Details(string id)
        {
            return View(id);
        }
        // GET: /Customer/Create
        public ActionResult Create()
        {
            return View();
        }
        // POST: /Customer/Create
        [HttpPost]
        public ActionResult Create(NvdCustomer cus)
        {
            //listCustomer.AddCustomer(cus);
            return RedirectToAction("GetCustomers");
        }
        // GET: /Customer/Edit/5
        public ActionResult Edit(string id)
        {
            return View(id);
        }
        // POST: /Customer/Edit
        [HttpPost]
        public ActionResult Edit(NvdCustomer cus)
        {
            //listCustomer.UpdateCustomer(cus);
            return RedirectToAction("GetCustomers");
        }
        // GET: /Customer/Delete/5
        public ActionResult Delete(string id)
        {
            //listCustomer.DeleteCustomer(id);
            return RedirectToAction("GetCustomers");
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}