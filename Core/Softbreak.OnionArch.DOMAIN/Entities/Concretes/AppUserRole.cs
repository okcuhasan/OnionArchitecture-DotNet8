﻿using Softbreak.OnionArch.DOMAIN.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Softbreak.OnionArch.DOMAIN.Entities.Concretes
{
    public class AppUserRole : BaseEntity
    {
        public int UserId { get; set; }
        public virtual AppUser AppUser { get; set; }
        public int RoleId { get; set; }
        public virtual AppRole AppRole { get; set; }
    }
}
