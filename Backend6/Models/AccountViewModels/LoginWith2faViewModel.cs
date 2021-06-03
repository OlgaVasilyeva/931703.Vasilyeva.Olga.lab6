using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Backend6.Models.AccountViewModels
{
    public class LoginWith2faViewModel
    {
        [Required]
        [StringLength(7, ErrorMessage = "{0} должен содержать не менее {2} и не более {1} символов.", MinimumLength = 6)]
        [DataType(DataType.Text)]
        [Display(Name = "Код аутентификатора")]
        public string TwoFactorCode { get; set; }

        [Display(Name = "Запомнить эту машину")]
        public bool RememberMachine { get; set; }

        public bool RememberMe { get; set; }
    }
}
