namespace PhoneBook.Entity.Interfaces.Entities
{
    public interface IEntityBase<TKey> : IEntity
    {
        TKey Id { get; set; }
    }
}
