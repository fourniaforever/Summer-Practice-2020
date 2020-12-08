using SummerPracticeProject.Entities;
using System.Collections.Generic;

namespace SummerPracticeProject.Dao.Interfaces
{
    public interface IShopsDao
    {
        void Add(Shops item);

        void Remove(int id);

        Shops GetById(int id);

        IEnumerable<Shops> GetAll();

        IEnumerable<string> SelectShopsByRate(int item);
    }
}