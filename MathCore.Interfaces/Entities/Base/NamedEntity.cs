namespace MathCore.Interfaces.Entities.Base
{
    public abstract class NamedEntity<TKey> : Entity<TKey>, INamedEntity<TKey>
    {
        public virtual string Name { get; set; }
    }

    public abstract class NamedEntity : NamedEntity<int>, INamedEntity
    {

    }
}