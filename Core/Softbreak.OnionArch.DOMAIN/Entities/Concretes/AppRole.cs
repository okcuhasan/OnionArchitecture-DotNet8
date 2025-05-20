﻿using Softbreak.OnionArch.DOMAIN.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Softbreak.OnionArch.DOMAIN.Entities.Concretes
{
    public class AppRole : BaseEntity
    {
        public string RoleName { get; set; }
        public virtual ICollection<AppUserRole> Roles { get; set; }
    }
}
