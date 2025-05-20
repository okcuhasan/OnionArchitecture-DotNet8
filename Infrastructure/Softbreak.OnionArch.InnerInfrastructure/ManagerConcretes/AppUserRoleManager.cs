using AutoMapper;
using Softbreak.OnionArch.APPLICATION.Dtos.AppUserRoles;
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
    public class AppUserRoleManager : BaseManager<AppUserRole, AppUserRoleDto>, IAppUserRoleManager
    {
        private readonly IMapper _mapper;
        private readonly IAppUserRoleRepository _appUserRoleRepository;
        public AppUserRoleManager(IAppUserRoleRepository appUserRoleRepository, IMapper mapper) : base(appUserRoleRepository, mapper)
        {
            _mapper = mapper;
            _appUserRoleRepository = appUserRoleRepository;
        }
    }
}
