using System.ComponentModel.DataAnnotations;

namespace Modalproject.Models
{
    public class Registration
    {
        [Required(ErrorMessage = "FirstName is required")]
        public string FirstName { get; set; }


        [Required(ErrorMessage = "LastName is required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "DateOfBirth is required")]
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }



        [Required(ErrorMessage = "Country is required")]
        public string Country { get; set; }


        [Required(ErrorMessage = "State is required")]
        public string State { get; set; }



        [Required(ErrorMessage = "City is required")]
        public string City { get; set; }


        [Required(ErrorMessage = "Phone Number is required")]
        [Phone(ErrorMessage = "Invalid Phone Number")]
        public string PhoneNumber { get; set; }


        [Required(ErrorMessage = "Email is required")]
        [Phone(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }



        [Required(ErrorMessage = "Gender is required")]

        public string Gender { get; set; }


        [Required(ErrorMessage = "Hobbies is required")]
        public string Hobbies { get; set; }
        







    }
}




