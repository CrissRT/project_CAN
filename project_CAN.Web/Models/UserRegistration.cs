using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace project_CAN.Web.Models
{
    public class UserRegistration
    {
        [Required]
        [Display(Name = "Username sau Email")]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Parola")]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Repeta Parola")]
        public string RepeatPassword { get; set; }
    }
}