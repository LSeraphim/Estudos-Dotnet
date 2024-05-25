using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Creation_API_With_DotNet.Context;
using Creation_API_With_DotNet.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Creation_API_With_DotNet.Controllers
{
[Route("[controller]")]
public class ContatoController : Controller
{
    private readonly AgendaContext _context;
    public ContatoController(AgendaContext context)
    {
        _context = context;
    }

    // Criação de contato no banco de dados
    [HttpPost]
    public IActionResult Create(Contato contato)
    {
        _context.Add(contato);
        _context.SaveChanges();
        return CreatedAtAction(nameof(ObterPorId), new {id = contato.Id}, contato);
    }

    // Busca de contatos do banco de dados, por Id
    [HttpGet("{id}")]
    public IActionResult ObterPorId(int id)
    {
        var contato = _context.Contatos.Find(id);

        if (contato == null)
            return NotFound();

        return Ok(contato);
    }

    // Busca de contatos do banco de dados, por nome
    [HttpGet("ObterPorNome")]
    public IActionResult ObterPorNome(string nome)
    {
        var contatos = _context.Contatos.Where(x => x.Nome.Contains(nome));
        return Ok(contatos);
    }

    // EndPoint para Editar dados do Banco de Dados por Id
    [HttpPut("{id}")]
    public IActionResult Atualizar(int id, Contato contato)
    {
        var contatoBanco = _context.Contatos.Find(id);

        if (contatoBanco == null)
            return NotFound();
        
        contatoBanco.Nome = contato.Nome;
        contatoBanco.Telefone = contato.Telefone;
        contatoBanco.Ativo = contato.Ativo;

        _context.Contatos.Update(contatoBanco);
        _context.SaveChanges();

        return Ok(contatoBanco);
    }

    // EndPoint para deletar dados do Banco de Dados por Id
    [HttpDelete("{id}")]
    public IActionResult Deletar(int id)
    {
        var contatoBanco = _context.Contatos.Find(id);

        if (contatoBanco == null)
            return NotFound();

        _context.Contatos.Remove(contatoBanco);
        _context.SaveChanges();
        return NoContent();
    }
}
}