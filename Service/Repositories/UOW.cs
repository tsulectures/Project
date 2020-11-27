using DAL.Context;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Repositories
{
    public class UOW : IUOW
    {

        private PersonDbContext _context;

        private IPersonRepository _personRepository;

        private IDictionaryRepository _dictionaryRepository;
        public UOW(PersonDbContext context)
        {
            _context = context;
        }

        public IPersonRepository Person {
            get
            {
                if (_personRepository == null)
                    _personRepository = new PersonRepository(_context);
                return _personRepository;
            }
        }

        public IDictionaryRepository Dictionary
        {
            get
            {
                if (_dictionaryRepository == null)
                    _dictionaryRepository = new DictionaryRepository(_context);
                return _dictionaryRepository;
            }
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
