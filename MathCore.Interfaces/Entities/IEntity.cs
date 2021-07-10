namespace MathCore.Interfaces.Entities
{
    /// <summary>Сущность</summary>
    /// <typeparam name="TKey">Тип первичного ключа</typeparam>
    public interface IEntity<out TKey>
    {
        TKey Key { get; }
    }

    /// <summary>Сущность</summary>
    public interface IEntity : IEntity<int> { }
}