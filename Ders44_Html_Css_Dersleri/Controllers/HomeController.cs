using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ders44_Html_Css_Dersleri.Models;

namespace Ders44_Html_Css_Dersleri.Controllers
{
    public class HomeController : Controller
    {
        NORTHWNDEntities context = new NORTHWNDEntities();
        // GET: Home
        public ActionResult Index()
        {
            //select * from Categories
            List<Categories> kategoriListesi = context.Categories.ToList();
            return View(kategoriListesi);
        }


        public ActionResult Index2()
        {
            List<Products> productList = context.Products.ToList();
            return View(productList);
        }


        int toplama()
        {
            return 4;
        }
        //metod overload = aynı isimli metodu , farklı parametre ile yazabilmek
        int toplama(int sayi1)
        {
            return 4;
        }

        int toplama(string sayi2)
        {
            return 4;
        }

        public ActionResult Index3()
        {
            //metod overload = 
            return View();
        }


        [HttpGet]
        public ActionResult Index4()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index4(Products prd)
        {
            return View();
        }



        public ActionResult Index5()
        {
            return View();
        }


        public ActionResult Index6()
        {
            return View();
        }


        public ActionResult Index7()
        {
            return View();
        }

        public ActionResult hakkimizda()
        {
            return View();
        }


        public ActionResult iletisim()
        {
            return View();
        }


    }
}