using AutoMapper;
using Club.Domain.Entities;
using Club.WebUI.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Club.WebUI.Mapping
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserView>();
            CreateMap<User, UserView>();
        }
    }
}
