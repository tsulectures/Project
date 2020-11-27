using BLL.DTOs.Person;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interfaces
{
    public interface IPersonOperation
    {
        public IEnumerable<PersonListDTO> GetAll();

        PersonCUComponents GetPersonFormComponents();

        void CreatePerson(PersonCUDTO model);
    }
}
