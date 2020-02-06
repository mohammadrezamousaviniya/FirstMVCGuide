using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace firstMVC.Models
{
    public class CustomerStruct
    {
        public int id { set; get; }
        [StringLength(125)]
        [CustomerInputValidation]
        [Required(ErrorMessage = "pleasssssssssssse Fill This Input")]
        public string name { set; get; }
        [Required]
        [StringLength(255)]
        public string password { set; get; }
    }
}