namespace ManagementUser.Api.DataAccess
{
    using ManagementUser.Api.DataAccess.Contract;
    using ManagementUser.Api.DataAccess.Contract.Entities;
    using ManagementUser.Api.DataAccess.EntityConfig;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Text;
    /// <summary>
    ///   ManagementUserDBContext Class
    /// </summary>
    public class ManagementUserDBContext : DbContext, IManagementUserDBContext
    {
        public DbSet<UserEntity> Users { get; set; }

        public ManagementUserDBContext(DbContextOptions options) : base(options) 
        {

        }

        /// <summary>
        /// Contruct of ManagementUserDBContext Class
        /// </summary>
        public ManagementUserDBContext()
        {

        }

        /// <summary>
        /// On Model Creating
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            UserEntityConfig.SetEntityBuilder(modelBuilder.Entity<UserEntity>());
            base.OnModelCreating(modelBuilder);
        }
    }
}
