using GameProjectSimule.Abstract;
using GameProjectSimule.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectSimule.Concrete
{
    public class UserManager : IUserService
    {
        IUserCheckService _userCheckService;
        public UserManager(IUserCheckService userCheckService)
        {
            _userCheckService = userCheckService;
        }
        public void Add(User user)
        {
            if (_userCheckService.CheckIfRealPerson(user))
            {
                Console.WriteLine("Oyuncu eklendi");
            }
            else
            {
                throw new Exception("Not a valid person");
            }
        }

        public void Delete(User user)
        {
            Console.WriteLine("Oyuncu silindi");
        }

        public void Update(User user)
        {
            Console.WriteLine("Oyuncu güncellendi");
        }
    }
}
