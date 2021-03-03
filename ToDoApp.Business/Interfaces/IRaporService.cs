using ToDoApp.Entities.Concrete;
using ToDoApp.Entities.Interfaces;

namespace ToDoApp.Business.Interfaces
{
    public interface IRaporService : IGenericService<Rapor>
    {
          Rapor GetirGorevileId(int id);
          int GetirRaporSayisiileAppUserId(int id);
          int GetirRaporSayisi();
    }
}