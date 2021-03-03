using System.Collections.Generic;
using ToDoApp.Entities.Concrete;

namespace ToDoApp.Data.Interfaces
{
    public interface IBildirimDal : IGenericDal<Bildirim>
    {
         List<Bildirim> GetirOkunmayanlar(int AppUserId);
         int GetirOkunmayanSayisiAppUserId(int AppUserId);
         
    }
}