using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ResearchProject.API.Data;
using ResearchProject.SHARED.Entities;

namespace ResearchProject.API.Controllers
{
    [ApiController]
    [Route("/Projects")]
    public class ResearcherProjectController : ControllerBase
    {
        private readonly DataContext _context;

        public ResearcherProjectController(DataContext context)
        {
            _context = context;
        }

        //Obtener o visualizar Proyecto
        [HttpGet]
        public async Task<ActionResult> GetProjects()
        {
            return Ok(await _context.ResearchProjects.ToListAsync());
        }

        //Obtener o visualizar Proyecto x id
        [HttpGet("{Id:int}")]
        public async Task<ActionResult> GetProjectXid(int Id)
        {
            var resear = await _context.ResearchProjects.FirstOrDefaultAsync(x => x.Id == Id);
            if (resear == null)
            {
                return NotFound();
            }

            return Ok(resear);
        }

        //Crear Proyecto
        [HttpPost]
        public async Task<ActionResult> CreateProject(ResearcherProject projects)
        {
            _context.Add(projects);
            await _context.SaveChangesAsync();

            return Ok(projects);
        }
    }
}
