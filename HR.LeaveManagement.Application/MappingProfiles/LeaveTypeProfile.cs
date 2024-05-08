﻿using AutoMapper;
using HR.LeaveManagement.Application.Features.LeaveType.Queries;
using HR.LeaveManagement.Domain;


namespace HR.LeaveManagement.Application.MappingProfiles
{
    public class LeaveTypeProfile : Profile
    {
        public LeaveTypeProfile()
        {
            CreateMap<LeaveTypeDto, LeaveType>().ReverseMap();
        }
    }
}
