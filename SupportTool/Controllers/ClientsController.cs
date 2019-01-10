using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SupportTool.Models;
using SupportTool.Models.ClientInfo;

namespace SupportTool.Controllers
{
    public class ClientsController : Controller
    {
        // GET: Clients
        public ActionResult Index()
        {
            var testClient = new Clients() {ClientName = "test Client"};

            return View(testClient);
        }
    }
}