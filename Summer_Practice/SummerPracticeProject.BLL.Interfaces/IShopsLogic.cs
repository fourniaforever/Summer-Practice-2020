using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SummerPracticeProject.Entities;

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
