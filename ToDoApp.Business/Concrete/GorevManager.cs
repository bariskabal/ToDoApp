using ToDoApp.Business.Interfaces;
using System.Collections.Generic;
using ToDoApp.Data.Concrete.EFCore.Repository;
using ToDoApp.Entities.Concrete;
using ToDoApp.Data.Interfaces;
using System.Linq.Expressions;
using System;

namespace ToDoApp.Business.Concrete
{
    public class GorevManager : IGorevService
    {
        private readonly IGorevDal _gorevDal;

        public GorevManager(IGorevDal gorevDal)
        {
            _gorevDal = gorevDal;
        }

        public Gorev GetirAciliyetIdile(int id)
        {
          return _gorevDal.GetirAciliyetIdile(id);
        }

        public List<Gorev> GetirAciliyetIleTamamlanmayan()
        {
            return _gorevDal.GetirAciliyetIleTamamlanmayan();
        }

        public int GetirAtanmayıBekleyenGörevSayisi()
        {
            return _gorevDal.GetirAtanmayıBekleyenGörevSayisi();
        }

        public int GetirGorevSayisiTamamlananileAppUserId(int id)
        {
            return _gorevDal.GetirGorevSayisiTamamlananileAppUserId(id);
        }

        public int GetirGorevSayisiTamamlanmasıGerekenAppUserId(int id)
        {
            return _gorevDal.GetirGorevSayisiTamamlananileAppUserId(id);
        }

        public List<Gorev> GetirHepsi()
        {
            return _gorevDal.GetirHepsi();
        }

        public Gorev GetirIdile(int id)
        {
            return _gorevDal.GetirIdile(id);
        }

        public List<Gorev> GetirileAppUserId(int appUserId)
        {
            return _gorevDal.GetirileAppUserId(appUserId);
        }

        public Gorev GetirRaporlarileId(int Id)
        {
            return _gorevDal.GetirRaporlarileId(Id);
        }

        public int GetirTamamlanmısGorev()
        {
            return _gorevDal.GetirTamamlanmısGorev();
        }

        public List<Gorev> GetirTumTablolarla()
        {
            return _gorevDal.GetirTumTablolarla();
        }

        public List<Gorev> GetirTumTablolarla(Expression<Func<Gorev, bool>> filter)
        {
            return _gorevDal.GetirTumTablolarla(filter);
        }

        public List<Gorev> GetirTumTablolarlaTamamlanmayan(out int toplamSayfa, int userId, int aktifSayfa = 1)
        {
             return _gorevDal.GetirTumTablolarlaTamamlanmayan(out toplamSayfa,userId,aktifSayfa);
        }
        public void Guncelle(Gorev tablo)
        {
            _gorevDal.Guncelle(tablo);
        }

        public void Kaydet(Gorev tablo)
        {
            _gorevDal.Kaydet(tablo);
        }

        public void Sil(Gorev tablo)
        {
            _gorevDal.Sil(tablo);
        }

        public List<Gorev> TamamlanmısGorevGetirListe()
        {
            return _gorevDal.TamamlanmısGorevGetirListe();
        }
    }
}