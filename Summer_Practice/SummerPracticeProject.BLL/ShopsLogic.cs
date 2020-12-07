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
    public class ShopsLogic:IShopsLogic
    {
        private IShopsDao _shopsDao;
        public ShopsLogic(IShopsDao shopsDao)
        {
            _shopsDao = new ShopsDAO();
        }

        public void Add(Shops item)
        {
            _shopsDao.Add(item);
        }

        public IEnumerable<Shops> GetAll()
        {
            return _shopsDao.GetAll();
        }

        public Shops GetById(int id)
        {
            return _shopsDao.GetById(id);
        }

        public void Remove(int id)
        {
            _shopsDao.Remove(id);
        }

        public IEnumerable<string> SelectShopsByRate(int item)
        {
            return _shopsDao.SelectShopsByRate(item);
        }
    }
}
