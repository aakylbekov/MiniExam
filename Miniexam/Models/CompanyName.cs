using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Miniexam.Models
{
    public class CompanyName  
    {
        // GET: CompanyName
         
        [Display(Name = "Name")]
        public string Name { get; set; }

         
        [DataType(DataType.EmailAddress)]
        [Display(Name = "email")]
        [Remote("IsExistsEmail", "Home", ErrorMessage = "Email already exists")]
        public string EmailAddress { get; set; }

        [Range(typeof(bool), "true", "true", ErrorMessage = "Accept the aggrement")]
        [MustBeTrue(ErrorMessage = "You should confirm agreements")]
        public bool TermsAccepted { get; set; }
        [DataType(DataType.Date)]
        [Future(ErrorMessage = "Future date")]
        public DateTime RegistrateDate { get; set; }
    }
}