using System.ComponentModel.DataAnnotations;

namespace Portfolio.Email
{
    public class EmailModel
    {
        [Required(ErrorMessage = "{0} field is required." )]
        [MinLength(2, ErrorMessage = "{0} field must have at least {1} characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "{0} field is required.")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "{0} field is required.")]
        [Phone]
        public string Phone { get; set; }

        [Required(ErrorMessage = "{0} field is required.")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "{0} field is required.")]
        [MinLength(20, ErrorMessage = "{0} field must have at least {1} characters.")]
        public string Message { get; set; }

        public Status Status { get; set; } = Status.None;
    }

    public enum Status
    {
        None, Sending, Error, Done
    }
}