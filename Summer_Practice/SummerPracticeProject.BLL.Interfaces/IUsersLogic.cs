using SummerPracticeProject.Entities;

namespace SummerPracticeProject.BLL.Interfaces
{
    public interface IUsersLogic
    {
        void Add(Users user);

        bool Authentication(Users user);

        void Edit(Users user);

        Users GetByLogin(string login);
    }
}