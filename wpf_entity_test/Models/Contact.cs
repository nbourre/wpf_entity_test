namespace wpf_entity_test
{
    public class Contact
    {
        public int ContactId { get; set; }
        public string Content { get; set; }

        public string ContactType { get; set; }

        public string AllShort => $"{ContactType} : {Content}";

        public int PersonId { get; set; }
        public Person Person { get; set; }
    }
}
