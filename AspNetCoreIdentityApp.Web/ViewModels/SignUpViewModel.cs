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
        public string UserName { get; set; } = null!;
        [EmailAddress(ErrorMessage ="Email formatı yanlış.")]
        [Required(ErrorMessage = "Email Alanı boş bırakılamaz.")]
        [Display(Name = "Email :")]
        public string Email { get; set; } = null!;
        [Required(ErrorMessage = "Telefon Alanı boş bırakılamaz.")]
        [Display(Name = "Telefon :")]
        public string Phone { get; set; } = null!;
        [Required(ErrorMessage = "Şifre Alanı boş bırakılamaz.")]
        [Display(Name = "Şifre :")]
        [MinLength(6, ErrorMessage = "Şifreniz en az 6 karakter olabilir.")]
        public string Password { get; set; } = null!;
        [Compare(nameof(Password),ErrorMessage ="Girmiş olduğunuz şifreler aynı değil.")]
        [Required(ErrorMessage = "Şifre Tekrar Alanı boş bırakılamaz.")]
        [Display(Name = "Şifre Tekrar:")]
        [MinLength(6, ErrorMessage = "Şifreniz en az 6 karakter olabilir.")]
        public string PasswordConfirm { get; set; } = null!;
    }
}
