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
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Kampanya eklendi");
        }

        public void Delete(Game campaign)
        {
            Console.WriteLine("Kampanya silindi");
        }

        public void Update(Game campaign)
        {
            Console.WriteLine("Kampanya güncellendi");
        }
    }
}
