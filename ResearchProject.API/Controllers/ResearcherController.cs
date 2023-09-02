using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ResearchProject.API.Data;
using ResearchProject.SHARED.Entities;

namespace ResearchProject.API.Controllers
{
    [ApiController]
    [Route("/Researcher")]
    public class ResearcherController : ControllerBase
    {
        private readonly DataContext _context;

        public ResearcherController(DataContext context)
        {
            _context = context;
        }
        //Obtener o visualizar Investigador
        [HttpGet]
        public async Task<ActionResult> GetResearcher()
        {
            return Ok(await _context.Researchers.ToListAsync());
        }

        //Obtener o visualizar investigador x id
        [HttpGet("{Id:int}")]
        public async Task<ActionResult> GetResearcherXid(int Id)
        {
            var resear = await _context.Researchers.FirstOrDefaultAsync(x => x.Id == Id);
            if (resear == null)
            {
                return NotFound();
            }

            return Ok(resear);
        }

        //Crear investigadores
        [HttpPost]
        public async Task<ActionResult> CreateResearcher(Researcher researcher)
        {
            _context.Add(researcher);
             await _context.SaveChangesAsync();

            return Ok(researcher);
        }

    }
}
