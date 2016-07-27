namespace Demo1.Data
{
    using Model;
    using System.Data.Entity;

    class DemoDbContext : DbContext
    {
        public DemoDbContext() : base("mydb") { }
        public DbSet<Estimation> Estimations { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
