using Microsoft.AspNetCore.Mvc;
using lotusApi.Models;
using lotusApi.Data;
using Microsoft.EntityFrameworkCore;

namespace lotusApi.Controllers{


    [ApiController]
    [Route("Categorias")]
    public class CategoriaController: Controller{

        [HttpPost]
        [Route("")]

        public async Task<ActionResult<Categoria>> Post([FromServices] DataContext context, [FromBody] Categoria body){
            if(!ModelState.IsValid){
                return BadRequest(ModelState);
            }

            var categoria = new Categoria(){
                Ramal = body.Ramal,
                Setor = body.Setor,
                Nome = body.Nome,
                Email = body.Email,
                Cell = body.Cell,
            };

            context.Categorias.Add(categoria);
            await context.SaveChangesAsync();

            return body;
        }

        [HttpGet]
        public async Task<ActionResult<List<Categoria>>> Listar([FromServices] DataContext context){
            var categorias = await context.Categorias.ToListAsync();
            return categorias;
        }
    }
}