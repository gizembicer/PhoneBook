namespace PhoneBook.Entity.Interfaces.Entities
{
    public interface ISoftDelete
    {
        public bool IsDeleted { get; set; }
    }
}
