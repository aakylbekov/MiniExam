using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Miniexam.Models
{

    public class MustBeTrueAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            return value is bool && (bool)value;
        }
    }

    public class FutureAttribute : RequiredAttribute
    {
        public override bool IsValid(object value)
        {
            return base.IsValid(value) && value is DateTime && ((DateTime)value) > DateTime.Now;
        }
    }

    public class AppointemntValidationAttribute : ValidationAttribute
    {
        public AppointemntValidationAttribute()
        {
            ErrorMessage = "Нельзя регистрировать компании конкурентов";
        }
        public override bool IsValid(object value)
        {

            CompanyName company = value as CompanyName;
            if (company.Name.Contains("Beeline"))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}