using GameProjectSimule.Entities;
using InterfaceAbstractDemo.Entities;
using System;

namespace GameProjectSimule.Abstract
{
    public interface IGameService
    {
        public void Add(Game game);
        public void Delete(Game game);
        public void Update(Game game);
        void Sale(Game game, User user, Campaign campaign);
    }
}
