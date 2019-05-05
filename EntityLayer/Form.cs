using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer
{
    public class Form
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public virtual Field Field{ get; set; }
    }
}
