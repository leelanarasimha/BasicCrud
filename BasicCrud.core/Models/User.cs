using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BasicCrud.core.Models
{
    public class User
    {
        public int Id {get; set;}
        
        [Required, StringLength(80)]
        public String Name { get; set; }

        [Required, EmailAddress]
        public String Email { get; set; }

        [Required]
        public Nullable<int> Age { get; set; }
        public Location Location { get; set; }
    }
}
