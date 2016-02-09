using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataGrid.Models;
using Newtonsoft.Json;

namespace DataGrid.Controllers
{
    public class DataGridController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult FillGrid(int draw, int start, int length,int playWith)
        {
            DataGridResponse resp=new DataGridResponse();
            resp.draw = draw;
            resp.recordsTotal = playWith;
            resp.recordsFiltered = playWith;
            resp.data = new CustomerDataGenerator().GenerateCustomerList(start,length,playWith);

            return Json(resp, JsonRequestBehavior.AllowGet);
        }

    }
}