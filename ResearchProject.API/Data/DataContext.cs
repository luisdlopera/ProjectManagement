using Microsoft.EntityFrameworkCore;
using ResearchProject.SHARED.Entities;

namespace ResearchProject.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Researcher> Researchers { get; set; }

        public DbSet<ResearcherProject> ResearchProjects { get; set; }



    }




}
