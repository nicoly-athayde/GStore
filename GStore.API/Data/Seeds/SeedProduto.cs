using GStore.API.Models;
using Microsoft.EntityFrameworkCore;

namespace GStore.API.Data.Seeds;

public class SeedProduto
{
    public SeedProduto(ModelBuilder builder)
    {
        List<Produto> produtos = [
            new() {
                Id = 1,
                CategoriaId = 1,
                Nome = "Sapatilhas de ponta",
                Descricao = @"",
                ValorCusto = 80.0m,
                Valorvenda = 95,
                Qtde = 0,
                Destaque = true,
                Foto = "/img/produtos/1.png"
            },
                  new() {
                Id = 2,
                CategoriaId = 2,
                Nome = "Saias",
                Descricao = @"",
                ValorCusto = 10.0m,
                Valorvenda = 0,
                Qtde = 0,
                Destaque = true,
                Foto = "/img/produtos/2.png"
            },
                  new() {
                Id = 3,
                CategoriaId = 3,
                Nome = "Collants",
                Descricao = @"",
                ValorCusto = 10.0m,
                Valorvenda = 0,
                Qtde = 0,
                Destaque = true,
                Foto = "/img/produtos/3.png"
            },
                  new() {
                Id = 4,
                CategoriaId = 4,
                Nome = "Sapatilhas de ponta",
                Descricao = @"",
                ValorCusto = 10.0m,
                Valorvenda = 0,
                Qtde = 0,
                Destaque = true,
                Foto = "/img/produtos/4.png"
            },
                  new() {
                Id = 5,
                CategoriaId = 5,
                Nome = "Macacão de aquecimento",
                Descricao = @"",
                ValorCusto = 10.0m,
                Valorvenda = 0,
                Qtde = 0,
                Destaque = true,
                Foto = "/img/produtos/5.png"
            }
        ];
        builder.Entity<Produto>().HasData(produtos);
    }
}