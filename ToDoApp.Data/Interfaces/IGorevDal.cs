using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using ToDoApp.Entities.Concrete;

namespace ToDoApp.Data.Interfaces
{
    public interface IGorevDal : IGenericDal<Gorev>
    {
         List<Gorev> GetirAciliyetIleTamamlanmayan();
         List<Gorev> GetirTumTablolarla();
         Gorev GetirAciliyetIdile(int id);
         List<Gorev> GetirileAppUserId(int appUserId);
          Gorev GetirRaporlarileId(int Id);
          List<Gorev> GetirTumTablolarla(Expression<Func<Gorev,bool>> filter);
          List<Gorev> GetirTumTablolarlaTamamlanmayan(out int toplamSayfa,int userId,int aktifSayfa); 
          
          int GetirGorevSayisiTamamlananileAppUserId(int id);
          int GetirGorevSayisiTamamlanmasıGerekenAppUserId(int id);
          int GetirAtanmayıBekleyenGörevSayisi();
          int GetirTamamlanmısGorev();
          List<Gorev> TamamlanmısGorevGetirListe();
    }
}