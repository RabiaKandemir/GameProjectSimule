using GameProjectSimule.Abstract;
using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectSimule.Entities
{
    public class Game:IEntity
    {
        public int Id { get; set; }
        public int CompaignId { get; set; }
        
        public string GameName { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public Campaign Campaign { get; set; }

    }
}
