using System.ComponentModel.DataAnnotations;

namespace ToDoApp.webUI.Models
{
    public class AppUserAddViewModel
    {
        [Required(ErrorMessage="Kullanıcı adı boş geçilemez")]
        [Display(Name="Kullanıcı Adı:")]
        public string UserName { get; set; }

        [Display(Name="Parola:")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage="Parola boş geçilemez")]
        public string Password { get; set; }

        [Display(Name="Parola Confirm:")]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage="Parolalar eşleşmiyor")]
        public string ConfirmPassword { get; set; }

        [Display(Name="Email:")]
        [EmailAddress(ErrorMessage="Geçersiz email")]
        [Required(ErrorMessage="Email boş geçilemez")]
        public string Email { get; set; }

        [Display(Name="Adınız :")]
        [Required(ErrorMessage="Ad boş geçilemez")]
        public string Name { get; set; }

        [Display(Name="Soyadınız :")]
        [Required(ErrorMessage="Soyad boş geçilemez")]
        public string SurName { get; set; }
    }
}