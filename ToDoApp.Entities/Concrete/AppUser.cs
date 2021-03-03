using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using ToDoApp.Entities.Interfaces;

namespace ToDoApp.Entities.Concrete
{
    public class AppUser : IdentityUser<int>, ITablo
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Picture { get; set; }="default.png";
        

        public List<Bildirim> Bildirimler{get;set;}
        public List<Gorev> Gorevler {get;set;}
    }
}