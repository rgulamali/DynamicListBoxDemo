

using DynamicListBoxDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace DynamicListBoxDemo.Data;


public class AppDbContext : DbContext
{
    public DbSet<ListBoxItem> ListBoxItems { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
}
