﻿using AutoMapper;
using Discount.Grpc.Entities;
using Discount.Grpc.Protos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Discount.Grpc.Mapper
{
    public class DiscountProfile : Profile
    {
        DiscountProfile() 
        {
            CreateMap<Coupon, CouponModel>().ReverseMap();
        }
    }
}
