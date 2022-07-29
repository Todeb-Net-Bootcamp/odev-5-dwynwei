using AutoMapper;
using DTO.Account;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Configuration.Mapper
{
    /*
     * AutoMapper.dll
     * Mapping End to end via Swagger to Database
     */
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<CreateAccountRequest, Account>();
            CreateMap<UpdateAccountRequest, Account>();
            CreateMap<DeleteAccountRequest, Account>();
        }
    }
}
