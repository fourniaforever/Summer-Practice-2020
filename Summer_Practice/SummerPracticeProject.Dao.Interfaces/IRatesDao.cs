using SummerPracticeProject.Entities;
using System.Collections.Generic;

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