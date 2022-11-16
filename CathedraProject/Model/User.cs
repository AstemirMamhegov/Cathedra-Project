using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CathedraProject.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Password { get; set; }
        public string Login { get; set; }
        public bool IsAdmin { get; set; }
    }
}
