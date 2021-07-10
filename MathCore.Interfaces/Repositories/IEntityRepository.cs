using System.Threading;
using System.Threading.Tasks;

using MathCore.Interfaces.Entities;

namespace MathCore.Interfaces.Repositories
{
    /// <summary>Репозиторий сущностей</summary>
    /// <typeparam name="T">Тип сущности</typeparam>
    /// <typeparam name="TKey">Тип первичного ключа сущности</typeparam>
    public interface IEntityRepository<T, in TKey> : IRepository<T> where T : IEntity<TKey>
    {
        /// <summary>Существует ли сущность с указанным идентификатором</summary>
        /// <param name="Id">Проверяемый идентификатор сущности</param>
        /// <param name="Cancel">Признак отмены асинхронной операции</param>
        /// <returns>Истина, если сущность с указанным идентификатором существует в репозитории</returns>
        Task<bool> ExistId(TKey Id, CancellationToken Cancel = default);

        /// <summary>Получить сущность по идентификатору</summary>
        /// <param name="Id">Идентификатор сущности</param>
        /// <param name="Cancel">Признак отмены асинхронной операции</param>
        /// <returns>Сущность с указанным идентификатором, либо null в случае её отсутствия</returns>
        Task<T> GetById(TKey Id, CancellationToken Cancel = default);

        /// <summary>Удалить сущность по её идентификатору</summary>
        /// <param name="id">Идентификатор удаляемой сущности</param>
        /// <param name="Cancel">Признак отмены асинхронной операции</param>
        /// <returns>Удалённая из репозитория сущность</returns>
        Task<T> DeleteById(TKey id, CancellationToken Cancel = default);
    }

    /// <summary>Репозиторий сущностей</summary>
    /// <typeparam name="T">Тип сущности</typeparam>
    public interface IEntityRepository<T> : IEntityRepository<T, int> where T : IEntity { }
}