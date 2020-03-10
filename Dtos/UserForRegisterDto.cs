using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(int.MaxValue, MinimumLength =5, ErrorMessage ="You must specify password minimum 5 characters")]
        public string Password { get; set; }
    }
}
