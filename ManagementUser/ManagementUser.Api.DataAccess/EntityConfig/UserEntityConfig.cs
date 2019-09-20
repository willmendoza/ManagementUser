using ManagementUser.Api.DataAccess.Contract.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ManagementUser.Api.DataAccess.EntityConfig
{
    public class UserEntityConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<UserEntity> entityBuilder)
        {
            entityBuilder.ToTable("User");
            entityBuilder.HasKey(x => x.UserId);
            entityBuilder.Property(x => x.UserId).IsRequired();
        }
    }
}
