using SummerPracticeProject.Entities;
using System.Collections.Generic;

namespace SummerPracticeProject.BLL.Interfaces
{
    public interface IRatesLogic
    {
        void Add(Rates rate);

        void Remove(int id);

        Rates GetById(int id);

        IEnumerable<Rates> GetAll();
    }
}