namespace MathCore.Interfaces.Entities
{
    public interface INamedEntity<out TKey> : IEntity<TKey>
    {
        string Name { get; }
    }

    public interface INamedEntity : INamedEntity<int>, IEntity { }
}