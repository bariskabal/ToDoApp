using AutoMapper;
using ToDoApp.DTO.DTOs.AciliyetDtos;
using ToDoApp.DTO.DTOs.AppUserDtos;
using ToDoApp.DTO.DTOs.BildirimDtos;
using ToDoApp.DTO.DTOs.GorevDtos;
using ToDoApp.DTO.DTOs.RaporDtos;
using ToDoApp.Entities.Concrete;

namespace ToDoApp.webUI.Mapping.AutoMapperProfile
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {

            #region Aciliyet-AciliyetDto
            CreateMap<AciliyetAddDto,Aciliyet>();
            CreateMap<Aciliyet,AciliyetAddDto>();
            CreateMap<AciliyetListDto,Aciliyet>();
            CreateMap<Aciliyet,AciliyetListDto>();
            CreateMap<AciliyetUpdateDto,Aciliyet>();
            CreateMap<Aciliyet,AciliyetUpdateDto>();
            #endregion

            #region AppUser-AppUserDto
            CreateMap<AppUserAddDto,AppUser>();
            CreateMap<AppUser,AppUserAddDto>();
            CreateMap<AppUserListDto,AppUser>();
            CreateMap<AppUser,AppUserListDto>(); 
            CreateMap<AppUserSignInDto,AppUser>();
            CreateMap<AppUser,AppUserSignInDto>();
            #endregion

            #region Bildirim-BildirimDto
            CreateMap<BildirimListDto,Bildirim>();
            CreateMap<Bildirim,BildirimListDto>();
            #endregion

            #region Gorev-GorevDto
            CreateMap<GorevAddDto,Gorev>();
            CreateMap<Gorev,GorevAddDto>();
            CreateMap<GorevListAllDto,Gorev>();
            CreateMap<Gorev,GorevListAllDto>();
            CreateMap<GorevListDto,Gorev>();
            CreateMap<Gorev,GorevListDto>();
            CreateMap<GorevUpdateDto,Gorev>();
            CreateMap<Gorev,GorevUpdateDto>();
            #endregion

            #region Rapor-RaporDto
            CreateMap<RaporAddDto,Rapor>();
            CreateMap<Rapor,RaporAddDto>();
            CreateMap<RaporUpdateDto,Rapor>();
            CreateMap<Rapor,RaporUpdateDto>();
            CreateMap<RaporDosyaDto,Rapor>();
            CreateMap<Rapor,RaporDosyaDto>();
            #endregion


        }
    }
}