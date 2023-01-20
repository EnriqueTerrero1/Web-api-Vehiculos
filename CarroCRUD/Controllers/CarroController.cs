using AutoMapper;
using CarroCRUD.DTO;
using CarroCRUD.Entidades;
using CarroCRUD.Utilidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarroCRUD.Controllers
{
    [Route("api/Carros")]
    [ApiController]
    public class CarroController : Controller
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public CarroController(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }


        [HttpGet]

        public async Task<ActionResult<List<CarroDTO>>> Get()
        {

            var carros = await context.carros.Include(x=>x.Marca).ToListAsync();

            var carrosDTO = mapper.Map<List<CarroDTO>>(carros);

            return carrosDTO;
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CarroCreacionDTO carroCreacionDTO)
        {
            var carro = mapper.Map<Carro>(carroCreacionDTO);
            context.Add(carro);
            await context.SaveChangesAsync();
            return NoContent();
        }

        [HttpPut("{id:int}")]

        public async Task<ActionResult> Put(int id, [FromBody] CarroCreacionDTO carroCreacionDTO)
        {

            var carro =  context.carros.FirstOrDefault(x => x.Id == id);

            if (carro != null)
            {
                carro = mapper.Map(carroCreacionDTO, carro);
                await context.SaveChangesAsync();
            }

            
            return NoContent();

        }

        [HttpGet("{id:int}")]

        public async Task<ActionResult<CarroDTO>> Get(int id)
        {

            var carro = await context.carros.Include(x=>x.Marca).FirstOrDefaultAsync(x => x.Id == id);

            var carroDTO = mapper.Map<CarroDTO>(carro);

            return carroDTO;
        }

        [HttpDelete("{id:int}")]

        public async Task<ActionResult> Delete(int id)
        {
            var existe = await  context.carros.AnyAsync(x=>x.Id == id);

            if (!existe)
            {
                return NotFound();
            }

            context.Remove(new Carro() { Id = id });
            await context.SaveChangesAsync();
            return NoContent();
        }
      
    }
}
