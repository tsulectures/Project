﻿using DAL.Context;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Repositories
{
    public class PersonRepository : RepositoryBase<Person>, IPersonRepository
    {
        public PersonRepository(PersonDbContext context)
            : base(context)
        {
        }

        public IEnumerable<Person> GetAll()
        {
            return Context.People.Include(x => x.Gender);
        }
    }
}
