using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorBattleV5.Shared.Model
{
    public class UserRegister
    {
        [Required, EmailAddress]
        public string Email { get; set; }
        [StringLength(20, ErrorMessage="Max Characters are 20.")]
        public string Username { get; set; }

        public string Bio { get; set; }
        [Required]
        [StringLength(50, MinimumLength=4)]
        public string Password { get; set; }
        [Compare("Password", ErrorMessage="Password is not entered correctly.")]
        public string ConfirmPassword { get; set; }

        public string StartUnitId { get; set; }="1";
        [Range(0,500)]
        public int Bananas { get; set; }=250;
        public DateTime DateOfRegistered { get; set; }=DateTime.Now;
        [Range(typeof(bool),"true", "true", ErrorMessage="Only Confirmed User can play.")]
        public bool Confirmed { get; set; }

        
        
    }
}