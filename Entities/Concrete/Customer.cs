using Core.Entities;

namespace Entities.Concrete
{
    public class Customer:User,IEntity 
    {
        public string CompanyName { get; set; }
    }
}
