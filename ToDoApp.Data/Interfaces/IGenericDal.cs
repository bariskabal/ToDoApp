using System.Collections.Generic;
using ToDoApp.Entities.Interfaces;

namespace ToDoApp.Data.Interfaces
{
    public interface IGenericDal<Tablo> where Tablo : class, ITablo, new()
    {
         void Kaydet(Tablo tablo);
        void Sil(Tablo tablo);
        void Guncelle(Tablo tablo);
        Tablo GetirIdile(int id);
        List<Tablo> GetirHepsi();
    }
}