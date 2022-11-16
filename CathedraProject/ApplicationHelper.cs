using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CathedraProject
{
    public class ApplicationHelper
    {
        private static ApplicationHelper instance;

        public static ApplicationHelper Instance
        {
            get
            {
                if (instance == null)
                    instance = new ApplicationHelper();
                return instance;
            }
        }

        private ApplicationHelper() { }

        public bool IsAdmin { get; set; }
    }
}
