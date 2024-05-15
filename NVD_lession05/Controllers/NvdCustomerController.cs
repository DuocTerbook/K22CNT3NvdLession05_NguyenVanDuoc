using NVD_lession05.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace NVD_lession05.Controllers
{
    public class NvdCustomerController : Controller
    {
        // GET: NvdCustomer
        public ActionResult Index()
        {
            return View();
        }
        // Action: NvdCustomerDetail
        public ActionResult NvdCustomerDetails()
        {
            // Tạo đối tượng dữ liệu
            var Customer = new NvdCustomer
            {
                CustomerID = 1,
                FristName = "Nguyễn Văn",
                LastName = "Được",
                Address = "K22CNT3",
                YearOfBirth = 2004
            };
            ViewBag.customer = Customer;
            return View();
        }
        //Get: NvdListCustomer
        public ActionResult NvdListCustomer()
        {
            var list = new List<NvdCustomer>()
            {
                new NvdCustomer
                {
                    CustomerID = 1,
                    FristName = "Nguyễn Văn",
                    LastName = "Được",
                    Address = "K22CNT3",
                    YearOfBirth = 2004
                },
                new NvdCustomer
                {
                    CustomerID = 2,
                    FristName = "Phan Viết",
                    LastName = "Vượng",
                    Address = "K22CNT3",
                    YearOfBirth = 2004
                },
                new NvdCustomer
                {
                    CustomerID = 3,
                    FristName = "Trịnh Hữu",
                    LastName = "Phúc",
                    Address = "K22CNT3",
                    YearOfBirth = 2004
                },
                new NvdCustomer
                {
                    CustomerID = 4,
                    FristName = "Trương Đình",
                    LastName = "Tuyển",
                    Address = "K22CNT3",
                    YearOfBirth = 2004
                },
            };
            ViewBag.list = list;//Đưa dữ liệu ra view bằng đối tượng ViewBag

            return View(list); 
        }
    }
}