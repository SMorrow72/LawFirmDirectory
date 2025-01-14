using System.ComponentModel.DataAnnotations;

namespace LawFirmDirectory.Data
{
    public class Attorney
    {
        public int AttorneyId { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please provide a first name")]
        public string FirstName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please provide a last name")]
        public string LastName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please provide an email")]
        public string Email { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please provide a phone number")]
        public string Phone { get; set; }
    }
}
