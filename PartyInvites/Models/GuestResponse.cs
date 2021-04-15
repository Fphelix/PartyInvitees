using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
      // Fields & Properties

        [Required (ErrorMessage = "Name is Required")]
        public string Name { get; set; }

        [Required (ErrorMessage = "Email is Required")]
        [EmailAddress]
        public string Email { get; set; }

        [Required (ErrorMessage = "Phone is Required")]
        [Phone (ErrorMessage = "Please Enter a valid Phone number")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please Let Us Know If You Will Attend Or Not")]
        public bool? WillAttend { get; set; }



    }
}
