using DAL.Context;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Repositories
{
    public class DictionaryRepository : RepositoryBase<Dictionary>, IDictionaryRepository
    {
        public DictionaryRepository(PersonDbContext context)
            : base(context)
        {
        }

        public IEnumerable<Dictionary> GetPersonFormComponents()
        {
            return FindByCondition(x => x.HasGender || x.HasPosition || x.HasPhoneType);
        }
    }
}
