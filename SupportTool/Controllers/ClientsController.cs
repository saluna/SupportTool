using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using SupportTool.Models;
using SupportTool.Models.ClientInfo;

namespace SupportTool.Controllers
{
    public class ClientsController : Controller
    {

        private ClientsDbContext _context;

        public ClientsController()
        {
                _context = new ClientsDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Clients
        public ActionResult Index()
        {
            // list all clients at once
            var AllClients = _context.Clients.ToList();

            return View(AllClients);
        }

        // GET: Clients/Details
        public ActionResult Details(string ClientID)
        {

            var clientConnectivity = _context.ClientDetails.ToList();

            return View(clientConnectivity);
        }
    }
}