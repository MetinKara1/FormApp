using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class FormGetPost
    {
        public int Id { get; set; }
        public Form Form { get; set; }
        public IEnumerable<Form> FormList { get; set; }
    }
}
