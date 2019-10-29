
namespace Lab_5___Nisses_stugby

{
    using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

public partial class Labb5Entities : DbContext
{
    public Labb5Entities()
        : base("name=Labb5Entities")
    {
    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }

    public virtual DbSet<Person> People { get; set; }

}
}