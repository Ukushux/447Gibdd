using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace _447Gibdd.Classes.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(64)]
        public string SurName { get; set;}
        [Required, MaxLength(32)]
        public string FirstName { get; set; }
        [Required, MaxLength(64)]
        public string LastName { get; set; }
        [MaxLength(64)]
        public string Login { get; set; }
        [Required, MaxLength(32)]
        public string pass { get; set; }
    }
}
