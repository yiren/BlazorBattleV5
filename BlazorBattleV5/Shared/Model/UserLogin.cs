using System.ComponentModel.DataAnnotations;
namespace BlazorBattleV5.Shared.Model
{
    public class UserLogin
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}