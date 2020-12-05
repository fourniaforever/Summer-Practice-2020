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
    public class ShopsLogic: IShopsLogic
    {
        private static IShopsDao _shopDao;
        public ShopsLogic()
        {
            _shopDao = new ShopsDAO();
        }
        public void Add(Shops shop)
        {
            _shopDao.Add(shop);
        }
        public void Remove(int id)
        {
            _shopDao.Remove(id);
        }
        public Shops GetById(int id)
        {
            return _shopDao.GetById(id);
        }
        public IEnumerable<Shops> GetAll()
        {
            return _shopDao.GetAll();
        }
        public IEnumerable<string> SelectShopsByRate(int rate)
        {
            return _shopDao.SelectShopsByRate(rate);
        }
    }
}
