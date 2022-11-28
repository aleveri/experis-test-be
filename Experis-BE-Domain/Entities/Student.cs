namespace Experis_BE_Domain.Entities
{
    public class Student: BaseEntity
    {
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Career { get; set; }
    }
}
