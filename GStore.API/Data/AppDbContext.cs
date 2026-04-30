using GStore.API.Models;
using Microsoft.AspNetCore.Identity.EntityFrameWorkCore;

namespace GStore.API.Data;

public class AppDbContext : IdentityDbContext<Usuario>
{
    public AppDbContext(AppDbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Produto> Pordutos { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }
}
