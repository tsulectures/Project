using BLL.DTOs.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalData.Models
{
    public class PersonCUVM
    {
        public PersonCUDTO Person { get; set; }

        public PersonCUComponents Components { get; set; }
    }
}
