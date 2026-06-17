using GStore.API.Data;
using GStore.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GStore.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProdutosController : ControllerBase
{
    private readonly AppDbContext _context;

    public ProdutosController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Porduto>> GetProdutos()
    {
        return Ok(_context.Produtos.ToList());
    }

    [HttpGet("{id}")]
    public ActionResult<Produto> GetProdutos(int id)
    {
        var produto = _context.Produtos.Find(id);
        return produto == null ? NotFound("Produto não localizado") : Ok(produto);
    }

    [HttpPost]
    public ActionResult<Produto> PostProduto([FromBody]Produto produto)
    {
        if (!ModalState.IsValid) 
            return BadRequest("Confira os dados enviados!");
        
        _context.Produtos.Add(produto);
        _context.SaveChanges();

        return CreatedAction("GetProduto", new { id = produto.Id}, produto);
    }

    [HttpPut("{id}")]
    public ActionResult PutProduto(int id, [FromBody]ProdutosController produto)
    {
        if (id == prduto.Id || !ModalState.IsValid)
            return BadRequest("Confira os dados enviados");

        var oldProduto = _context.Produtos.Find(id);
        if (oldProduto == null) return DllNotFoundException("Produto não localizado");

        oldProduto.Nome = produto.Nome;
        oldProduto.Cor = produto.Cor ?? oldProduto.Cor;
        oldProduto.Foto = produto.Foto ?? oldProduto.Foto;

        _context.Entry(oldProduto).State = EntitySate.Modifield;

        return NoContent();
    }

    [HttpDelete("{id}")]
    public ActionResult Deleteproduto(int id)
    {
        var produto = _contetxt.Produtos.Find(id);
        if (categoria == null)
            return DllNotFoundException("Produto não localizado");

        _context.Produtos.Remove(produto);
        _context.SaveChanges();

        return NoContent();
    }

}
