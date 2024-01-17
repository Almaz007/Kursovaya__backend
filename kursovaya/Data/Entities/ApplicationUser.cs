using Microsoft.AspNetCore.Identity;

namespace kursovaya.Data.Entities
{
    public class ApplicationUser 
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? MiddleName { get; set; }
    }

}
