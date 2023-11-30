using GameProjectSimule.Concrete;
using GameProjectSimule.Entities;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Entities;

namespace GameProjectSimule
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User()
            {
                Id = 1,
                FirstName = "Rabia",
                LastName = "Kandemir",
                DateOfBirth = new DateTime(1998,09,15),
                NationalityId="12365485"
            };
           
            UserManager userManager = new UserManager(new MernisServiceAdapter());
            userManager.Add(user);
             Game game = new Game()
            {
                Id = 1,
                CompaignId = 1,
                GameName = "Counter Strike",
                Price = 1000,
                Description = "Savaş oyunu"
            };
            Campaign campaign = new Campaign()
            {
                Id = 1,
                DiscountRate = 50,
                Name = "Kasım İndirimi"
            };
            GameManager gameManager = new GameManager();
            gameManager.Add(game);
            gameManager.Sale(game,user,campaign);


        }
    }
}