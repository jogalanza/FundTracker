using System.ComponentModel.DataAnnotations;

namespace WebApp.Model
{
    public class Account
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string MobileNumber { get; set; }
        public string Email { get; set; }
        public string Key { get; set; }
    }
}