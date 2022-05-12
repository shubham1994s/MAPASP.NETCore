using MAPWEBAPP.Models;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MAPWEBAPP.Controllers
{
    public class MApController : Controller
    {
        private readonly LIVEAdvanceDevSwachhBharatMainContext _context;

        public MApController(LIVEAdvanceDevSwachhBharatMainContext context)
        {
            _context = context;
        }



        public IActionResult Index(int DivisionId = 1, int DistrictId = 0, int AppId = 0, int UserId = 0)
        {
            string StoredProc = "exec SP_ULBADMIN " +
           "@DivisionIdIn = " + DivisionId + "," +
           "@DistrictIdIn = '" + DistrictId + "'," +
           "@AppIdIN= '" + AppId + "'," +
           "@UserId= '" + UserId + "'";
            var data = _context.AdminULBDetails.FromSqlRaw(StoredProc).ToListAsync();
            return View(data);
        }



        public IActionResult Maharashtra(int DivisionId = 0, int DistrictId = 0, int AppId = 0, int UserId = 1)


        {
            //  string StoredProcM = "exec SP_MAPS_ScanDETAILS " + "@DivisionIdIn = " + DivisionId + "," + "@DistrictIdIn = '" + DistrictId + "'," + "@AppIdIN= '" + AppId + "'," + "@UserId= '" + UserId + "'";
            //var dataM = _context.SP_MAPS_ScanDETAILS.FromSqlRaw(StoredProcM).ToList();
            //var House = dataM.AsEnumerable().Select(r => r.TotalProperty_Scan).FirstOrDefault();
            //var Liquid = dataM.AsEnumerable().Select(r => r.TotalLiquid_Scan).FirstOrDefault();
            //var Street = dataM.AsEnumerable().Select(r => r.TotalStreet_Scan).FirstOrDefault();
            //var dump = dataM.AsEnumerable().Select(r => r.TotalDump_Scan).FirstOrDefault();
            //ViewBag.TotalProperty_Scan = House;
            //ViewBag.TotalLiquid_Scan = Liquid;
            //ViewBag.TotalStreet_Scan = Street;
            //ViewBag.TotalDump_Scan = dump;

            string StoredProc = "exec SP_MAPS_DETAILS " + "@DivisionIdIn = " + DivisionId + "," + "@DistrictIdIn = '" + DistrictId + "'," + "@AppIdIN= '" + AppId + "'," + "@UserId= '" + UserId + "'";
            var data = _context.SP_MAPS_DETAILS.FromSqlRaw(StoredProc).ToList();
            return View(data);
        }

        [HttpPost]
        public JsonResult Loaddata(int DivisionId = 0, int DistrictId = 0, int AppId = 0, int UserId = 1)
        {
            string StoredProc = "exec SP_MAPS_DETAILS " + "@DivisionIdIn = " + DivisionId + "," + "@DistrictIdIn = '" + DistrictId + "'," + "@AppIdIN= '" + AppId + "'," + "@UserId= '" + UserId + "'";
            var data = _context.SP_MAPS_DETAILS.FromSqlRaw(StoredProc).ToList();
            var DistrictName = _context.Tehsils.Where(x => x.Id == DistrictId).Select(r => r.Name).FirstOrDefault();
            var AppName = _context.AppDetails.Where(x => x.AppId == AppId).Select(r => r.AppName).FirstOrDefault();
            var House = "";
            if (DistrictId != 0)
            {
                House = "District Name : " + DistrictName + "<br/>" + "Total Property : " + data.AsEnumerable().Sum(r => r.TotalProperty).ToString() + "<br/>" + "Today Property Scan : " + data.AsEnumerable().Sum(r => r.TotalProperty_Scan).ToString();
            }
            if (AppId != 0)
            {
                House = "Ulb Name : " + AppName + "<br/>" + "Total Property : " + data.AsEnumerable().Sum(r => r.TotalProperty).ToString() + "<br/>" + "Today Property Scan : " + data.AsEnumerable().Sum(r => r.TotalProperty_Scan).ToString();
            }

            return Json(House);

        }

        public IActionResult Gadchiroli(int DivisionId = 0, int DistrictId = 0, int AppId = 0, int UserId = 1)
        {
            string StoredProc = "exec SP_MAPS_DETAILS " + "@DivisionIdIn = " + DivisionId + "," + "@DistrictIdIn = '" + DistrictId + "'," + "@AppIdIN= '" + AppId + "'," + "@UserId= '" + UserId + "'";
            var data = _context.SP_MAPS_DETAILS.FromSqlRaw(StoredProc).ToList();
            return View(data);
        }

        public IActionResult Nagpur(int DivisionId = 0, int DistrictId = 0, int AppId = 0, int UserId = 1)
        {
            string StoredProc = "exec SP_MAPS_DETAILS " + "@DivisionIdIn = " + DivisionId + "," + "@DistrictIdIn = '" + DistrictId + "'," + "@AppIdIN= '" + AppId + "'," + "@UserId= '" + UserId + "'";
            var data = _context.SP_MAPS_DETAILS.FromSqlRaw(StoredProc).ToList();
            return View(data);
        }

        public IActionResult palghar(int DivisionId = 0, int DistrictId = 0, int AppId = 0, int UserId = 1)
        {
            string StoredProc = "exec SP_MAPS_DETAILS " + "@DivisionIdIn = " + DivisionId + "," + "@DistrictIdIn = '" + DistrictId + "'," + "@AppIdIN= '" + AppId + "'," + "@UserId= '" + UserId + "'";
            var data = _context.SP_MAPS_DETAILS.FromSqlRaw(StoredProc).ToList();
            return View(data);
        }

        public IActionResult Amravati(int DivisionId = 0, int DistrictId = 0, int AppId = 0, int UserId = 1)
        {
            string StoredProc = "exec SP_MAPS_DETAILS " + "@DivisionIdIn = " + DivisionId + "," + "@DistrictIdIn = '" + DistrictId + "'," + "@AppIdIN= '" + AppId + "'," + "@UserId= '" + UserId + "'";
            var data = _context.SP_MAPS_DETAILS.FromSqlRaw(StoredProc).ToList();
            return View(data);
        }
        public IActionResult Bhandara(int DivisionId = 0, int DistrictId = 0, int AppId = 0, int UserId = 1)
        {
            string StoredProc = "exec SP_MAPS_DETAILS " + "@DivisionIdIn = " + DivisionId + "," + "@DistrictIdIn = '" + DistrictId + "'," + "@AppIdIN= '" + AppId + "'," + "@UserId= '" + UserId + "'";
            var data = _context.SP_MAPS_DETAILS.FromSqlRaw(StoredProc).ToList();
            return View(data);
        }

        public IActionResult Khamgaon(int DivisionId = 0, int DistrictId = 0, int AppId = 0, int UserId = 1)
        {
            string StoredProc = "exec SP_MAPS_DETAILS " + "@DivisionIdIn = " + DivisionId + "," + "@DistrictIdIn = '" + DistrictId + "'," + "@AppIdIN= '" + AppId + "'," + "@UserId= '" + UserId + "'";
            var data = _context.SP_MAPS_DETAILS.FromSqlRaw(StoredProc).ToList();
            return View(data);
        }

        public IActionResult Parbhani(int DivisionId = 0, int DistrictId = 0, int AppId = 0, int UserId = 1)
        {
            string StoredProc = "exec SP_MAPS_DETAILS " + "@DivisionIdIn = " + DivisionId + "," + "@DistrictIdIn = '" + DistrictId + "'," + "@AppIdIN= '" + AppId + "'," + "@UserId= '" + UserId + "'";
            var data = _context.SP_MAPS_DETAILS.FromSqlRaw(StoredProc).ToList();
            return View(data);
        }
        public IActionResult Solapur(int DivisionId = 0, int DistrictId = 0, int AppId = 0, int UserId = 1)
        {
            string StoredProc = "exec SP_MAPS_DETAILS " + "@DivisionIdIn = " + DivisionId + "," + "@DistrictIdIn = '" + DistrictId + "'," + "@AppIdIN= '" + AppId + "'," + "@UserId= '" + UserId + "'";
            var data = _context.SP_MAPS_DETAILS.FromSqlRaw(StoredProc).ToList();
            return View(data);
        }
        public IActionResult Wardha(int DivisionId = 0, int DistrictId = 0, int AppId = 0, int UserId = 1)
        {
            string StoredProc = "exec SP_MAPS_DETAILS " + "@DivisionIdIn = " + DivisionId + "," + "@DistrictIdIn = '" + DistrictId + "'," + "@AppIdIN= '" + AppId + "'," + "@UserId= '" + UserId + "'";
            var data = _context.SP_MAPS_DETAILS.FromSqlRaw(StoredProc).ToList();
            return View(data);
        }
        public IActionResult Gondia(int DivisionId = 0, int DistrictId = 0, int AppId = 0, int UserId = 1)
        {
            string StoredProc = "exec SP_MAPS_DETAILS " + "@DivisionIdIn = " + DivisionId + "," + "@DistrictIdIn = '" + DistrictId + "'," + "@AppIdIN= '" + AppId + "'," + "@UserId= '" + UserId + "'";
            var data = _context.SP_MAPS_DETAILS.FromSqlRaw(StoredProc).ToList();
            return View(data);
        }

        public IActionResult Pune(int DivisionId = 0, int DistrictId = 0, int AppId = 0, int UserId = 1)
        {
            string StoredProc = "exec SP_MAPS_DETAILS " + "@DivisionIdIn = " + DivisionId + "," + "@DistrictIdIn = '" + DistrictId + "'," + "@AppIdIN= '" + AppId + "'," + "@UserId= '" + UserId + "'";
            var data = _context.SP_MAPS_DETAILS.FromSqlRaw(StoredProc).ToList();
            return View(data);
        }

        public IActionResult Index1(int DivisionId = 0, int DistrictId = 0, int AppId = 0, int UserId = 1)


        {


            string StoredProc = "exec SP_MAPS_DETAILS " + "@DivisionIdIn = " + DivisionId + "," + "@DistrictIdIn = '" + DistrictId + "'," + "@AppIdIN= '" + AppId + "'," + "@UserId= '" + UserId + "'";
            var data = _context.SP_MAPS_DETAILS.FromSqlRaw(StoredProc).ToList();
            return View(data);



        }

        public IActionResult htmlpage(int DivisionId = 0, int DistrictId = 0, int AppId = 0, int UserId = 1)


        {
          

            string StoredProc = "exec SP_MAPS_DETAILS " + "@DivisionIdIn = " + DivisionId + "," + "@DistrictIdIn = '" + DistrictId + "'," + "@AppIdIN= '" + AppId + "'," + "@UserId= '" + UserId + "'";
            var data = _context.SP_MAPS_DETAILS.FromSqlRaw(StoredProc).ToList();
            return View(data);
        }

    }
}
