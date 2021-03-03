using System.Collections.Generic;
using System.Linq;
using ToDoApp.Data.Concrete.EFCore.Contexts;
using ToDoApp.Data.Interfaces;
using ToDoApp.Entities.Concrete;

namespace ToDoApp.Data.Concrete.EFCore.Repository
{
    public class EFBildirimRepository : EFGenericRepository<Bildirim>, IBildirimDal
    {
        public List<Bildirim> GetirOkunmayanlar(int AppUserId)
        {
            using (var context = new ToDoContext())
            {
                return context.Bildirimler.Where(I=>I.AppUserId==AppUserId && !I.Durum).ToList();
            }
        }

        public int GetirOkunmayanSayisiAppUserId(int AppUserId)
        {
             using (var context = new ToDoContext())
            {
                return context.Bildirimler.Count(I=>I.AppUserId==AppUserId && !I.Durum);
            }

        }
    }
}