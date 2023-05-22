using BusinessLib.Distributors.Models;
using System.ComponentModel.DataAnnotations;
using WebApi.Entities;

namespace WebApi.Models.Accounts
{
    public class CreateRequest
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

        [Required]
        [EnumDataType(typeof(RoleUser))]
        public string Role { get; set; }
    }
}