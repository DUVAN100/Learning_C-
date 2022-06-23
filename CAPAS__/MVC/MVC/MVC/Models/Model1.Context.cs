namespace MVC.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ventasEntities : DbContext
    {
        public ventasEntities()
            : base("name=ventasEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<factura> factura { get; set; }
        public virtual DbSet<producto> producto { get; set; }
    }
}
