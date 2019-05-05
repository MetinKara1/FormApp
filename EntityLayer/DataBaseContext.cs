using System;
using System.Data.Entity;
using EntityLayer;

namespace EntityLayer
{
    public class DataBaseContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Field> Fields { get; set; }
        public DbSet<Form> Forms { get; set; }
        public DbSet<FormGetPost> MyProperty { get; set; }
    }
}
