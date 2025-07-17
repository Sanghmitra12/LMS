using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LMS.Models;


namespace LMS.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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
        //public ActionResult EIC()
        //{
        //	ViewBag.Message = "Your contact page.";

        //	return View();
        //}
        public ActionResult EIC()
        {
            using (var context = new LMSDbContext())
            {
                var poList = context.PoLiabilityMasters.ToList();
                return View(poList);
            }
        }

        public ActionResult faDashboard()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}

		public ActionResult scheduleDashboard()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}

		public ActionResult Auth()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
		public ActionResult Report()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
        //public ActionResult POliability()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}


        public ActionResult PoLiability()
        {
            // Dummy data
            var po = new PoLiabilityMaster
            {
                PONumber = "5300036307",
                VendorCode = "0101071255",
                PODescription = "ARC FOR CIVIL JOBS IN PLANT AREA AT GAIL, PATA.",
                VendorName = "M/s. AWASTHI TRADERS",
                POStartDate = DateTime.Parse("2022-03-10"),
                POEndDate = DateTime.Parse("2025-07-25"),
                POValue = 39843575.81M,
                EICRemarks = ""
            };

            return View(po); // Send dummy model to view
        }

        public ActionResult AddDummyPO()
        {
            PoLiabilityRepository repo = new PoLiabilityRepository();
            repo.InsertDummyData();

            return Content("Dummy PO inserted successfully.");
        }
    

        // POST: PoLiability
        [HttpPost]
        public ActionResult PoLiability(PoLiabilityMaster model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    using (var context = new LMSDbContext())
                    {
                        context.PoLiabilityMasters.Add(model);
                        context.SaveChanges();
                    }

                    ViewBag.Message = "PO data saved successfully!";
                    return RedirectToAction("PoLiability");
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine("Error: " + ex.Message);
                    ViewBag.Message = "An unexpected error occurred.";
                    return View(model);
                }
            }

            ViewBag.Message = "Please correct the errors.";
            return View(model);
        }



    }
}