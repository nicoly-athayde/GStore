using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace GStore.API.Data.Seeds;

public class SeedUsuario
{
    public SeedUsuario(ModelBuilder builder)
    {
        #region Perfil
        List<IdentityRole> perfis = [
            new() {
                Id= "b24b85b9-7e2a-4584-931a-10c48c2762ca",
                Name = "Administrador",
                NormalizedName = "ADMINISTRADOR"
            },

            new() {
                Id= "3192a642-68e1-477d-9927-8a9ecbf65342",
                Name = "Cliente",
                NormalizedName = "CLIENTE"
            },
        ];
        builder.Entity<IdentityRole>().HasData(perfis);
        #endregion

        #region Usuários
        #endregion

        #region Usuário Perfil
        #endregion
    }
}
