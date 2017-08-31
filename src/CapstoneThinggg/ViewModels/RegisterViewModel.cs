using System.ComponentModel.DataAnnotations;

namespace Forum.ViewModels
{
    public class RegisterViewModel
    {
      [Required]
      [EmailAddress]
      [Display(Name = "Email")]
      public string Email { get; set; }

      [Required]
      [DataType(DataType.Password)]
      [Display(Name = "Password")]
      public string Password { get; set; }

      [Required]
      [Display(Name = "Confirm password")]
      [Compare("Password", ErrorMessage = "Passwords must match.")]
      public string ConfirmPassword { get; set; }
    }
}
