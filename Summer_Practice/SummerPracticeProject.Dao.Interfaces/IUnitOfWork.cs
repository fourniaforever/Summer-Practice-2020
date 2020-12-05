using System;
using System.Collections.Generic;
using System.Linq;
using SummerPracticeProject.Entities;
using System.Text;
using System.Threading.Tasks;

namespace SummerPracticeProject.Dao.Interfaces
{
    public interface IUnitOfWork:IDisposable
    {
        IRepository<Shops> Shops { get; }
        IRepository<Rates> Rates { get; }
        IRepository<Users> Users { get; }
        void Save();
    }
}
