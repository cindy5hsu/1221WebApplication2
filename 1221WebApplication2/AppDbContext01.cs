using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

public class AppDbContext01 : DbContext
{
    // You can add custom code to this file. Changes will not be overwritten.
    // 
    // If you want Entity Framework to drop and regenerate your database
    // automatically whenever you change your model schema, please use data migrations.
    // For more information refer to the documentation:
    // http://msdn.microsoft.com/en-us/data/jj591621.aspx

    public AppDbContext01() : base("name=AppDbContext01")
    {
    }

    public System.Data.Entity.DbSet<_1221WebApplication2.Models.EFModels.Register> Registers { get; set; }
    public System.Data.Entity.DbSet<_1221WebApplication2.Models.EFModels.Member> Members { get; set; }
}
