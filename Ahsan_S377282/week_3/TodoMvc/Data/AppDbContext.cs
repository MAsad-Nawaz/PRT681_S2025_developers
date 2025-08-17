using Microsoft.EntityFrameworkCore;
using TodoMvc.Models;

namespace TodoMvc.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    public DbSet<Todo> Todos => Set<Todo>();
}
