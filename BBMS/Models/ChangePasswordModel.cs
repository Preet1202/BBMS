using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BBMS.Models
{
    public class ChangePasswordModel
    {
        [Required(ErrorMessage = "Please Enter Current Password"), Display(Name = "Current Password"), DataType(DataType.Password)]
        public string CurrentPassword { get; set; }

        [Required(ErrorMessage = "New Password"), Display(Name = "Current Password"), DataType(DataType.Password)]
        public string NewPassword { get; set; }

        [Required, Display(Name = "Confirm Password"), DataType(DataType.Password), Compare("NewPassword", ErrorMessage = "Password Not Match")]
        public string ConfirmPassword { get; set; }
    }
}
