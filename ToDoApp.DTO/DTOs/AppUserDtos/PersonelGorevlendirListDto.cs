using ToDoApp.DTO.DTOs.GorevDtos;

namespace ToDoApp.DTO.DTOs.AppUserDtos
{
    public class PersonelGorevlendirListDto
    {
         public AppUserListDto AppUser { get; set; }
         public GorevListDto Gorev { get; set; }
    }
}