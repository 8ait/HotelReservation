using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HotelReservation.Common.Interfaces;
using Newtonsoft.Json;

namespace HotelReservation.Controllers
{
    public class ClientController : Controller
    {
        private IData _data;
        private const int _itemsOnPage = 7;

        public ClientController(IData data)
        {
            _data = data;
        }
        // GET: Client
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult LoadPage(int page = 1)
        {
            ViewData["Clients"] = _data.GetClientsOnPage(page, _itemsOnPage);
            ViewData["CurrentPage"] = _data.GetValidatePageClient(page, _itemsOnPage);
            ViewData["Pages"] = _data.GetCountOfPagesClient(_itemsOnPage);
            return PartialView();
        }

        public ActionResult DeleteClient(int id, int page)
        {
            _data.DeleteClient(id);
            return RedirectToAction("LoadPage", new { page = page });
        }

        /*public JsonResult ValidateSerial(int serial)
        {
            var answer = new JsonHelper() {
                Id = "404",
                Code = "error"
            };

            var jsonAnswer = JsonConvert.SerializeObject(answer);

            return jsonAnswer;
        } */

        public ActionResult CreateClient(string firstName, string secondName, long serial, int sex, string dateOfBorn)
        {
            _data.CreateClient(firstName, secondName, serial, sex, dateOfBorn);
            return RedirectToAction("LoadPage", new { page = _data.GetCountOfPagesClient(_itemsOnPage) });
        }
    }
}