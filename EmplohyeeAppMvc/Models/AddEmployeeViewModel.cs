using EmplohyeeAppMvc.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace EmplohyeeAppMvc.Models
{
    public class AddEmployeeViewModel
    {
        [Required]
        [StringLength(20)]
        public string FirstName { get; set; }
        [StringLength(20)]
        public string MiddleName { get; set; }
        [Required]
        [StringLength(20)]
        public string LastName { get; set; }
        [Required]
        public Title Title { get; set; }
        [Required]
        [StringLength(11)]
        public string PhoneNumber { get; set; }
        [Required]
        [StringLength(50)]
        [EmailAddress]
        public string Email { get; set; }

    }
}
