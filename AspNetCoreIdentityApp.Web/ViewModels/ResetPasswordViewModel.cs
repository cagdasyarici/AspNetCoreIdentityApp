using System.ComponentModel.DataAnnotations;

namespace AspNetCoreIdentityApp.Web.ViewModels
{
    public class ResetPasswordViewModel
    {
       
        [Required(ErrorMessage = "Şifre Alanı boş bırakılamaz.")]
        [Display(Name = "Yeni Şifre :")]
        public string? Password { get; set; }
        [Compare(nameof(Password), ErrorMessage = "Girmiş olduğunuz şifreler aynı değil.")]
        [Required(ErrorMessage = "Şifre Tekrar Alanı boş bırakılamaz.")]
        [Display(Name = "Yeni Şifre Tekrar:")]
        public string? PasswordConfirm { get; set; }
    }
}
