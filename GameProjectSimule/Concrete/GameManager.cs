using GameProjectSimule.Abstract;
using GameProjectSimule.Entities;
using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectSimule.Concrete
{
    public class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("Oyun eklendi");
        }

        public void Delete(Game game)
        {
            Console.WriteLine("Oyun silindi");
        }

        public void Sale(Game game, User user, Campaign campaign)
        {
            Console.WriteLine($"{game.GameName} Oyunu {user.FirstName} {user.LastName} isimli müşteriye {campaign.Name} kampanyasıyla yüzde {campaign.DiscountRate} indirim oranı ile {game.Price - (game.Price * (campaign.DiscountRate / 100))} Tl'ye satıldı. ");
        }

        public void Update(Game game)
        {
            Console.WriteLine("Oyun güncellendi");
        }
    }
}
