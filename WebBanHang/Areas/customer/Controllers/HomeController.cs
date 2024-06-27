using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebBanHang.Helpers;
using WebBanHang.Models;

namespace WebBanHang.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _db;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }
        // hien thi dnah sach tat ca san pham
        public IActionResult Index(int? page, string textsearch = "")
        {
            var pageIndex = (int)(page != null ? page : 1);
            var pageSize = 8;
            var productList = _db.Products.Include(x => x.Category).Where(p => p.Name.ToLower().Contains(textsearch.ToLower())).ToList();
            //Thống kê số trang
            //var pageSum =(int) Math.Ceiling((Decimal)productList.Count / pagesize);
            var pageSum = productList.Count() / pageSize + (productList.Count() % pageSize > 0 ? 1 : 0);
            // Truyền dữ liệu cho View
            ViewBag.pageSum = pageSum;
            ViewBag.pageIndex = pageIndex;
            return View(productList.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList())
            ;

        }
        // hien thi dnah sach tat ca san pham co gia thap nhat
        //public IActionResult Index()
        //    {
        //        var productList = _db.Products.OrderBy(p=>p.Price).Take(5).ToList();
        //        return View(productList);
        //    }
        //    // hien thi dnah sach tat ca san pham co gia cao nhat
        //    public IActionResult Index()
        //    {
        //        var productList = _db.Products.OrderByDescending(p => p.Price).Take(5).ToList();
        //        return View(productList);
        //    }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
