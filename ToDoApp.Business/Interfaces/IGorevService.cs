using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using ToDoApp.Entities.Concrete;
using ToDoApp.Entities.Interfaces;

namespace ToDoApp.Business.Interfaces
{
    public interface IGorevService : IGenericService<Gorev>
    {
         List<Gorev> GetirAciliyetIleTamamlanmayan();
         List<Gorev> GetirTumTablolarla();
          Gorev GetirAciliyetIdile(int id);
          List<Gorev> GetirileAppUserId(int appUserId);
        Gorev GetirRaporlarileId(int Id);
        List<Gorev> GetirTumTablolarla(Expression<Func<Gorev,bool>> filter);
        List<Gorev> GetirTumTablolarlaTamamlanmayan(out int toplamSayfa,int userId,int aktifSayfa=1); 
        int GetirGorevSayisiTamamlananileAppUserId(int id);
        int GetirGorevSayisiTamamlanmasıGerekenAppUserId(int id);
        int GetirAtanmayıBekleyenGörevSayisi();
        int GetirTamamlanmısGorev();
        List<Gorev> TamamlanmısGorevGetirListe();
    }
}