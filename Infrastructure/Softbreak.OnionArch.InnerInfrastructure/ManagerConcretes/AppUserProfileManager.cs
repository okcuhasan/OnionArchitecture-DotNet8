using AutoMapper;
using Softbreak.OnionArch.APPLICATION.Dtos.AppUserProfiles;
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
    public class AppUserProfileManager : BaseManager<AppUserProfile, AppUserProfileDto>, IAppUserProfileManager
    {
        private readonly IMapper _mapper;
        private readonly IAppUserProfileRepository _appUserProfileRepository;
        public AppUserProfileManager(IAppUserProfileRepository appUserProfileRepository, IMapper mapper) : base(appUserProfileRepository, mapper)
        {
            _mapper = mapper;
            _appUserProfileRepository = appUserProfileRepository;
        }
    }
}
