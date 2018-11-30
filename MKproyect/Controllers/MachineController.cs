using Microsoft.AspNet.SignalR;
using MKproyect.Models;
using SignalRChatServer.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MKproyect.Controllers
{
    public class MachineController : Controller
    {

        IHubContext signalHub = GlobalHost.ConnectionManager.GetHubContext<SignalHub>();
        // GET: Machine
        [HttpPost]
        public JsonResult Data( Billing dataBill)
        {

            signalHub.Clients.Group(dataBill.key).getBill(dataBill);
            

            return Json(new { proseced = true });


        }

        // GET: Machine/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Machine/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Machine/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Machine/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Machine/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Machine/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Machine/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
