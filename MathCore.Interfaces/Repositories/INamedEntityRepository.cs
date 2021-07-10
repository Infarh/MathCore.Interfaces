using System.Threading;
using System.Threading.Tasks;

using MathCore.Interfaces.Entities;

namespace MathCore.Interfaces.Repositories
{
    /// <summary>Репозиторий именованных сущностей</summary>
    /// <typeparam name="T">Тип сущности</typeparam>
    /// <typeparam name="TKey">Тип первичного ключа сущности</typeparam>
    public interface INamedEntityRepository<T, in TKey> : IEntityRepository<T, TKey> where T : INamedEntity<TKey>
    {
        /// <summary>Проверка наличия сущности по её имени</summary>
        /// <param name="Name">Проверяемое имя сущности</param>
        /// <param name="Cancel">Признак отмены асинхронной операции</param>
        /// <returns>Истина, если сущность с указанным именем существует в репозитории</returns>
        Task<bool> ExistName(string Name, CancellationToken Cancel = default);

        /// <summary>Получение сущности по её имени</summary>
        /// <param name="Name">Имя сущности, которое надо получить</param>
        /// <param name="Cancel">Признак отмены асинхронной операции</param>
        /// <returns>Сущность с указанным именем</returns>
        Task<T> GetByName(string Name, CancellationToken Cancel = default);

        /// <summary>Удаление сущности с указанным именем</summary>
        /// <param name="Name">Имя сущности, которую надо удалить из репозитория</param>
        /// <param name="Cancel">Признак отмены асинхронной операции</param>
        /// <returns>Удалённая из репозитория сущность, либо null, если сущность не найдена</returns>
        Task<T> DeleteByName(string Name, CancellationToken Cancel = default);
    }

    /// <summary>Репозиторий именованных сущностей</summary>
    /// <typeparam name="T">Тип сущности</typeparam>
    public interface INamedEntityRepository<T> : INamedEntityRepository<T, int> where T : INamedEntity { }

}