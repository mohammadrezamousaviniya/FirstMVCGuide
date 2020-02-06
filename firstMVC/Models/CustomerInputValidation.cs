using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Microsoft.Ajax.Utilities;

namespace firstMVC.Models
{
    public class CustomerInputValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value,ValidationContext _VC)
        {
            var customer = (CustomerStruct) _VC.ObjectInstance;
            if (!customer.name.Contains("@"))
            {
                return new ValidationResult("نام کاربری درست وارد نشده است");
            }

            return ValidationResult.Success;
        }
    }
}