using GameProjectSimule.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectSimule.Abstract
{
    public interface IUserService
    {
        public void Add(User user);
        public void Update(User user);
        public void Delete(User user);
    }
}
