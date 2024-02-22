using Microsoft.AspNetCore.Identity;

namespace BE_Clothing.Models
{
    public class User : IdentityUser
    {
        public string? Location { get; set; }
        public List<string>? Product_Code { get; set; }
        public List<Clothing>? Clothings { get; set; }
    }
}
