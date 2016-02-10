using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataGrid.Models
{
    /// <summary>
    /// grid model for datatables.js
    /// </summary>
    public class DataGridModel
    {
    }

    public class DataGridRequestQueryString
    {
        public int start { get; set; }
        public int length { get; set; }
        public int draw { get; set; }
        public int playWith { get; set; }
        public int orderedColumnIndex { get; set; }
        public string orderedColumnName { get; set; }
        public string orderBy { get; set; }  //asc - desc?
    }

    public class DataGridResponse
    {
        public int draw { get; set; }
        public int recordsTotal { get; set; }
        public int recordsFiltered { get; set; }
        public List<CustomerModel> data { get; set; }
    }

    public enum DataGridOrderType
    {
        Asc,
        Desc
    }
}