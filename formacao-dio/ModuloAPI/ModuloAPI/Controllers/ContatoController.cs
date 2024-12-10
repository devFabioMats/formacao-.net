using Microsoft.AspNetCore.Mvc;
using ModuloAPI.Context;
using ModuloAPI.Entities;

namespace ModuloAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContatoController : ControllerBase
    {
        private readonly AgendaContext _context;

        public ContatoController(AgendaContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Create(Contato contato)
        {
            _context.Add(contato);
            _context.SaveChanges();
            return Ok(contato);
        }

        [HttpGet("{id}")]
        public IActionResult ObterPorId(int id)
        {
            var contato = _context.Contatos.Find(id); // .Contato vem do DbContext

            if (contato == null)
                return NotFound();
            else
                return Ok(contato);
        }

        [HttpPut("{id}")]   // atualiza um contato
        public IActionResult Atualizar(int id, Contato contato)     // chama o id do contato a ser modificado, chama o json dos dados do contatos a serem modificados
        {
            var contatoBanco = _context.Contatos.Find(id);      // busca o contato no banco de dados

            if (contatoBanco == null)       // se o contato não existir, retorna NotFound
                return NotFound();

            contatoBanco.Nome = contato.Nome;       // dados do banco recebe dados que vem da requisição
            contatoBanco.Telefone = contato.Telefone;       // dados do banco recebe dados que vem da requisição
            contatoBanco.Ativo = contato.Ativo;     // dados do banco recebe dados que vem da requisição

            _context.Contatos.Update(contatoBanco);     // atualiza o contato no banco de dados
            _context.SaveChanges();     // salva as alterações

            return Ok(contatoBanco);    // retorna o contato atualizado
        }

        [HttpDelete("{id}")]    // deleta um contato
        public IActionResult Deletar(int id)
        {
            var contatoBanco = _context.Contatos.Find(id);     // busca o contato no banco de dados

            if (contatoBanco == null)       // se o contato não existir, retorna NotFound
                return NotFound();

            _context.Contatos.Remove(contatoBanco);       // remove o contato do banco de dados
            _context.SaveChanges();     // salva as alterações

            return NoContent();        // retorna que não há conteúdo
        }
    }
}