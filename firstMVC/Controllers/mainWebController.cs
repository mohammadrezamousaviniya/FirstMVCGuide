using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataBaseConnector;
using firstMVC.Models;

namespace firstMVC.Controllers
{
    public class mainWebController : Controller
    {
        // GET: mainWeb
        public ActionResult Index()
        {
            ViewBag.Title = "salam";
            List<string> VBs = new List<string>();
            VBs.Add("C#");
            VBs.Add("SQL Server");
            ViewBag.Langs = VBs;
            return View();
        }

        public ActionResult ContactUs(string id)
        {
            string aa = id;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult GetUser(CustomerStruct viewModel)
        {
            //INSERT INTO [tblUsers]([id],[un],[password]) VALUES (1111,@un,@password)
            if (ModelState.IsValid)
            {
                PDBC db = new PDBC("MVCCNS", true);
                List<ExcParameters> paramss = new List<ExcParameters>();
                ExcParameters parameters = new ExcParameters()
                {
                    _KEY = "@password",
                    _VALUE = viewModel.password
                };
                paramss.Add(parameters);
                parameters = new ExcParameters()
                {
                    _KEY = "@un",
                    _VALUE = viewModel.name
                };

                paramss.Add(parameters);
                db.Connect();
                string res = db.Script("INSERT INTO [tblUsers]([id],[un],[password]) VALUES (1111,@un,@password)", paramss);
                return Content(res);
            }
            else
            {
                ModelState.Values.ToString();
                return Content("0");
            }
        }


    }
}