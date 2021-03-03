using System.Collections.Generic;
using ToDoApp.Entities.Concrete;

namespace ToDoApp.Data.Interfaces
{
    public interface IAppUserDal 
    {
         List<AppUser> GetirAdminOlmayanlar();
          List<AppUser> GetirAdminOlmayanlar(out int toplamSayfa,string aranacakKelime,int aktifSayfa=1);
        List<DualHelper> GetirEnCokGorevTamamlamısPersoneller();
        List<DualHelper> GetirEnCokGorevdeCalisanPersoneller();
    }
}