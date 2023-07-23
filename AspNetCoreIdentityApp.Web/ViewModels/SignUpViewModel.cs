using System.ComponentModel.DataAnnotations;

namespace AspNetCoreIdentityApp.Web.ViewModels
{
    public class SignUpViewModel
    {
        public SignUpViewModel() { }
        public SignUpViewModel(string userName, string email, string phone, string password)
        {
            UserName = userName;
            Email = email;
            Phone = phone;
            Password = password;
        }
        [Required(ErrorMessage ="Kullanıcı Ad Alanı boş bırakılamaz.")]
        [Display(Name = "Kullanıcı Adı :")]
        public string UserName { get; set; }
        [EmailAddress(ErrorMessage ="Email formatı yanlış.")]
        [Required(ErrorMessage = "Email Alanı boş bırakılamaz.")]
        [Display(Name = "Email :")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Telefon Alanı boş bırakılamaz.")]
        [Display(Name = "Telefon :")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Şifre Alanı boş bırakılamaz.")]
        [Display(Name = "Şifre :")]
        public string Password { get; set; }
        [Compare(nameof(Password),ErrorMessage ="Girmiş olduğunuz şifreler aynı değil.")]
        [Required(ErrorMessage = "Şifre Tekrar Alanı boş bırakılamaz.")]
        [Display(Name = "Şifre Tekrar:")]
        public string PasswordConfirm { get; set; }
    }
}
