using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer
{
    public class Field
    {
        [Key, ForeignKey("Form")]
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} alanı gerekli")]
        public string Name { get; set; }

        [Required(ErrorMessage = "{0} alanı gerekli")]
        public string Surname { get; set; }

        public int Age { get; set; }
        public virtual Form Form { get; set; }
    }
}
