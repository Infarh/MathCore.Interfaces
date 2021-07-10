using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MathCore.Interfaces.Repositories
{
    /// <summary>Репозиторий сущностей</summary>
    /// <typeparam name="T">Тип элементов, хранимых в репозитории</typeparam>
    public interface IRepository<T>
    {
        /// <summary>Существует ли в репозитории указанный элемент</summary>
        /// <param name="item">Проверяемый элемент</param>
        /// <param name="Cancel">Признак отмены асинхронной операции</param>
        /// <returns>Истина, если указанная элемент существует в репозитории</returns>
        Task<bool> Exist(T item, CancellationToken Cancel = default);

        /// <summary>Получить число хранимых элементов</summary>
        /// <param name="Cancel">Признак отмены асинхронной операции</param>
        Task<int> GetCount(CancellationToken Cancel = default);

        /// <summary>Извлечь все элементы из репозитория</summary>
        /// <param name="Cancel">Признак отмены асинхронной операции</param>
        /// <returns>Перечисление всех элементов репозитория</returns>
        Task<IEnumerable<T>> GetAll(CancellationToken Cancel = default);

        /// <summary>Получить элементы репозитория пропустив часть в начале и выбрав указанное количество</summary>
        /// <param name="Skip">Количество пропускаемых элементов</param>
        /// <param name="Count">Количество выбираемых элементов</param>
        /// <param name="Cancel">Признак отмены асинхронной операции</param>
        /// <returns></returns>
        Task<IEnumerable<T>> Get(int Skip, int Count, CancellationToken Cancel = default);

        /// <summary>Получить страницу элементов с указанным индексом и указанного размера</summary>
        /// <param name="PageIndex">Индекс страницы начиная с нуля</param>
        /// <param name="PageSize">Размер страницы</param>
        /// <param name="Cancel">Признак отмены асинхронной операции</param>
        /// <returns>Страница элементов репозитория</returns>
        Task<IPage<T>> GetPage(int PageIndex, int PageSize, CancellationToken Cancel = default);

        /// <summary>Добавить элемент в репозиторий</summary>
        /// <param name="item">Добавляемый в репозиторий элемент</param>
        /// <param name="Cancel">Признак отмены асинхронной операции</param>
        /// <returns>Добавленный элемент</returns>
        Task<T> Add(T item, CancellationToken Cancel = default);

        /// <summary>Обновить состояние указанного элемента в репозитории</summary>
        /// <param name="item">Обновляемый элемент</param>
        /// <param name="Cancel">Признак отмены асинхронной операции</param>
        /// <returns>Обновлённый элемент</returns>
        Task<T> Update(T item, CancellationToken Cancel = default);

        /// <summary>Удаление элемента из репозитория</summary>
        /// <param name="item">Удаляемый из репозитория элемент</param>
        /// <param name="Cancel">Признак отмены асинхронной операции</param>
        /// <returns>Удалённый из репозитория элемент</returns>
        Task<T> Delete(T item, CancellationToken Cancel = default);
    }
}
