using System;
using System.Collections.Generic;
using System.Text;

namespace MocktanData.Interface
{
    public interface IMocktanDataService
    {
        /// <summary>
        /// Generates 10 mock data
        /// </summary>
        /// <typeparam name="T">Data type which will be generated.</typeparam>
        /// <returns>List of mock data</returns>
        List<T> GetData<T>() where T : new();
    }
}
