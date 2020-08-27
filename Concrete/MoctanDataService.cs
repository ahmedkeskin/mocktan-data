using MocktanData.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace MocktanData.Concrete
{
    public class MoctanDataService : IMocktanDataService
    {
        public List<T> GetData<T>() where T : new()
        {
            var mockList = new List<T>(10);
            for (int i = 0; i < 10; i++)
            {
                mockList.Add(new T());
            }
            return mockList;
        }
    }
}
