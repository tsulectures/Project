using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTOs.Person
{
    public class PersonCUComponents
    {
        public List<SelectListItem> Genders { get; set; }

        public List<SelectListItem> Positions { get; set; }

        public List<SelectListItem> PhoneTypes { get; set; }
    }
}
