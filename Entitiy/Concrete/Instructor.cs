using Entitiy.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitiy.Concrete
{
    public class Instructor : IEntitiy
    {
        public int Id { get; set; }
        public string InstructorFirstName { get; set; }
        public string InstructorLastName { get; set; }

    }
}
