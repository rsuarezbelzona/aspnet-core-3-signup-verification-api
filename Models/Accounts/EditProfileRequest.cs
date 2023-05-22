using BusinessLib.Distributors.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiAuthentication.Models.Accounts
{
    public class EditProfileRequest
    {
        [Required]
        public string FullName { get; set; }

        [Required]
        public string CompanyName { get; set; }

        [Required]
        public DistributorFindFormDTO FindDistributor { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        [Required]
        [MinLength(6)]
        public string Password { get; set; }
    }
}
