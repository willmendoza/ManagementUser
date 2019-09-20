namespace ManagementUser.Api.DataAccess.Contract
{
    using ManagementUser.Api.DataAccess.Contract.Entities;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Text;
    /// <summary>
    /// Interface
    /// </summary>
    public interface IManagementUserDBContext
    {
        DbSet<UserEntity> Users { get; set; }
    }
}
