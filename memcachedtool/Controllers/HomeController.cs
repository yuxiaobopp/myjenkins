using memcachedtool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace memcachedtool.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = MemcachedHelper.GetServerList();
            string[] servers = model.Data.Select(t => t.Address).ToArray();

            ViewBag.ht = new MemcachedHelper(servers).Stats();
            ViewBag.ServerList = model;
            return View();
        }
        public ActionResult Node(string server)
        {
            ViewBag.ht = new MemcachedHelper(new string[] { server }).Stats();
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}