using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GetAway.Models;
using GetAway.Dtos;

namespace GetAway.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Package, PackageDto>();
            Mapper.CreateMap<PackageDto, Package>();

            Mapper.CreateMap<Hotel, HotelDto>();
            Mapper.CreateMap<HotelDto, Hotel>();

            Mapper.CreateMap<Room, RoomDto>();
            Mapper.CreateMap<RoomDto, Room>();
        }
    }
}