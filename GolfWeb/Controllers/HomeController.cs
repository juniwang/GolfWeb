using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GolfWeb.Models;
using System.Xml.Linq;
using System.Xml.XPath;
using System.Linq;
using System.IO;

namespace GolfWeb.Controllers
{
    public class HomeController : Controller
    {
        static XDocument doc;
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Company()
        {
            return View();
        }

        public ActionResult Material()
        {
            return View();
        }

        public ActionResult Packing()
        {
            return View();
        }

        public ActionResult Wooden()
        {
            return View();
        }

        public ActionResult Pantone()
        {
            return View();
        }

        public ActionResult Bamboo()
        {
            return View();
        }

        public ActionResult TeeWithLogo()
        {
            return View();
        }

        public ActionResult HighQualityTee()
        {
            return View();
        }

        public ActionResult Products()
        {
            string datafile = Server.MapPath("~/data/products.xml");
            if (!System.IO.File.Exists(datafile))
            {
                return View();
            }

            if (doc == null)
                doc = XDocument.Load(datafile);
            if (doc == null)
            {
                return View();
            }

            var products = doc.Root.Elements("product")
                .Select(p => new ProductModel
                {
                    Holder = p.Attribute("holder").Value,
                    Spec = p.Attribute("spec").Value
                });
            return View(products.ToArray());
        }
    }
}
