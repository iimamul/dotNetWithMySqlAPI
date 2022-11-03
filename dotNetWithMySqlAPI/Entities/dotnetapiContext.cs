using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using dotNetWithMySqlAPI.DTO;

#nullable disable

namespace dotNetWithMySqlAPI.Entities
{
    public partial class dotnetapiContext : DbContext
    {
        public dotnetapiContext()
        {
        }

        public dotnetapiContext(DbContextOptions<dotnetapiContext> options)
            : base(options)
        {
        }

        public virtual DbSet<User> Users { get; set; }

        public DbSet<dotNetWithMySqlAPI.DTO.UserDTO> UserDTO { get; set; }


    }
}
