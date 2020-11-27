using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTOs.Person
{
    public class PersonListDTO
    {
        public int Id { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string Gender { get; set; }

        public string Picture { get; set; }

        public string Email { get; set; }

    }
}
