using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rafat.Core
{
    public class Agent
    {
        public int AgentId { get; set; }
        [Required]
        [MaxLength(50)]
        public string FullName { get; set; }
        [Required]
        [MaxLength(50)]
        public string Phone { get; set; }
        public DateTime AddedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }
        //Navigation

        public virtual ICollection<Property> Properties { get; set; } = new List<Property>();

        public string UserId { get; set; }

        public string DisplayName => $"{FullName.Trim().Split(' ').FirstOrDefault()}";
    }
}
