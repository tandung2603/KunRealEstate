using System.ComponentModel.DataAnnotations;

namespace KunBlog.Contracts.Dto
{
    public class LoginDto : BaseDto
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
