﻿using Softbreak.OnionArch.APPLICATION.Dtos.Categories;
using Softbreak.OnionArch.DOMAIN.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Softbreak.OnionArch.APPLICATION.Managers
{
    public interface ICategoryManager : IManager<Category, CategoryDto>
    {
    }
}
