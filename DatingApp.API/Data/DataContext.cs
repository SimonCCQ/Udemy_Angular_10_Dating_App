using System;
using Microsoft.EntityFrameworkCore;

/*
  DataContext class
 */
public class DataContext : DbContext
{
  public DataContext(DbContextOptions<DataContext> options) : base(options) { }

  public DbSet<Value> Values { get; set; }
  
}
