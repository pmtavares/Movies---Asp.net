﻿using AutoMapper;
using Movies.Dtos;
using Movies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Movies.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<Movie, MovieDto>();

            Mapper.CreateMap<MembershipType, MembershipTypeDto>();

            Mapper.CreateMap<MoviesGenre, MoviesGenreDto>();


            Mapper.CreateMap<CustomerDto, Customer>();
            
            Mapper.CreateMap<MovieDto, Movie>();
        }
    }
}