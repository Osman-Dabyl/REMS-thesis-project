using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rafat.Core
{
    public class Customer
    {

        public int CustomerId { get; set; }

        [MaxLength(50)]
        public string FullName { get; set; }

        [MaxLength(50)]
        public string Phone { get; set; }

        public DateTime AddedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public virtual ICollection<Property> Properties { get; set; } = new List<Property>();

        public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

        public string UserId { get; set; }

        public string DisplayName => $"{FullName.Trim().Split(' ').FirstOrDefault()}";


    }
}
