using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ECommerceSite.WebUI.Models
{
    public class LoginVM
    {
        [Required(ErrorMessage ="User name is required")]
        public string UserName { get; set; }
        [Required(ErrorMessage ="Password is required")]
        [StringLength(50, MinimumLength = 6)]
        public string Password { get; set; }
    }
}