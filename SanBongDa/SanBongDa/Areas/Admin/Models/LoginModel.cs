using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
namespace SanBongDa.Areas.Admin.Models
{
    public class LoginModel
    {
        [Required]
        public String TenTK { set; get; }
        public String PW { set; get; }
        public String RememberMe { set; get; }
    }
}