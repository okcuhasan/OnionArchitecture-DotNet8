using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Softbreak.OnionArch.DOMAIN.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Softbreak.OnionArch.Persistence.Configurations
{
    public class AppUserConfiguration : BaseConfiguration<AppUser>
    {
        public override void Configure(EntityTypeBuilder<AppUser> builder)
        {
            base.Configure(builder);

            builder.HasOne(au => au.AppUserProfile).WithOne(aup => aup.AppUser).HasForeignKey<AppUserProfile>(aup => aup.UserId);
            builder.HasMany(au => au.Roles).WithOne(aur => aur.AppUser).HasForeignKey(aur => aur.UserId);
        }
    }
}
