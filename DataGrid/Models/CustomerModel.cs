using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataGrid.Models
{
    /// <summary>
    /// Customer class  
    /// </summary>
    public class CustomerModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public string Office { get; set; }
        public string StartDate { get; set; }
        public decimal Salary { get; set; }
    }

}