using System.Collections.Generic;

namespace MathCore.Interfaces.Repositories
{
    /// <summary>Страница элементов</summary>
    /// <typeparam name="T">Тип элементов</typeparam>
    public interface IPage<out T>
    {
        /// <summary>Перечисление элементов страницы</summary>
        IEnumerable<T> Items { get; }

        /// <summary>Общее количество элементов на странице</summary>
        int ItemsCount { get; }

        /// <summary>Полное количество элементов на всех страницах, доступное для запроса</summary>
        int TotalCount { get; }

        /// <summary>Индекс (номер) страницы начиная с нуля</summary>
        int PageIndex { get; }

        /// <summary>Полное количество страниц</summary>
        int TotalPagesCount { get; }
    }
}
