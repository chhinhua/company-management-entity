using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using company_management.Entities;

namespace company_management.DTO
{
    public static class MappingExtensions
    {
        private static readonly IMapper _mapper;

        static MappingExtensions()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<checkin_checkout, CheckinCheckoutDTO>().ReverseMap();
            });

            _mapper = config.CreateMapper();
        }

        public static CheckinCheckoutDTO ToDto(this checkin_checkout entity)
        {
            return _mapper.Map<CheckinCheckoutDTO>(entity);
        }

        public static checkin_checkout ToEntity(this CheckinCheckoutDTO dto)
        {
            return _mapper.Map<checkin_checkout>(dto);
        }
    }
}
