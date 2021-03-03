using System.Collections.Generic;
using ToDoApp.Entities.Concrete;

namespace ToDoApp.Business.Interfaces
{
    public interface IAppUserService
    {
         List<AppUser> GetirAdminOlmayanlar();
          List<AppUser> GetirAdminOlmayanlar(out int toplamSayfa,string aranacakKelime,int aktifSayfa=1);
        List<DualHelper> GetirEnCokGorevTamamlamısPersoneller();
        List<DualHelper> GetirEnCokGorevdeCalisanPersoneller();
    }
}