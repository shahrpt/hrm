﻿using System.Web.Mvc;
using Frapid.Areas;
using Frapid.Dashboard;
using Frapid.Dashboard.Controllers;
using Frapid.DataAccess.Models;

namespace MixERP.HRM.Controllers.Setup
{
    public class ShiftController : DashboardController
    {
        [Route("dashboard/hrm/setup/shifts")]
        [MenuPolicy]
        [ScrudFactory]
        [AccessPolicy("hrm", "shifts", AccessTypeEnum.Read)]
        public ActionResult Index()
        {
            return this.FrapidView(this.GetRazorView<AreaRegistration>("Setup/Shifts/Index.cshtml", this.Tenant));
        }
    }
}