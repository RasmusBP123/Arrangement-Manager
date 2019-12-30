using Group15.EventManager.Domain.Core.Commands;
using Group15.EventManager.Domain.Models;

namespace Group15.EventManager.Domain.Commands.Store
{
    public class CreateStoreCommand : Command
    {
        public string Name { get; }
        public Address Address { get; }
        public Region Region { get; }
        public City City { get; }

        public CreateStoreCommand(string name, Address address, Region region, City city)
        {
            Name = name;
            Address = address;
            Region = region;
            City = city;
        }
        public CreateStoreCommand(string name)
        {
            Name = name;
        }
    }
}
