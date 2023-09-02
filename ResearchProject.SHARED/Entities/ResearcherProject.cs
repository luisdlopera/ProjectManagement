using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResearchProject.SHARED.Entities
{
    public class ResearcherProject
    {
        public int Id { get; set; }
        public string ProjectName { get; set; }

        [DataType(DataType.Date)]//esto es ara validar la fecha
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime EndingDate { get; set; }
        public string ProjectLeader { get; set; }
        public string ProjectDescription { get; set; }
        public string ResearchArea{ get; set; }
    }
}
