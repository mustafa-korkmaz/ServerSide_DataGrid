using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataGrid.ViewModels;
using Newtonsoft.Json;

namespace DataGrid.Controllers
{
    public class DataGridController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult FillGrid(DataGridRequestQueryString queryString, int rideWith)
        {
            DataGridResponseViewModel resp = GetResponse(queryString, rideWith);

            return Json(resp, JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// assume that tihs data comes from business layer.
        /// </summary>
        /// <param name="queryString"></param>
        /// <returns></returns>
        private DataGridResponseViewModel GetResponse(DataGridRequestQueryString queryString, int rideWith)
        {
            DataGridResponseViewModel model = new DataGridResponseViewModel(queryString);
            
            model.recordsTotal = rideWith;
            model.data = new CustomerDataGenerator().GenerateCustomerList(queryString,rideWith);
      
            return model;
        }

    }
}