using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    public class Dictionary
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public bool HasGender { get; set; }

        public bool HasPosition { get; set; }

        public bool HasPhoneType { get; set; }

        public ICollection<Person> PersonGenders{ get; set; }

        public ICollection<Person> PersonPositions { get; set; }

        public ICollection<PhoneNumber> PhoneTypes{ get; set; }
    }
}
