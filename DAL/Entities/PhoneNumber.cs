using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    public class PhoneNumber
    {
        public int Id { get; set; }

        public int PhoneTypeId { get; set; }

        public string Number { get; set; }

        public int PersonId { get; set; }

        public Person Person { get; set; }

        public Dictionary PhoneType { get; set; }
    }
}
