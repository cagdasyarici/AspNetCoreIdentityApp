using System.ComponentModel.DataAnnotations;

namespace AspNetCoreIdentityApp.Web.ViewModels
{
    public class ForgotPasswordViewModel
    {
        [EmailAddress(ErrorMessage = "Email formatı yanlış.")]
        [Required(ErrorMessage = "Email Alanı boş bırakılamaz.")]
        [Display(Name = "Email :")]
        public string Email { get; set; } = null!;
    }
}
