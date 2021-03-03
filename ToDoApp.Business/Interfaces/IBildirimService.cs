using System.Collections.Generic;
using ToDoApp.Entities.Concrete;

namespace ToDoApp.Business.Interfaces
{
    public interface IBildirimService : IGenericService<Bildirim>
    {
         List<Bildirim> GetirOkunmayanlar(int AppUserId);
         int GetirOkunmayanSayisiAppUserId(int AppUserId);
    }
}