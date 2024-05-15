using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using Nvd.lab4._1.Models;

namespace Nvd.lab4._1.Controllers
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
            var NvdCustomer = new NvdCustomer
            {
                CustomerId = "KH001",
                FullName = "Nguyễn Văn Được",
                Address = "Hà Nội",
                Email = "nguyenvanduoc09665362766276@gmail.com",
                Phone = "0966.536.276",
                Balance = 15200000
            };
            ViewBag.customer = NvdCustomer;
            return View();
        }
        public ActionResult NvdListCustomer()
        {
            //tạo một danh sách khách hàng
            List<NvdCustomer> listcustomer = new List<NvdCustomer>(){
            new NvdCustomer(){ CustomerId = "KH001",
            FullName = "Nguyễn Văn Được",
            Address = "Hà Nội",Email = "nguyenvanduoc09665362766276@gmail.com",
            Phone = "0966.536.276",Balance = 15200000},
            new NvdCustomer(){ CustomerId = "KH002", FullName = "Đỗ Thị Cúc",
            Address = "Hà Nội",Email = "cucdt@gmail.com",
            Phone = "0986.767.444",Balance = 2200000},
            new NvdCustomer(){ CustomerId = "KH003",
            FullName = "Nguyễn Tuấn Thắng",
            Address = "Nam Định",Email = "thangnt@gmail.com",
            Phone = "0924.656.542",Balance = 1200000},
            new NvdCustomer(){ CustomerId = "KH004", FullName = "Lê Ngọc Hải",
            Address = "Hà Nội",Email = "hailn@gmail.com",
            Phone = "0996.555.267",Balance = 6200000 }
        };
            //gán dữ liệu vào ViewBag để chuyển qua View
            ViewBag.listcustomer = listcustomer;
            return View(listcustomer);
        }
    }
}