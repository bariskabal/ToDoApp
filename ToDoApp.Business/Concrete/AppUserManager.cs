using System.Collections.Generic;
using ToDoApp.Business.Interfaces;
using ToDoApp.Data.Interfaces;
using ToDoApp.Entities.Concrete;

namespace ToDoApp.Business.Concrete
{
    public class AppUserManager : IAppUserService
    {
        IAppUserDal _userDal;
        public AppUserManager(IAppUserDal userDal)
        {
            _userDal=userDal;
        }
        public List<AppUser> GetirAdminOlmayanlar()
        {
            return _userDal.GetirAdminOlmayanlar();
        }

        public List<AppUser> GetirAdminOlmayanlar(out int toplamSayfa,string aranacakKelime, int aktifSayfa = 1)
        {
            return _userDal.GetirAdminOlmayanlar(out toplamSayfa,aranacakKelime,aktifSayfa);
        }

        public List<DualHelper> GetirEnCokGorevdeCalisanPersoneller()
        {
            return _userDal.GetirEnCokGorevdeCalisanPersoneller();
        }

        public List<DualHelper> GetirEnCokGorevTamamlamısPersoneller()
        {
            return _userDal.GetirEnCokGorevTamamlamısPersoneller();
        }
    }
}