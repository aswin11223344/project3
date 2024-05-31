using System.ComponentModel.DataAnnotations;

namespace Modalproject.Models
{
    public class Contact
    {
        [Required(ErrorMessage ="*Enter Details")]  
        public string Name { get; set; }

        [Required(ErrorMessage = "*Enter Details")]
        public string Email { get; set; }
      

        [Required(ErrorMessage = "*Enter Details")]
        public string Message { get; set;}

        [Required(ErrorMessage = "*Enter Details")]
        public string Subject { get; set; }
    }
}
