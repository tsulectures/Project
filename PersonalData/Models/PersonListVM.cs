using BLL.DTOs.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalData.Models
{
    public class PersonListVM
    {
        public IEnumerable<PersonListDTO> Persons { get; set; }
    }
}
