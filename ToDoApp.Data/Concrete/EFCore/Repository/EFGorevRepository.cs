using System.Collections.Generic;
using System.Linq;
using ToDoApp.Data.Concrete.EFCore.Contexts;
using ToDoApp.Data.Interfaces;
using ToDoApp.Entities.Interfaces;
using ToDoApp.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System;

namespace ToDoApp.Data.Concrete.EFCore.Repository
{
    public class EFGorevRepository : EFGenericRepository<Gorev>, IGorevDal
    {
        public Gorev GetirAciliyetIdile(int id)
        {
            using var context = new ToDoContext();
            return context.Gorevler.Include(I => I.Aciliyet).FirstOrDefault(I => !I.Durum && I.Id == id);
        }

        public List<Gorev> GetirAciliyetIleTamamlanmayan()
        {
            using (var context = new ToDoContext())
            {
                return context.Gorevler.Include(I=>I.Aciliyet).Where(I=> !I.Durum).OrderByDescending(I=>I.OlusturulmaTarih).ToList();
            }
        }

        public int GetirAtanmayıBekleyenGörevSayisi()
        {
            using (var context = new ToDoContext())
            {
                return context.Gorevler.Count(I=>I.AppUserId==null && !I.Durum);
            }
        }

        public int GetirGorevSayisiTamamlananileAppUserId(int id)
        {
            using (var context = new ToDoContext())
            {
                return context.Gorevler.Where(I=>I.AppUserId==id && I.Durum).Count();
                //context.Gorevler.Count(I=>I.AppUserId==id && I.Durum);
                
            }
        }

        public int GetirGorevSayisiTamamlanmasıGerekenAppUserId(int id)
        {
            using (var context = new ToDoContext())
            {
                return context.Gorevler.Count(I=>I.AppUserId==id && !I.Durum);
            }
        }

        public List<Gorev> GetirileAppUserId(int appUserId)
        {
            using (var context = new ToDoContext())
            {
                return context.Gorevler.Where(I=>I.AppUserId == appUserId).ToList();
            }
        }
        public Gorev GetirRaporlarileId(int Id)
        {
            using var context = new ToDoContext();

            return context.Gorevler.Include(I=>I.Raporlar).Include(I=>I.AppUser).Where(I=>I.Id==Id).FirstOrDefault();
        }

        public int GetirTamamlanmısGorev()
        {
            using (var context = new ToDoContext())
            {
                return context.Gorevler.Where(I=>I.Durum==true).Count();
            }
        }

        public List<Gorev> GetirTumTablolarla()
        {
            using (var context = new ToDoContext())
            {
                return context.Gorevler.Include(I=>I.Aciliyet).Include(I=>I.Raporlar).Include(I=>I.AppUser).Where(I=> !I.Durum).OrderByDescending(I=>I.OlusturulmaTarih).ToList();
            }
        }

        public List<Gorev> GetirTumTablolarla(Expression<Func<Gorev, bool>> filter)
        {
            using (var context = new ToDoContext())
            {
                return context.Gorevler.Include(I=>I.Aciliyet).Include(I=>I.Raporlar).Include(I=>I.AppUser).Where(filter).OrderByDescending(I=>I.OlusturulmaTarih).ToList();
            }
        }

        public List<Gorev> GetirTumTablolarlaTamamlanmayan(out int toplamSayfa, int userId,int aktifSayfa=1)
        {
            using (var context = new ToDoContext())
            {
                var returnValue = context.Gorevler.Include(I=>I.Aciliyet).Include(I=>I.Raporlar).Include(I=>I.AppUser).Where(I=>I.AppUserId==userId && I.Durum).OrderByDescending(I=>I.OlusturulmaTarih);

                toplamSayfa=(int)Math.Ceiling((double)returnValue.Count()/3);

                return returnValue.Skip((aktifSayfa-1)*3).Take(3).ToList();
            }
        }

        public List<Gorev> TamamlanmısGorevGetirListe()
        {
            using (var context = new ToDoContext())
            {
                return context.Gorevler.Where(I=>I.Durum==true).ToList();
            }
        }
    }
}