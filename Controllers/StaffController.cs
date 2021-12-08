using DotNetCoreSQL.Context;
using DotNetCoreSQL.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreSQL.Controllers
{
    public class StaffController : Controller
    {
        readonly StaffDBContext staffDBContext = new StaffDBContext();

        public IActionResult Index()
        {
            List<StaffInfo> StaffInfoList = staffDBContext.GetStaffInfo().ToList();

            return View(StaffInfoList);
        }
    }
}
