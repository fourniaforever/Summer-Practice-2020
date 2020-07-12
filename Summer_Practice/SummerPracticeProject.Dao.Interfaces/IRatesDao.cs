using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SummerPracticeProject.Entities;

namespace SummerPracticeProject.Dao.Interfaces
{
    public interface IRatesDao
    {
        void Add(Rates rate);
        void Remove(int id);
        Rates GetById(int id);
        IEnumerable<Rates> GetAll();
        Rates GetByRate(int rate);

        Rates GetByShopId(int id);
    }
}
