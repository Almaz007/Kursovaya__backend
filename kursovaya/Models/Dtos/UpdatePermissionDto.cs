using System.ComponentModel.DataAnnotations;

namespace kursovaya.Dtos
{
    public class UpdatePermissionDto
    {
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; } 
      
    }
}
