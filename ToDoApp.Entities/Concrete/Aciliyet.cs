using System.Collections.Generic;
using ToDoApp.Entities.Interfaces;

namespace ToDoApp.Entities.Concrete
{
    public class Aciliyet : ITablo
    {
        public int Id { get; set; }
        public string Tanim { get; set; }

        public List<Gorev> Gorevler { get; set; }

        
    }
}