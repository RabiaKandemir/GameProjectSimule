using GameProjectSimule.Abstract;

namespace InterfaceAbstractDemo.Entities
{
    public class Campaign:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float DiscountRate { get; set; }
    }
}
