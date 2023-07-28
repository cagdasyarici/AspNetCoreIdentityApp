using System.ComponentModel.DataAnnotations;

namespace AspNetCoreIdentityApp.Web.ViewModels
{
    public class SignInViewModel
    {
        public SignInViewModel() { }
        public SignInViewModel(string email, string password)
        {
            Email = email;
            Password = password;
        }

        [EmailAddress(ErrorMessage = "Email formatı yanlış.")]
        [Required(ErrorMessage = "Email Alanı boş bırakılamaz.")]
        [Display(Name = "Email :")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Şifre Alanı boş bırakılamaz.")]
        [Display(Name = "Şifre :")]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
