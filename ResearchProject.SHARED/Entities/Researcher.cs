using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResearchProject.SHARED.Entities
{
    public class Researcher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MemberShip { get; set; }

        public string Specialization { get; set;}
        public string Role { get; set; }

    }
}
