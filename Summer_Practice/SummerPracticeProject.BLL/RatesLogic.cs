using SummerPracticeProject.BLL.Interfaces;
using SummerPracticeProject.DAL;
using SummerPracticeProject.Dao.Interfaces;
using SummerPracticeProject.Entities;
using System.Collections.Generic;

namespace SummerPracticeProject.BLL
{
    public class RatesLogic : IRatesLogic
    {
        private IRatesDao _ratesDao;

        public RatesLogic(IRatesDao ratesDao)
        {
            _ratesDao = new RatesDAO();
        }

        public void Add(Rates item)
        {
            _ratesDao.Add(item);
        }

        public IEnumerable<Rates> GetAll()
        {
            return _ratesDao.GetAll();
        }

        public Rates GetById(int id)
        {
            return _ratesDao.GetById(id);
        }

        public void Remove(int id)
        {
            _ratesDao.Remove(id);
        }
    }
}