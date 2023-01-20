using AutoMapper;
using CarroCRUD.DTO;
using CarroCRUD.Entidades;
using CarroCRUD.Utilidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarroCRUD.Controllers
{
    [ApiController]
    [Route("api/marcas")]
  
    public class MarcaController : Controller
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public MarcaController(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }


        [HttpGet]
        public async Task<ActionResult<List<MarcaDTO>>> Get()
        {

            var marcas = await context.marcas.Include(x=>x.carros).ToListAsync();

            var marcasDTO = mapper.Map<List<MarcaDTO>>(marcas);

            return marcasDTO;
        }
        [HttpGet("{id:int}")]

        public async Task<ActionResult<MarcaDTO>> Get(int id)
        {

            var marca = await context.marcas.FirstOrDefaultAsync(x=>x.Id==id);

            var marcaDTO = mapper.Map<MarcaDTO>(marca);

            return marcaDTO;
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] MarcaCreacionDTO marcaCreacionDTO)
        {
            var marca = mapper.Map<Marca>(marcaCreacionDTO);

            await context.marcas.AddAsync(marca);
            
            context.SaveChanges();
            return NoContent();
        }


      

        [HttpDelete("{id:int}")]

        public async Task<ActionResult> Delete(int id)
        {
            var existe = await context.marcas.AnyAsync(x => x.Id == id);

            if (!existe)
            {
                return NotFound();
            }

            context.Remove(new Marca() {Id =id });
            await context.SaveChangesAsync();
            return NoContent();
        }

        [HttpPut("{id:int}")]

        public async Task<ActionResult> put(int id, [FromBody] MarcaCreacionDTO marcaCreacionDTO)
        {

            var marca = await context.marcas.FirstOrDefaultAsync(x => x.Id == id);

            if(marca != null)
            {
                marca = mapper.Map(marcaCreacionDTO, marca);
                context.SaveChanges();
            }

            return NoContent();




        }
    }
}
