using System;
using System.Collections.Generic;
using System.Linq;
using SummerPracticeProject.Entities;
using System.Text;
using System.Threading.Tasks;

namespace SummerPracticeProject.Dao.Interfaces
{
    public interface IRatesDao
    {
        void Add(Rates item);
        void Remove(int id);
        Rates GetById(int id);
        IEnumerable<Rates> GetAll();
    }
}
