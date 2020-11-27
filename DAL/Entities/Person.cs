using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    public class Person
    {
        public int Id { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public DateTime BirthDate { get; set; }

        public int GenderId { get; set; }

        public int PositionId { get; set; }

        public string Email { get; set; }

        public string PersonalNumber { get; set; }

        public string Picture { get; set; }

        public ICollection<PhoneNumber> PhoneNumbers { get; set; }

        public Dictionary Gender { get; set; }

        public Dictionary Position { get; set; }

    }
}
