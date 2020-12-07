using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SummerPracticeProject.Entities;

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
