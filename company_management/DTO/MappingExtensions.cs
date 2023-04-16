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
                cfg.CreateMap<checkin_checkout, CheckinCheckout>().ReverseMap();
                cfg.CreateMap<leave_request, LeaveRequestDTO > ().ReverseMap();
                cfg.CreateMap<salary, SalaryDTO> ().ReverseMap();
                cfg.CreateMap<checkin_checkout, CheckinCheckout> ().ReverseMap();
            });

            _mapper = config.CreateMapper();
        }

        public static TDto ToDto<TSource, TDto>(this TSource entity)
        {
            return _mapper.Map<TDto>(entity);
        }

        public static TEntity ToEntity<TSource, TEntity>(this TSource dto)
        {
            return _mapper.Map<TEntity>(dto);
        }
    }

}
