using AutoMapper;
using Softbreak.OnionArch.APPLICATION.Dtos.AppRoles;
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
    public class AppRoleManager : BaseManager<AppRole, AppRoleDto>, IAppRoleManager
    {
        private readonly IMapper _mapper;
        private readonly IAppRoleRepository _appRoleRepository;
        public AppRoleManager(IAppRoleRepository appRoleRepository, IMapper mapper) : base(appRoleRepository, mapper)
        {
            _mapper = mapper;
            _appRoleRepository = appRoleRepository;
        }
    }
}
