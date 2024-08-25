using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rafat.Data.ReportsData
{
    public class SalesReport
    {

        public int PropId { get; set; }

        public double SalePrice { get; set; }

        public string? BuyerInfo { get; set; }

        public string? SallerInfo { get; set; }

        public DateTime SaleDate { get; set; }


    }
}
