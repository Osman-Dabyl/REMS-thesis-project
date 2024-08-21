using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rafat.Core.Enums;
using static Rafat.Core.Enums.Order_Status;
using static Rafat.Core.Enums.Oreder_Type;

namespace Rafat.Core
{
    public  class Order
    {
        public int OrderId { get; set; }

        public int PropertyId { get; set; }

        public int CustomerId { get; set; }

        public DateTime OrderDate { get; set; }

        [MaxLength(10)]
        public OrderType Ordertype { get; set; } 

        public decimal? SalePrice { get; set; }

        public DateTime? RentStartDate { get; set; }

        public DateTime? RentEndDate { get; set; }

        public decimal? RentAmount { get; set; }

        public decimal? Balance { get; set; }

        //Navigation
        [MaxLength(10)]
        public OrderStatus? Status { get; set; } 

        public virtual Customer Customer { get; set; }

        public virtual Property Property { get; set; }

        public string UserId { get; set; }

    }
}
