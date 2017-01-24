using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceSite.Domain.Entities
{
    public class User
    {
        [Key]
        public string UserId { get; set; }
        public string Password { get; set; }
    }
}
