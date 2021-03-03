using System.Collections.Generic;
using System.Linq;
using ToDoApp.Data.Concrete.EFCore.Contexts;
using ToDoApp.Data.Interfaces;
using ToDoApp.Entities.Interfaces;
using ToDoApp.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace ToDoApp.Data.Concrete.EFCore.Repository
{
    public class EFRaporRepository : EFGenericRepository<Rapor>, IRaporDal
    {
        public Rapor GetirGorevileId(int id)
        {
            using (var context = new ToDoContext())
            {
                return context.Raporlar.Include(I=>I.Gorev).ThenInclude(I=>I.Aciliyet).Where(I=>I.Id==id).FirstOrDefault();
            }
        }

        public List<Rapor> getirrapor(int id)
        {
            using (var context = new ToDoContext())
            {
                return context.Raporlar.Where(I=>I.GorevId==id).ToList();
               // return context.Gorevler.Include(I=>I.Raporlar).Where(I=>I.Id==id).FirstOrDefault();
            }
        }

        public int GetirRaporSayisi()
        {
            using (var context = new ToDoContext())
            {
                return context.Raporlar.Count();
            }
        }

        public int GetirRaporSayisiileAppUserId(int id)
        {
            using (var context = new ToDoContext())
            {
                var result = context.Gorevler.Include(I=>I.Raporlar).Where(I=>I.AppUserId==id);
                return result.SelectMany(I=>I.Raporlar).Count();
            
            }
        }
    }
}