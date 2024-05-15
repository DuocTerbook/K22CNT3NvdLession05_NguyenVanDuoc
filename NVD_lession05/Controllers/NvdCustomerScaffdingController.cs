using NVD_lession05.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NVD_lession05.Controllers
{
    public class NvdCustomerScaffdingController : Controller
    {
        //mockdata
        private static List<NvdCustomer> listCustomer = new List<NvdCustomer>()
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
        // GET: NvdCustomerScaffding
        // listCustomer

        public ActionResult Index()
        {
            return View(listCustomer);
        }
        [HttpGet]
        public ActionResult NvdCreate()
        {
            var model = new NvdCustomer();
            return View(model);
        }
        [HttpPost]
        public ActionResult NvdCreate(NvdCustomer model)
        {
            // Thêm mới đối tượng khách hàng vào ds dữ liệu
            listCustomer.Add(model);
            //return View(model);
            // Chuyển về trang danh sách
            return RedirectToAction("Index");
        }
        public ActionResult NvdEdit(int id)
        {
            var Customer = listCustomer.FirstOrDefault(x=>x.CustomerID==id);
            return View(Customer); 
        }
    }
}
