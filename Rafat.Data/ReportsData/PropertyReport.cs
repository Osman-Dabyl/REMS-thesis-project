using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Rafat.Core.Enums.Listing_Type;
using static Rafat.Core.Enums.Property_Type;

namespace Rafat.Data.ReportsData
{
   public class PropertyReport
    {

        public int Propid { get; set; }
        public decimal Price { get; set; } 

        public string? AgentInfo { get; set; }

        public string? Ptype { get; set; }

        public ListingType? Linsting { get; set; }

        public string? UserName { get; set; }
        public DateTime addedDate { get; set; }

        public string proptype => Ptype.ToString();




    }
}
