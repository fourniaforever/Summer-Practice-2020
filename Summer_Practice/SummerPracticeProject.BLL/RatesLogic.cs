using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SummerPracticeProject.Entities;
using SummerPracticeProject.BLL.Interfaces;
using SummerPracticeProject.DAL;
using SummerPracticeProject.Dao.Interfaces;

namespace SummerPracticeProject.BLL
{
    public class RatesLogic: IRatesLogic
    {
        private static IRatesDao _rateDao;
        public RatesLogic()
        {
            _rateDao = new RatesDAO();
        }
        public void Add(Rates rate)
        {
            _rateDao.Add(rate);
        }
        public void Remove(int id)
        {
            _rateDao.Remove(id);
        }
        public Rates GetById(int id)
        {
            return _rateDao.GetById(id);
        }
        public IEnumerable<Rates> GetAll()
        {
            return _rateDao.GetAll();
        }
    }
}
