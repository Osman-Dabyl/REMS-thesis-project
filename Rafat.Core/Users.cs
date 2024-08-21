using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rafat.Core
{
    public class Users
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string FullName { get; set; }
        [Required]
        [MaxLength(50)]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Role { get; set; }
        public bool IsSecondaryUser { get; set; }
        public string UserId{ get; set; }
        [MaxLength(50)]
        [Required]
        public string? Phone{ get; set; }
        [MaxLength(50)]
        public string? Email{ get; set; }
        [MaxLength(50)]
        public string? Address{ get; set; }
        public DateTime CreatedDate{ get; set; }
        public DateTime EditedDate{ get; set; }


       

    }
}
