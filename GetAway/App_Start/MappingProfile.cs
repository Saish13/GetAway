﻿using AutoMapper;
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

            Mapper.CreateMap<Feedback, FeedbackDto>();
            Mapper.CreateMap<FeedbackDto, Feedback>();

            Mapper.CreateMap<PackageBooking, PackageBookingDto>();
            Mapper.CreateMap<PackageBookingDto, PackageBooking>();

            Mapper.CreateMap<RoomBooking, RoomBookingDto>();
            Mapper.CreateMap<RoomBookingDto, RoomBooking>();

            Mapper.CreateMap<PackageBookingParticipants, PackageBookingParticipantsDto>();
            Mapper.CreateMap<PackageBookingParticipantsDto, PackageBookingParticipants>();

            Mapper.CreateMap<RoomBookingParticipants, RoomBookingParticipantsDto>();
            Mapper.CreateMap<RoomBookingParticipantsDto, RoomBookingParticipants>();

        }
    }
}