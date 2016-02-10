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

        /// <summary>
        /// xhr method that works with dataTables.js server side table
        /// </summary>
        /// <param name="queryString"></param>
        /// <returns></returns>
        public ActionResult FillDataGrid(DataGridRequestQueryString queryString)
        {
            queryString.orderedColumnIndex = Int32.Parse(Request.QueryString["order[0][column]"]);

            var columnNameIdentifier = string.Format("columns[{0}][data]", queryString.orderedColumnIndex);
            queryString.orderedColumnName = Request.QueryString[columnNameIdentifier];
        
            queryString.orderBy = Request.QueryString["order[0][dir]"];

            DataGridResponse resp = new DataGridResponse
            {
                draw = queryString.draw,
                recordsTotal = queryString.playWith,
                recordsFiltered = queryString.playWith,
                data = new CustomerDataGenerator().GenerateCustomerList(queryString)
            };

            return Json(resp, JsonRequestBehavior.AllowGet);
        }

    }
}