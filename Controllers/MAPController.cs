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



            AdminMapULBDetails mapDetail = new AdminMapULBDetails();
            List<AdminMapULBDetailsIteam> ListMapItems = new List<AdminMapULBDetailsIteam>();

            string StoredProc = "exec SP_ULBADMINMAPAPP " + "@DivisionIdIn = " + DivisionId + "," + "@DistrictIdIn = " + DistrictId + "," + "@AppIdIN= " + AppId + "," + "@UserId= " + UserId + "";
            var data = _context.SP_ULBADMINMAPAPP.FromSqlRaw(StoredProc).ToList();

            if (data != null && data.Count > 0)
            {
                foreach (var item in data)
                {
                    mapDetail.TotalHouse += item.TotalHouse ?? 0;
                    mapDetail.TotalHouseScan += item.TotalHouseScan ?? 0;
                    mapDetail.TotalLiquid += item.TotalLiquid ?? 0;
                    mapDetail.TotalLiquidScan += item.TotalLiquidScan ?? 0;
                    mapDetail.TotalStreet += item.TotalStreet ?? 0;
                    mapDetail.TotalStreetScan += item.TotalStreetScan ?? 0;
                    mapDetail.TotalDump += item.TotalDump ?? 0;
                    mapDetail.TotalDumpScan += item.TotalDumpScan ?? 0;


                }
                mapDetail.ListMapDetails = data.Select(x => new AdminMapULBDetailsIteam()
                {
                    ULBId = x.ULBId,
                    ULBName = x.ULBName,
                    TotalHouse = x.TotalHouse,
                    TotalHouseScan = x.TotalHouseScan,
                    TotalLiquid = x.TotalLiquid,
                    TotalLiquidScan = x.TotalLiquidScan,
                    TotalStreet = x.TotalStreet,
                    TotalStreetScan = x.TotalStreetScan,
                    TotalDump = x.TotalDump,
                    TotalDumpScan = x.TotalDumpScan,
                    ParentULB = x.ParentULB

                })
               .ToList();
            }

            return View(mapDetail);
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
                House = "District Name : " + DistrictName + "<br/>" + "Total House Count : " + data.AsEnumerable().Sum(r => r.TotalProperty).ToString() + "<br/>" + "Today Property Scan : " + data.AsEnumerable().Sum(r => r.TotalProperty_Scan).ToString();
            }
            if (AppId != 0)
            {
                House = "Ulb Name : " + AppName + "<br/>" + "Total House Count : " + data.AsEnumerable().Sum(r => r.TotalProperty).ToString() + "<br/>" + "Today Property Scan : " + data.AsEnumerable().Sum(r => r.TotalProperty_Scan).ToString();
            }

            return Json(House);

        }

        public IActionResult Gadchiroli(int DivisionId = 0, int DistrictId = 0, int AppId = 0, int UserId = 1)
        {
            AdminMapULBDetails mapDetail = new AdminMapULBDetails();
            List<AdminMapULBDetailsIteam> ListMapItems = new List<AdminMapULBDetailsIteam>();
            string StoredProc = "exec SP_ULBADMINMAPAPP " + "@DivisionIdIn = " + DivisionId + "," + "@DistrictIdIn = " + DistrictId + "," + "@AppIdIN= " + AppId + "," + "@UserId= " + UserId + "";
            var data = _context.SP_ULBADMINMAPAPP.FromSqlRaw(StoredProc).ToList();

            if (data != null && data.Count > 0)
            {
                foreach (var item in data)
                {
                    mapDetail.TotalHouse += item.TotalHouse ?? 0;
                    mapDetail.TotalHouseScan += item.TotalHouseScan ?? 0;
                    mapDetail.TotalLiquid += item.TotalLiquid ?? 0;
                    mapDetail.TotalLiquidScan += item.TotalLiquidScan ?? 0;
                    mapDetail.TotalStreet += item.TotalStreet ?? 0;
                    mapDetail.TotalStreetScan += item.TotalStreetScan ?? 0;
                    mapDetail.TotalDump += item.TotalDump ?? 0;
                    mapDetail.TotalDumpScan += item.TotalDumpScan ?? 0;

                }
                mapDetail.ListMapDetails = data.Select(x => new AdminMapULBDetailsIteam()
                {
                    ULBId = x.ULBId,
                    ULBName = x.ULBName,
                    TotalHouse = x.TotalHouse,
                    TotalHouseScan = x.TotalHouseScan,
                    TotalLiquid = x.TotalLiquid,
                    TotalLiquidScan = x.TotalLiquidScan,
                    TotalStreet = x.TotalStreet,
                    TotalStreetScan = x.TotalStreetScan,
                    TotalDump = x.TotalDump,
                    TotalDumpScan = x.TotalDumpScan,
                    ParentULB = x.ParentULB
                })
                .ToList();
            }
            return View(mapDetail);
        }

        public IActionResult Nagpur(int DivisionId = 0, int DistrictId = 0, int AppId = 0, int UserId = 1)
        {
            AdminMapULBDetails mapDetail = new AdminMapULBDetails();
            List<AdminMapULBDetailsIteam> ListMapItems = new List<AdminMapULBDetailsIteam>();
            string StoredProc = "exec SP_ULBADMINMAPAPP " + "@DivisionIdIn = " + DivisionId + "," + "@DistrictIdIn = " + DistrictId + "," + "@AppIdIN= " + AppId + "," + "@UserId= " + UserId + "";
            var data = _context.SP_ULBADMINMAPAPP.FromSqlRaw(StoredProc).ToList();

            if (data != null && data.Count > 0)
            {
                foreach (var item in data)
                {
                    mapDetail.TotalHouse += item.TotalHouse ?? 0;
                    mapDetail.TotalHouseScan += item.TotalHouseScan ?? 0;
                    mapDetail.TotalLiquid += item.TotalLiquid ?? 0;
                    mapDetail.TotalLiquidScan += item.TotalLiquidScan ?? 0;
                    mapDetail.TotalStreet += item.TotalStreet ?? 0;
                    mapDetail.TotalStreetScan += item.TotalStreetScan ?? 0;
                    mapDetail.TotalDump += item.TotalDump ?? 0;
                    mapDetail.TotalDumpScan += item.TotalDumpScan ?? 0;

                }
                mapDetail.ListMapDetails = data.Select(x => new AdminMapULBDetailsIteam()
                {
                    ULBId = x.ULBId,
                    ULBName = x.ULBName,
                    TotalHouse = x.TotalHouse,
                    TotalHouseScan = x.TotalHouseScan,
                    TotalLiquid = x.TotalLiquid,
                    TotalLiquidScan = x.TotalLiquidScan,
                    TotalStreet = x.TotalStreet,
                    TotalStreetScan = x.TotalStreetScan,
                    TotalDump = x.TotalDump,
                    TotalDumpScan = x.TotalDumpScan,
                    ParentULB = x.ParentULB
                })
                .ToList();
            }
            return View(mapDetail);
        }

        public IActionResult palghar(int DivisionId = 0, int DistrictId = 0, int AppId = 0, int UserId = 1)
        {
            AdminMapULBDetails mapDetail = new AdminMapULBDetails();
            List<AdminMapULBDetailsIteam> ListMapItems = new List<AdminMapULBDetailsIteam>();
            string StoredProc = "exec SP_ULBADMINMAPAPP " + "@DivisionIdIn = " + DivisionId + "," + "@DistrictIdIn = " + DistrictId + "," + "@AppIdIN= " + AppId + "," + "@UserId= " + UserId + "";
            var data = _context.SP_ULBADMINMAPAPP.FromSqlRaw(StoredProc).ToList();

            if (data != null && data.Count > 0)
            {
                foreach (var item in data)
                {
                    mapDetail.TotalHouse += item.TotalHouse ?? 0;
                    mapDetail.TotalHouseScan += item.TotalHouseScan ?? 0;
                    mapDetail.TotalLiquid += item.TotalLiquid ?? 0;
                    mapDetail.TotalLiquidScan += item.TotalLiquidScan ?? 0;
                    mapDetail.TotalStreet += item.TotalStreet ?? 0;
                    mapDetail.TotalStreetScan += item.TotalStreetScan ?? 0;
                    mapDetail.TotalDump += item.TotalDump ?? 0;
                    mapDetail.TotalDumpScan += item.TotalDumpScan ?? 0;

                }
                mapDetail.ListMapDetails = data.Select(x => new AdminMapULBDetailsIteam()
                {
                    ULBId = x.ULBId,
                    ULBName = x.ULBName,
                    TotalHouse = x.TotalHouse,
                    TotalHouseScan = x.TotalHouseScan,
                    TotalLiquid = x.TotalLiquid,
                    TotalLiquidScan = x.TotalLiquidScan,
                    TotalStreet = x.TotalStreet,
                    TotalStreetScan = x.TotalStreetScan,
                    TotalDump = x.TotalDump,
                    TotalDumpScan = x.TotalDumpScan,
                    ParentULB = x.ParentULB
                })
                .ToList();
            }
            return View(mapDetail);
        }
        public IActionResult Thane(int DivisionId = 0, int DistrictId = 0, int AppId = 0, int UserId = 1)
        {
            AdminMapULBDetails mapDetail = new AdminMapULBDetails();
            List<AdminMapULBDetailsIteam> ListMapItems = new List<AdminMapULBDetailsIteam>();
            string StoredProc = "exec SP_ULBADMINMAPThane " + "@DivisionIdIn = " + DivisionId + "," + "@DistrictIdIn = " + DistrictId + "," + "@AppIdIN= " + AppId + "," + "@UserId= " + UserId + "";
            var data = _context.SP_ULBADMINMAPThane.FromSqlRaw(StoredProc).ToList();

            if (data != null && data.Count > 0)
            {
                foreach (var item in data)
                {
                    mapDetail.TotalHouse += item.TotalHouse ?? 0;
                    mapDetail.TotalHouseScan += item.TotalHouseScan ?? 0;
                    mapDetail.TotalLiquid += item.TotalLiquid ?? 0;
                    mapDetail.TotalLiquidScan += item.TotalLiquidScan ?? 0;
                    mapDetail.TotalStreet += item.TotalStreet ?? 0;
                    mapDetail.TotalStreetScan += item.TotalStreetScan ?? 0;
                    mapDetail.TotalDump += item.TotalDump ?? 0;
                    mapDetail.TotalDumpScan += item.TotalDumpScan ?? 0;
                    mapDetail.TotalCTPT += item.TotalCTPT ?? 0;
                    mapDetail.TotalCTPTScan += item.TotalCTPTScan ?? 0;
                    mapDetail.TotalCommercial += item.TotalCommercial ?? 0;
                    mapDetail.TotalCommercialScan += item.TotalCommercialScan ?? 0;
                    mapDetail.TotalSWM += item.TotalSWM ?? 0;
                    mapDetail.TotalSWMScan += item.TotalSWMScan ?? 0;


                }
                mapDetail.ListMapDetails = data.Select(x => new AdminMapULBDetailsIteam()
                {
                    ULBId = x.ULBId,
                    ULBName = x.ULBName,
                    TotalHouse = x.TotalHouse,
                    TotalHouseScan = x.TotalHouseScan,
                    TotalLiquid = x.TotalLiquid,
                    TotalLiquidScan = x.TotalLiquidScan,
                    TotalStreet = x.TotalStreet,
                    TotalStreetScan = x.TotalStreetScan,
                    TotalDump = x.TotalDump,
                    TotalDumpScan = x.TotalDumpScan,
                    TotalCTPT = x.TotalCTPT,
                    TotalCTPTScan = x.TotalCTPTScan,
                    TotalCommercial = x.TotalCommercial,
                    TotalCommercialScan = x.TotalCommercialScan,
                    TotalSWM = x.TotalSWM,
                    TotalSWMScan = x.TotalSWMScan,
                    ParentULB = x.ParentULB
                })
                .ToList();
            }
            return View(mapDetail);
        }

        public IActionResult Ahmadnagar(int DivisionId = 0, int DistrictId = 0, int AppId = 0, int UserId = 1)
        {
            AdminMapULBDetails mapDetail = new AdminMapULBDetails();
            List<AdminMapULBDetailsIteam> ListMapItems = new List<AdminMapULBDetailsIteam>();
            string StoredProc = "exec SP_ULBADMINMAPAPP " + "@DivisionIdIn = " + DivisionId + "," + "@DistrictIdIn = " + DistrictId + "," + "@AppIdIN= " + AppId + "," + "@UserId= " + UserId + "";
            var data = _context.SP_ULBADMINMAPAPP.FromSqlRaw(StoredProc).ToList();

            if (data != null && data.Count > 0)
            {
                foreach (var item in data)
                {
                    mapDetail.TotalHouse += item.TotalHouse ?? 0;
                    mapDetail.TotalHouseScan += item.TotalHouseScan ?? 0;
                    mapDetail.TotalLiquid += item.TotalLiquid ?? 0;
                    mapDetail.TotalLiquidScan += item.TotalLiquidScan ?? 0;
                    mapDetail.TotalStreet += item.TotalStreet ?? 0;
                    mapDetail.TotalStreetScan += item.TotalStreetScan ?? 0;
                    mapDetail.TotalDump += item.TotalDump ?? 0;
                    mapDetail.TotalDumpScan += item.TotalDumpScan ?? 0;

                }
                mapDetail.ListMapDetails = data.Select(x => new AdminMapULBDetailsIteam()
                {
                    ULBId = x.ULBId,
                    ULBName = x.ULBName,
                    TotalHouse = x.TotalHouse,
                    TotalHouseScan = x.TotalHouseScan,
                    TotalLiquid = x.TotalLiquid,
                    TotalLiquidScan = x.TotalLiquidScan,
                    TotalStreet = x.TotalStreet,
                    TotalStreetScan = x.TotalStreetScan,
                    TotalDump = x.TotalDump,
                    TotalDumpScan = x.TotalDumpScan,
                    ParentULB = x.ParentULB
                })
                .ToList();
            }
            return View(mapDetail);
        }

        public IActionResult Chandrapur(int DivisionId = 0, int DistrictId = 0, int AppId = 0, int UserId = 1)
        {
            AdminMapULBDetails mapDetail = new AdminMapULBDetails();
            List<AdminMapULBDetailsIteam> ListMapItems = new List<AdminMapULBDetailsIteam>();
            string StoredProc = "exec SP_ULBADMINMAPAPP " + "@DivisionIdIn = " + DivisionId + "," + "@DistrictIdIn = " + DistrictId + "," + "@AppIdIN= " + AppId + "," + "@UserId= " + UserId + "";
            var data = _context.SP_ULBADMINMAPAPP.FromSqlRaw(StoredProc).ToList();

            if (data != null && data.Count > 0)
            {
                foreach (var item in data)
                {
                    mapDetail.TotalHouse += item.TotalHouse ?? 0;
                    mapDetail.TotalHouseScan += item.TotalHouseScan ?? 0;
                    mapDetail.TotalLiquid += item.TotalLiquid ?? 0;
                    mapDetail.TotalLiquidScan += item.TotalLiquidScan ?? 0;
                    mapDetail.TotalStreet += item.TotalStreet ?? 0;
                    mapDetail.TotalStreetScan += item.TotalStreetScan ?? 0;
                    mapDetail.TotalDump += item.TotalDump ?? 0;
                    mapDetail.TotalDumpScan += item.TotalDumpScan ?? 0;

                }
                mapDetail.ListMapDetails = data.Select(x => new AdminMapULBDetailsIteam()
                {
                    ULBId = x.ULBId,
                    ULBName = x.ULBName,
                    TotalHouse = x.TotalHouse,
                    TotalHouseScan = x.TotalHouseScan,
                    TotalLiquid = x.TotalLiquid,
                    TotalLiquidScan = x.TotalLiquidScan,
                    TotalStreet = x.TotalStreet,
                    TotalStreetScan = x.TotalStreetScan,
                    TotalDump = x.TotalDump,
                    TotalDumpScan = x.TotalDumpScan,
                    ParentULB = x.ParentULB
                })
                .ToList();
            }
            return View(mapDetail);
        }

        public IActionResult Nashik(int DivisionId = 0, int DistrictId = 0, int AppId = 0, int UserId = 1)
        {
            AdminMapULBDetails mapDetail = new AdminMapULBDetails();
            List<AdminMapULBDetailsIteam> ListMapItems = new List<AdminMapULBDetailsIteam>();
            string StoredProc = "exec SP_ULBADMINMAPAPP " + "@DivisionIdIn = " + DivisionId + "," + "@DistrictIdIn = " + DistrictId + "," + "@AppIdIN= " + AppId + "," + "@UserId= " + UserId + "";
            var data = _context.SP_ULBADMINMAPAPP.FromSqlRaw(StoredProc).ToList();

            if (data != null && data.Count > 0)
            {
                foreach (var item in data)
                {
                    mapDetail.TotalHouse += item.TotalHouse ?? 0;
                    mapDetail.TotalHouseScan += item.TotalHouseScan ?? 0;
                    mapDetail.TotalLiquid += item.TotalLiquid ?? 0;
                    mapDetail.TotalLiquidScan += item.TotalLiquidScan ?? 0;
                    mapDetail.TotalStreet += item.TotalStreet ?? 0;
                    mapDetail.TotalStreetScan += item.TotalStreetScan ?? 0;
                    mapDetail.TotalDump += item.TotalDump ?? 0;
                    mapDetail.TotalDumpScan += item.TotalDumpScan ?? 0;

                }
                mapDetail.ListMapDetails = data.Select(x => new AdminMapULBDetailsIteam()
                {
                    ULBId = x.ULBId,
                    ULBName = x.ULBName,
                    TotalHouse = x.TotalHouse,
                    TotalHouseScan = x.TotalHouseScan,
                    TotalLiquid = x.TotalLiquid,
                    TotalLiquidScan = x.TotalLiquidScan,
                    TotalStreet = x.TotalStreet,
                    TotalStreetScan = x.TotalStreetScan,
                    TotalDump = x.TotalDump,
                    TotalDumpScan = x.TotalDumpScan,
                    ParentULB = x.ParentULB
                })
                .ToList();
            }
            return View(mapDetail);
        }


        public IActionResult Amravati(int DivisionId = 0, int DistrictId = 0, int AppId = 0, int UserId = 1)
        {
            AdminMapULBDetails mapDetail = new AdminMapULBDetails();
            List<AdminMapULBDetailsIteam> ListMapItems = new List<AdminMapULBDetailsIteam>();
            string StoredProc = "exec SP_ULBADMINMAPAPP " + "@DivisionIdIn = " + DivisionId + "," + "@DistrictIdIn = " + DistrictId + "," + "@AppIdIN= " + AppId + "," + "@UserId= " + UserId + "";
            var data = _context.SP_ULBADMINMAPAPP.FromSqlRaw(StoredProc).ToList();

            if (data != null && data.Count > 0)
            {
                foreach (var item in data)
                {
                    mapDetail.TotalHouse += item.TotalHouse ?? 0;
                    mapDetail.TotalHouseScan += item.TotalHouseScan ?? 0;
                    mapDetail.TotalLiquid += item.TotalLiquid ?? 0;
                    mapDetail.TotalLiquidScan += item.TotalLiquidScan ?? 0;
                    mapDetail.TotalStreet += item.TotalStreet ?? 0;
                    mapDetail.TotalStreetScan += item.TotalStreetScan ?? 0;
                    mapDetail.TotalDump += item.TotalDump ?? 0;
                    mapDetail.TotalDumpScan += item.TotalDumpScan ?? 0;

                }
                mapDetail.ListMapDetails = data.Select(x => new AdminMapULBDetailsIteam()
                {
                    ULBId = x.ULBId,
                    ULBName = x.ULBName,
                    TotalHouse = x.TotalHouse,
                    TotalHouseScan = x.TotalHouseScan,
                    TotalLiquid = x.TotalLiquid,
                    TotalLiquidScan = x.TotalLiquidScan,
                    TotalStreet = x.TotalStreet,
                    TotalStreetScan = x.TotalStreetScan,
                    TotalDump = x.TotalDump,
                    TotalDumpScan = x.TotalDumpScan,
                    ParentULB = x.ParentULB
                })
                .ToList();
            }
            return View(mapDetail);
        }
        public IActionResult Bhandara(int DivisionId = 0, int DistrictId = 0, int AppId = 0, int UserId = 1)
        {
            AdminMapULBDetails mapDetail = new AdminMapULBDetails();
            List<AdminMapULBDetailsIteam> ListMapItems = new List<AdminMapULBDetailsIteam>();
            string StoredProc = "exec SP_ULBADMINMAPAPP " + "@DivisionIdIn = " + DivisionId + "," + "@DistrictIdIn = " + DistrictId + "," + "@AppIdIN= " + AppId + "," + "@UserId= " + UserId + "";
            var data = _context.SP_ULBADMINMAPAPP.FromSqlRaw(StoredProc).ToList();

            if (data != null && data.Count > 0)
            {
                foreach (var item in data)
                {
                    mapDetail.TotalHouse += item.TotalHouse ?? 0;
                    mapDetail.TotalHouseScan += item.TotalHouseScan ?? 0;
                    mapDetail.TotalLiquid += item.TotalLiquid ?? 0;
                    mapDetail.TotalLiquidScan += item.TotalLiquidScan ?? 0;
                    mapDetail.TotalStreet += item.TotalStreet ?? 0;
                    mapDetail.TotalStreetScan += item.TotalStreetScan ?? 0;
                    mapDetail.TotalDump += item.TotalDump ?? 0;
                    mapDetail.TotalDumpScan += item.TotalDumpScan ?? 0;

                }
                mapDetail.ListMapDetails = data.Select(x => new AdminMapULBDetailsIteam()
                {
                    ULBId = x.ULBId,
                    ULBName = x.ULBName,
                    TotalHouse = x.TotalHouse,
                    TotalHouseScan = x.TotalHouseScan,
                    TotalLiquid = x.TotalLiquid,
                    TotalLiquidScan = x.TotalLiquidScan,
                    TotalStreet = x.TotalStreet,
                    TotalStreetScan = x.TotalStreetScan,
                    TotalDump = x.TotalDump,
                    TotalDumpScan = x.TotalDumpScan,
                    ParentULB = x.ParentULB
                })
                .ToList();
            }
            return View(mapDetail);
        }

        public IActionResult Khamgaon(int DivisionId = 0, int DistrictId = 0, int AppId = 0, int UserId = 1)
        {
            AdminMapULBDetails mapDetail = new AdminMapULBDetails();
            List<AdminMapULBDetailsIteam> ListMapItems = new List<AdminMapULBDetailsIteam>();
            string StoredProc = "exec SP_ULBADMINMAPAPP " + "@DivisionIdIn = " + DivisionId + "," + "@DistrictIdIn = " + DistrictId + "," + "@AppIdIN= " + AppId + "," + "@UserId= " + UserId + "";
            var data = _context.SP_ULBADMINMAPAPP.FromSqlRaw(StoredProc).ToList();

            if (data != null && data.Count > 0)
            {
                foreach (var item in data)
                {
                    mapDetail.TotalHouse += item.TotalHouse ?? 0;
                    mapDetail.TotalHouseScan += item.TotalHouseScan ?? 0;
                    mapDetail.TotalLiquid += item.TotalLiquid ?? 0;
                    mapDetail.TotalLiquidScan += item.TotalLiquidScan ?? 0;
                    mapDetail.TotalStreet += item.TotalStreet ?? 0;
                    mapDetail.TotalStreetScan += item.TotalStreetScan ?? 0;
                    mapDetail.TotalDump += item.TotalDump ?? 0;
                    mapDetail.TotalDumpScan += item.TotalDumpScan ?? 0;

                }
                mapDetail.ListMapDetails = data.Select(x => new AdminMapULBDetailsIteam()
                {
                    ULBId = x.ULBId,
                    ULBName = x.ULBName,
                    TotalHouse = x.TotalHouse,
                    TotalHouseScan = x.TotalHouseScan,
                    TotalLiquid = x.TotalLiquid,
                    TotalLiquidScan = x.TotalLiquidScan,
                    TotalStreet = x.TotalStreet,
                    TotalStreetScan = x.TotalStreetScan,
                    TotalDump = x.TotalDump,
                    TotalDumpScan = x.TotalDumpScan,
                    ParentULB = x.ParentULB
                })
                .ToList();
            }
            return View(mapDetail);
        }

        public IActionResult Parbhani(int DivisionId = 0, int DistrictId = 0, int AppId = 0, int UserId = 1)
        {
            AdminMapULBDetails mapDetail = new AdminMapULBDetails();
            List<AdminMapULBDetailsIteam> ListMapItems = new List<AdminMapULBDetailsIteam>();
            string StoredProc = "exec SP_ULBADMINMAPAPP " + "@DivisionIdIn = " + DivisionId + "," + "@DistrictIdIn = " + DistrictId + "," + "@AppIdIN= " + AppId + "," + "@UserId= " + UserId + "";
            var data = _context.SP_ULBADMINMAPAPP.FromSqlRaw(StoredProc).ToList();

            if (data != null && data.Count > 0)
            {
                foreach (var item in data)
                {
                    mapDetail.TotalHouse += item.TotalHouse ?? 0;
                    mapDetail.TotalHouseScan += item.TotalHouseScan ?? 0;
                    mapDetail.TotalLiquid += item.TotalLiquid ?? 0;
                    mapDetail.TotalLiquidScan += item.TotalLiquidScan ?? 0;
                    mapDetail.TotalStreet += item.TotalStreet ?? 0;
                    mapDetail.TotalStreetScan += item.TotalStreetScan ?? 0;
                    mapDetail.TotalDump += item.TotalDump ?? 0;
                    mapDetail.TotalDumpScan += item.TotalDumpScan ?? 0;

                }
                mapDetail.ListMapDetails = data.Select(x => new AdminMapULBDetailsIteam()
                {
                    ULBId = x.ULBId,
                    ULBName = x.ULBName,
                    TotalHouse = x.TotalHouse,
                    TotalHouseScan = x.TotalHouseScan,
                    TotalLiquid = x.TotalLiquid,
                    TotalLiquidScan = x.TotalLiquidScan,
                    TotalStreet = x.TotalStreet,
                    TotalStreetScan = x.TotalStreetScan,
                    TotalDump = x.TotalDump,
                    TotalDumpScan = x.TotalDumpScan,
                    ParentULB = x.ParentULB
                })
                .ToList();
            }
            return View(mapDetail);
        }
        public IActionResult Solapur(int DivisionId = 0, int DistrictId = 0, int AppId = 0, int UserId = 1)
        {
            AdminMapULBDetails mapDetail = new AdminMapULBDetails();
            List<AdminMapULBDetailsIteam> ListMapItems = new List<AdminMapULBDetailsIteam>();
            string StoredProc = "exec SP_ULBADMINMAPAPP " + "@DivisionIdIn = " + DivisionId + "," + "@DistrictIdIn = " + DistrictId + "," + "@AppIdIN= " + AppId + "," + "@UserId= " + UserId + "";
            var data = _context.SP_ULBADMINMAPAPP.FromSqlRaw(StoredProc).ToList();

            if (data != null && data.Count > 0)
            {
                foreach (var item in data)
                {
                    mapDetail.TotalHouse += item.TotalHouse ?? 0;
                    mapDetail.TotalHouseScan += item.TotalHouseScan ?? 0;
                    mapDetail.TotalLiquid += item.TotalLiquid ?? 0;
                    mapDetail.TotalLiquidScan += item.TotalLiquidScan ?? 0;
                    mapDetail.TotalStreet += item.TotalStreet ?? 0;
                    mapDetail.TotalStreetScan += item.TotalStreetScan ?? 0;
                    mapDetail.TotalDump += item.TotalDump ?? 0;
                    mapDetail.TotalDumpScan += item.TotalDumpScan ?? 0;

                }
                mapDetail.ListMapDetails = data.Select(x => new AdminMapULBDetailsIteam()
                {
                    ULBId = x.ULBId,
                    ULBName = x.ULBName,
                    TotalHouse = x.TotalHouse,
                    TotalHouseScan = x.TotalHouseScan,
                    TotalLiquid = x.TotalLiquid,
                    TotalLiquidScan = x.TotalLiquidScan,
                    TotalStreet = x.TotalStreet,
                    TotalStreetScan = x.TotalStreetScan,
                    TotalDump = x.TotalDump,
                    TotalDumpScan = x.TotalDumpScan,
                    ParentULB = x.ParentULB
                })
                .ToList();
            }
            return View(mapDetail);
        }
        public IActionResult Wardha(int DivisionId = 0, int DistrictId = 0, int AppId = 0, int UserId = 1)
        {
            AdminMapULBDetails mapDetail = new AdminMapULBDetails();
            List<AdminMapULBDetailsIteam> ListMapItems = new List<AdminMapULBDetailsIteam>();
            string StoredProc = "exec SP_ULBADMINMAPAPP " + "@DivisionIdIn = " + DivisionId + "," + "@DistrictIdIn = " + DistrictId + "," + "@AppIdIN= " + AppId + "," + "@UserId= " + UserId + "";
            var data = _context.SP_ULBADMINMAPAPP.FromSqlRaw(StoredProc).ToList();

            if (data != null && data.Count > 0)
            {
                foreach (var item in data)
                {
                    mapDetail.TotalHouse += item.TotalHouse ?? 0;
                    mapDetail.TotalHouseScan += item.TotalHouseScan ?? 0;
                    mapDetail.TotalLiquid += item.TotalLiquid ?? 0;
                    mapDetail.TotalLiquidScan += item.TotalLiquidScan ?? 0;
                    mapDetail.TotalStreet += item.TotalStreet ?? 0;
                    mapDetail.TotalStreetScan += item.TotalStreetScan ?? 0;
                    mapDetail.TotalDump += item.TotalDump ?? 0;
                    mapDetail.TotalDumpScan += item.TotalDumpScan ?? 0;

                }
                mapDetail.ListMapDetails = data.Select(x => new AdminMapULBDetailsIteam()
                {
                    ULBId = x.ULBId,
                    ULBName = x.ULBName,
                    TotalHouse = x.TotalHouse,
                    TotalHouseScan = x.TotalHouseScan,
                    TotalLiquid = x.TotalLiquid,
                    TotalLiquidScan = x.TotalLiquidScan,
                    TotalStreet = x.TotalStreet,
                    TotalStreetScan = x.TotalStreetScan,
                    TotalDump = x.TotalDump,
                    TotalDumpScan = x.TotalDumpScan,
                    ParentULB = x.ParentULB
                })
                .ToList();
            }
            return View(mapDetail);
        }
        public IActionResult Gondia(int DivisionId = 0, int DistrictId = 0, int AppId = 0, int UserId = 1)
        {
            AdminMapULBDetails mapDetail = new AdminMapULBDetails();
            List<AdminMapULBDetailsIteam> ListMapItems = new List<AdminMapULBDetailsIteam>();
            string StoredProc = "exec SP_ULBADMINMAPAPP " + "@DivisionIdIn = " + DivisionId + "," + "@DistrictIdIn = " + DistrictId + "," + "@AppIdIN= " + AppId + "," + "@UserId= " + UserId + "";
            var data = _context.SP_ULBADMINMAPAPP.FromSqlRaw(StoredProc).ToList();

            if (data != null && data.Count > 0)
            {
                foreach (var item in data)
                {
                    mapDetail.TotalHouse += item.TotalHouse ?? 0;
                    mapDetail.TotalHouseScan += item.TotalHouseScan ?? 0;
                    mapDetail.TotalLiquid += item.TotalLiquid ?? 0;
                    mapDetail.TotalLiquidScan += item.TotalLiquidScan ?? 0;
                    mapDetail.TotalStreet += item.TotalStreet ?? 0;
                    mapDetail.TotalStreetScan += item.TotalStreetScan ?? 0;
                    mapDetail.TotalDump += item.TotalDump ?? 0;
                    mapDetail.TotalDumpScan += item.TotalDumpScan ?? 0;

                }
                mapDetail.ListMapDetails = data.Select(x => new AdminMapULBDetailsIteam()
                {
                    ULBId = x.ULBId,
                    ULBName = x.ULBName,
                    TotalHouse = x.TotalHouse,
                    TotalHouseScan = x.TotalHouseScan,
                    TotalLiquid = x.TotalLiquid,
                    TotalLiquidScan = x.TotalLiquidScan,
                    TotalStreet = x.TotalStreet,
                    TotalStreetScan = x.TotalStreetScan,
                    TotalDump = x.TotalDump,
                    TotalDumpScan = x.TotalDumpScan,
                    ParentULB = x.ParentULB
                })
                .ToList();
            }
            return View(mapDetail);
        }

        public IActionResult Pune(int DivisionId = 0, int DistrictId = 0, int AppId = 0, int UserId = 1)
        {
            AdminMapULBDetails mapDetail = new AdminMapULBDetails();
            List<AdminMapULBDetailsIteam> ListMapItems = new List<AdminMapULBDetailsIteam>();
            string StoredProc = "exec SP_ULBADMINMAPAPP " + "@DivisionIdIn = " + DivisionId + "," + "@DistrictIdIn = " + DistrictId + "," + "@AppIdIN= " + AppId + "," + "@UserId= " + UserId + "";
            var data = _context.SP_ULBADMINMAPAPP.FromSqlRaw(StoredProc).ToList();

            if (data != null && data.Count > 0)
            {
                foreach (var item in data)
                {
                    mapDetail.TotalHouse += item.TotalHouse ?? 0;
                    mapDetail.TotalHouseScan += item.TotalHouseScan ?? 0;
                    mapDetail.TotalLiquid += item.TotalLiquid ?? 0;
                    mapDetail.TotalLiquidScan += item.TotalLiquidScan ?? 0;
                    mapDetail.TotalStreet += item.TotalStreet ?? 0;
                    mapDetail.TotalStreetScan += item.TotalStreetScan ?? 0;
                    mapDetail.TotalDump += item.TotalDump ?? 0;
                    mapDetail.TotalDumpScan += item.TotalDumpScan ?? 0;

                }
                mapDetail.ListMapDetails = data.Select(x => new AdminMapULBDetailsIteam()
                {
                    ULBId = x.ULBId,
                    ULBName = x.ULBName,
                    TotalHouse = x.TotalHouse,
                    TotalHouseScan = x.TotalHouseScan,
                    TotalLiquid = x.TotalLiquid,
                    TotalLiquidScan = x.TotalLiquidScan,
                    TotalStreet = x.TotalStreet,
                    TotalStreetScan = x.TotalStreetScan,
                    TotalDump = x.TotalDump,
                    TotalDumpScan = x.TotalDumpScan,
                    ParentULB = x.ParentULB
                })
                .ToList();
            }
            return View(mapDetail);
        }

        public IActionResult Satara(int DivisionId = 0, int DistrictId = 0, int AppId = 0, int UserId = 1)
        {
            AdminMapULBDetails mapDetail = new AdminMapULBDetails();
            List<AdminMapULBDetailsIteam> ListMapItems = new List<AdminMapULBDetailsIteam>();
            string StoredProc = "exec SP_ULBADMINMAPAPP " + "@DivisionIdIn = " + DivisionId + "," + "@DistrictIdIn = " + DistrictId + "," + "@AppIdIN= " + AppId + "," + "@UserId= " + UserId + "";
            var data = _context.SP_ULBADMINMAPAPP.FromSqlRaw(StoredProc).ToList();

            if (data != null && data.Count > 0)
            {
                foreach (var item in data)
                {
                    mapDetail.TotalHouse += item.TotalHouse ?? 0;
                    mapDetail.TotalHouseScan += item.TotalHouseScan ?? 0;
                    mapDetail.TotalLiquid += item.TotalLiquid ?? 0;
                    mapDetail.TotalLiquidScan += item.TotalLiquidScan ?? 0;
                    mapDetail.TotalStreet += item.TotalStreet ?? 0;
                    mapDetail.TotalStreetScan += item.TotalStreetScan ?? 0;
                    mapDetail.TotalDump += item.TotalDump ?? 0;
                    mapDetail.TotalDumpScan += item.TotalDumpScan ?? 0;

                }
                mapDetail.ListMapDetails = data.Select(x => new AdminMapULBDetailsIteam()
                {
                    ULBId = x.ULBId,
                    ULBName = x.ULBName,
                    TotalHouse = x.TotalHouse,
                    TotalHouseScan = x.TotalHouseScan,
                    TotalLiquid = x.TotalLiquid,
                    TotalLiquidScan = x.TotalLiquidScan,
                    TotalStreet = x.TotalStreet,
                    TotalStreetScan = x.TotalStreetScan,
                    TotalDump = x.TotalDump,
                    TotalDumpScan = x.TotalDumpScan,
                    ParentULB = x.ParentULB
                })
                .ToList();
            }
            return View(mapDetail);
        }
        public IActionResult Sangli(int DivisionId = 0, int DistrictId = 0, int AppId = 0, int UserId = 1)
        {
            AdminMapULBDetails mapDetail = new AdminMapULBDetails();
            List<AdminMapULBDetailsIteam> ListMapItems = new List<AdminMapULBDetailsIteam>();
            string StoredProc = "exec SP_ULBADMINMAPAPP " + "@DivisionIdIn = " + DivisionId + "," + "@DistrictIdIn = " + DistrictId + "," + "@AppIdIN= " + AppId + "," + "@UserId= " + UserId + "";
            var data = _context.SP_ULBADMINMAPAPP.FromSqlRaw(StoredProc).ToList();

            if (data != null && data.Count > 0)
            {
                foreach (var item in data)
                {
                    mapDetail.TotalHouse += item.TotalHouse ?? 0;
                    mapDetail.TotalHouseScan += item.TotalHouseScan ?? 0;
                    mapDetail.TotalLiquid += item.TotalLiquid ?? 0;
                    mapDetail.TotalLiquidScan += item.TotalLiquidScan ?? 0;
                    mapDetail.TotalStreet += item.TotalStreet ?? 0;
                    mapDetail.TotalStreetScan += item.TotalStreetScan ?? 0;
                    mapDetail.TotalDump += item.TotalDump ?? 0;
                    mapDetail.TotalDumpScan += item.TotalDumpScan ?? 0;

                }
                mapDetail.ListMapDetails = data.Select(x => new AdminMapULBDetailsIteam()
                {
                    ULBId = x.ULBId,
                    ULBName = x.ULBName,
                    TotalHouse = x.TotalHouse,
                    TotalHouseScan = x.TotalHouseScan,
                    TotalLiquid = x.TotalLiquid,
                    TotalLiquidScan = x.TotalLiquidScan,
                    TotalStreet = x.TotalStreet,
                    TotalStreetScan = x.TotalStreetScan,
                    TotalDump = x.TotalDump,
                    TotalDumpScan = x.TotalDumpScan,
                    ParentULB = x.ParentULB
                })
                .ToList();
            }
            return View(mapDetail);
        }

    }
}
