using SummerPracticeProject.Entities;
using System.Collections.Generic;

namespace SummerPracticeProject.BLL.Interfaces
{
    public interface IShopsLogic
    {
        void Add(Shops shop);

        void Remove(int id);

        Shops GetById(int id);

        IEnumerable<Shops> GetAll();

        IEnumerable<string> SelectShopsByRate(int rate);
    }
}