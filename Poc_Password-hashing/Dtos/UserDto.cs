using System.ComponentModel.DataAnnotations;

namespace Poc_Password_hashing.Dtos
{
    public class UserDto
    {
        public Guid id { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Username shoud be in between 5 to 20 characters")]
        public string UserName { get; set; }
        [Required]
        [StringLength(100)]
        public string Password { get; set; }
        [EmailAddress]
        public string Email { get; set; }
    }
}
