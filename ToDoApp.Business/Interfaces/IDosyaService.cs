using System.Collections.Generic;

namespace ToDoApp.Business.Interfaces
{
    public interface IDosyaService
    {
        
        //geriye üretmiş olduğu pdf dosyasının virtual path'ini döner
         string AktarPdf<T>(List<T> list) where T:class,new();
         //geriye xceli byte dizisi olarak döner
         byte[] AktarExcel<T>(List<T> list) where T:class,new();
    }
}