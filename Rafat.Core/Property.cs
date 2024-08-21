using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Rafat.Core.Enums;
using static Rafat.Core.Enums.Listing_Type;
using static Rafat.Core.Enums.Property_Stutus;
using static Rafat.Core.Enums.Property_Type;

namespace Rafat.Core
{
    public class Property
    {
        public int PropertyId { get; set; }
        [Required]
        [MaxLength(50)]
        public string PropertyName { get; set; }
       
        public decimal Price { get; set; }
        [MaxLength(10)]
        public PropertyType PType { get; set; }
        [MaxLength(10)]
        public PropertyStatus Status { get; set; }
        [MaxLength(10)]
        public ListingType Listing { get; set; }

        [MaxLength(255)]
        public string Description { get; set; }

        public DateTime AddedDate { get; set; }

        public DateTime UpDatedDate { get; set; }
   
        public float Longitude { get; set; }
   
        public float Latitude { get; set; }

        //Navigation

        public string DisplayName => $"{PropertyName} (ID: {PropertyId})";

        public string UserId { get; set; }

        public int AgentId { get; set; }

        public virtual Agent Agent { get; set; }

        public virtual ICollection<PropertyFile> PropertyFiles { get; set; } = new List<PropertyFile>();

        public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
