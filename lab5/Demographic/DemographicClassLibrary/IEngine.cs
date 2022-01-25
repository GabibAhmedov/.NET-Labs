using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemographicClassLibrary
{
    interface IEngine
    {
        /// <summary>
        /// Инициализация имитационной модели
        /// </summary> 
        List<Person> GetPeople { get; }

        /// <summary>
        /// Получить год начала моделирования
        /// </summary> 
        int GetStartYear { get; }

        /// <summary>
        /// Получить год звершения моделирования
        /// </summary>
        int GetFinalYear { get; }

        /// <summary>
        /// Инициализация имитационной модели
        /// </summary>    
        void InitiateModel();

        /// <summary>
        /// Запуск имитационной модели
        /// </summary>
        void StartModel();

    }
}
