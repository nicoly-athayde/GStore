using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Net.Http.Headers;

namespace GStore.API.Models;

[Table("categorias")]
public class Categoria
{
    [Key]
    public int id { get; set; }

    [Required]
    [StringLength(50)]
    public string Nome { get; set; }

    [StringLength(300)]
    public string Foto { get; set }

    [StringLength(26)]
    public string Cor { get; set; } = "rgba(0,0,0,1)";

}
