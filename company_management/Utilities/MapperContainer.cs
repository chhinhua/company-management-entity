using AutoMapper;
using company_management.DTO;
using company_management.Entity;

namespace company_management.Utilities
{
    public static class MapperContainer
    {
        private static IMapper _mapper;
        private static bool _initialized;

        public static IMapper GetMapper()
        {
            if (!_initialized)
            {
                Initialize();
                _initialized = true;
            }

            return _mapper;
        }

        private static void Initialize()
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<user, User>().ReverseMap();
                cfg.CreateMap<team, Team>().ReverseMap();
                cfg.CreateMap<task, Task>().ReverseMap();
                cfg.CreateMap<project, Project>().ReverseMap();
                cfg.CreateMap<salary, Salary>().ReverseMap();
                cfg.CreateMap<leaveRequest, LeaveRequest>().ReverseMap();
                cfg.CreateMap<checkin_checkout, CheckinCheckout>().ReverseMap();
            });
            _mapper = config.CreateMapper();
        }
    }
}