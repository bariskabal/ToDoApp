using ToDoApp.Entities.Concrete;

namespace ToDoApp.DTO.DTOs.RaporDtos
{
    public class RaporAddDto
    {
        public int GorevId { get; set; }
        public string Tanim { get; set; }
        public string Detay { get; set; }
        public Gorev Gorev{get;set;}
    }
}