using GameProjectSimule.Entities;
using InterfaceAbstractDemo.Entities;

namespace GameProjectSimule.Abstract
{
    public interface ICampaignService
    {
        public void Add(Campaign campaign);
        public void Update(Game campaign);
        public void Delete(Game campaign);
    }
}
