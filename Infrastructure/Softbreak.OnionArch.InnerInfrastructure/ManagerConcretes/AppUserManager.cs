using AutoMapper;
using Softbreak.OnionArch.APPLICATION.Dtos.AppUsers;
using Softbreak.OnionArch.APPLICATION.Managers;
using Softbreak.OnionArch.CONTRACT.Repositories;
using Softbreak.OnionArch.DOMAIN.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Softbreak.OnionArch.InnerInfrastructure.ManagerConcretes
{
    public class AppUserManager : BaseManager<AppUser, AppUserDto>, IAppUserManager
    {
        private readonly IMapper _mapper;
        private readonly IAppUserRepository _appUserRepository;
        public AppUserManager(IAppUserRepository appUserRepository, IMapper mapper) : base(appUserRepository, mapper)
        {
            _mapper = mapper;
            _appUserRepository = appUserRepository;
        }
    }
}
