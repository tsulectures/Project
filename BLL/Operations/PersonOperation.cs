using AutoMapper;
using BLL.DTOs.Person;
using BLL.Interfaces;
using DAL.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Operations
{
    public class PersonOperation : IPersonOperation
    {
        private readonly IUOW _uow;
        private readonly IMapper _mapper;

        public PersonOperation(IUOW uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public IEnumerable<PersonListDTO> GetAll()
        {
            var persons = _uow.Person.GetAll();
            return _mapper.Map<IEnumerable<PersonListDTO>>(persons);
        }

        public PersonCUComponents GetPersonFormComponents()
        {
            var dictionaries = _uow.Dictionary.GetPersonFormComponents();
            PersonCUComponents model = new PersonCUComponents();
            model.Genders = dictionaries.Where(x => x.HasGender).Select(x => new SelectListItem() { Text = x.Title, Value = x.Id.ToString() }).ToList();
            model.Positions = dictionaries.Where(x => x.HasPosition).Select(x => new SelectListItem() { Text = x.Title, Value = x.Id.ToString() }).ToList();
            model.PhoneTypes = dictionaries.Where(x => x.HasPhoneType).Select(x => new SelectListItem() { Text = x.Title, Value = x.Id.ToString() }).ToList();
            return model;
        }

        public void CreatePerson(PersonCUDTO model)
        {
            var person = _mapper.Map<Person>(model);
            _uow.Person.Create(person);
            _uow.Commit();
        }
    }
}
