using GStore.API.Models;
using Microsoft.EntityFrameworkCore;

namespace GStore.API.Data.Seeds;

public class SeedCategoria
{
    public SeedCategoria(ModelBuilder builder)
    {
        List<Categoria> categorias = [
            new() { Id = 1, Nome = "Sapatilhas de meia ponta" },
            new() { Id = 2, Nome = "Saias" },
            new() { Id = 3, Nome = "Collants" },
            new() { Id = 4, Nome = "Sapatilhas de ponta" },
            new() { Id = 5, Nome = "Macacão de aquecimento" },
        ];
        builder.Entity<Categoria>().HasData(categorias);
    }
}