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
        public DataGridRequestQueryStringData RequestQueryStringData { get; set; }
        public DataGridResponseData ResponseData { get; set; }
    }

    public class DataGridRequestQueryStringData
    {
        public int Start { get; set; }
        public int Length { get; set; }
        public int Draw { get; set; }
    }

    public class DataGridResponseData
    {
        public int Draw { get; set; }
        public int TotalRecords { get; set; }
        public int RecordsFiltered { get; set; }
        public string Data { get; set; }
    }

    public class DataGridResponse
    {
        public int draw { get; set; }
        public int recordsTotal { get; set; }
        public int recordsFiltered { get; set; }
        public List<CustomerModel> data { get; set; }
    }
}