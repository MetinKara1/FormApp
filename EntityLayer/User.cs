using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer
{
    public class User
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} alanı gerekli")]
        public string Name { get; set; }

        [Required(ErrorMessage = "{0} alanı gerekli")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "{0} alanı gerekli")]
        public string NickName { get; set; }

        [Required(ErrorMessage = "{0} alanı gerekli")]
        public string Password { get; set; }
    }
}
