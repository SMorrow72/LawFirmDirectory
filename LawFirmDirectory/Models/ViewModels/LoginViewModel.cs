using System.ComponentModel.DataAnnotations;

namespace LawFirmDirectory.Models.ViewModels
{
    public class LoginViewModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please provide a UserName")]
        public string? UserName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please provide a Password")]
        public string? Password { get; set; }
    }
}
