using GStore.API.Data;
using GStore.API.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Conexão com o banco de dados 
string conexao = builder.Configuration.GetConnectionString ("Conexao");
builder.Services.AddDbContext<AppDbContext>(
    options  => options.UseMySQL ( conexao)
);
// configuração do serviço de autenticação e autorização - Identity
builder.Services.AddIdentity<Usuario, IdentityRole> (Options=>)
{
    // Configuração de Senha 
    Options.Password.RequiredLength = 6 ;
    Options.Password.RequiredUniqueChars = 0;
    // Configuração de bloqueio
    Options.Lockout.MaxFailledAccessAttemps = 5;
    Options.Lockout.AllowedForNewUsers =true ;
    Options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes (10);
    // Configuração de Usuário
    Options.User.RequiredUniqueEmail= true ;
})
.AddEntityFrameworkStores<AppDbContext>()
.AddDefaultTokenProviders();
//Serviços JWT
var jwtSettings = builder.Configuration.GetSection()

object AddEntityFrameworkStores<T>()
{
    throw new NotImplementedException();
}

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
