//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PerfumeryApp
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PerfumeryDBEntities : DbContext
    {
        public PerfumeryDBEntities()
            : base("name=PerfumeryDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<GoodOfOrder> GoodOfOrder { get; set; }
        public virtual DbSet<Goods> Goods { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Points> Points { get; set; }
        public virtual DbSet<Users> Users { get; set; }
    }
}
