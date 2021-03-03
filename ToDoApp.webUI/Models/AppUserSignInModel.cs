using System.ComponentModel.DataAnnotations;

namespace ToDoApp.webUI.Models
{
    public class AppUserSignInModel
    {

        [Required(ErrorMessage="Kullanıcı adı boş geçilemez")]
        [Display(Name="Kullanıcı Adı:")]
        public string UserName { get; set; }

        [Display(Name="Parola:")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage="Parola boş geçilemez")]
        public string Password { get; set; }

        [Display(Name="Beni Hatırla")]
        public bool RememberMe { get; set; }
    }
}