namespace Marshalls_LLC.Api.Mapper
{
    using AutoMapper;
    using Marshalls_LLC.Core.Dto;
    using Marshalls_LLC.Core.Entities;
    using System.Collections.Generic;

    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<EmployeeDTO, Employee>(); // means you want to map from User to UserDTO
            CreateMap<Employee, EmployeeDTO>();
            CreateMap<List<Employee>, List<EmployeeDTO>>();
        }
    }
}
