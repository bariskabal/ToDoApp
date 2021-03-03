using System.Collections.Generic;
using ToDoApp.Entities.Concrete;

namespace ToDoApp.Data.Interfaces
{
    public interface IRaporDal : IGenericDal<Rapor>
    {
         List<Rapor> getirrapor(int id);
         Rapor GetirGorevileId(int id);
         int GetirRaporSayisiileAppUserId(int id);
         int GetirRaporSayisi();
    }
}