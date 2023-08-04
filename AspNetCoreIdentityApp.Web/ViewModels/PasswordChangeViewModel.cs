using System.ComponentModel.DataAnnotations;

namespace AspNetCoreIdentityApp.Web.ViewModels
{
    public class PasswordChangeViewModel
    {
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Şifre Alanı boş bırakılamaz.")]
        [Display(Name = "Eski Şifre :")]
        [MinLength(6, ErrorMessage = "Şifreniz en az 6 karakter olabilir.")]
        public string PasswordOld { get; set; } = null!;

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Yeni şifre Alanı boş bırakılamaz.")]
        [Display(Name = "Yeni Şifre :")]
        [MinLength(6, ErrorMessage = "Şifreniz en az 6 karakter olabilir.")]
        public string PasswordNew { get; set; } = null!;
        [Compare(nameof(PasswordNew), ErrorMessage = "Girmiş olduğunuz şifreler aynı değil.")]
        [Required(ErrorMessage = "Şifre Tekrar Alanı boş bırakılamaz.")]
        [Display(Name = "Yeni Şifre Tekrar:")]
        [MinLength(6, ErrorMessage = "Şifreniz en az 6 karakter olabilir.")]
        public string PasswordNewConfirm { get; set; } = null!;
    }
}
