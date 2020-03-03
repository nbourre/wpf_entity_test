using System.Collections.Generic;

namespace wpf_entity_test
{
    public class Person
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List<Contact> Contacts { get; } = new List<Contact>();

        public string Phone
        {
            get
            {
                if (Contacts != null && Contacts.Count > 0)
                {
                    return Contacts[0].AllShort;
                } else
                {
                    return "None";
                }
            }
            set
            {
                Contacts.Add(new Contact() { Person = this, ContactType = "Téléphone", Content = value });
            }
        }
    }
}
