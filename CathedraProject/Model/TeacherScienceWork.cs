using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CathedraProject.Model
{
    public class TeacherScienceWork
    {
        public int Id { get; set; }
        public virtual Teacher Teacher { get; set; }
        public string Name { get; set; }
    }
}
