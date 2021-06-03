using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Backend6.Models.ManageViewModels
{
    public class SetPasswordViewModel
    {
        [Required]
        [StringLength(20, ErrorMessage = "{0} должен содержать не менее {2} и не более {1} символов.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "New password")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm new password")]
        [Compare("NewPassword", ErrorMessage = "Новый пароль и пароль подтверждения не совпадают.")]
        public string ConfirmPassword { get; set; }

        public string StatusMessage { get; set; }
    }
}
