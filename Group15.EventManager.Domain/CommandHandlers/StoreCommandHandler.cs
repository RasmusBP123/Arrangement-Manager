using Group15.EventManager.Data.Interfaces;
using Group15.EventManager.Data.UnitOfWork;
using Group15.EventManager.Domain.Commands.Store;
using Group15.EventManager.Domain.Handlers;
using Group15.EventManager.Domain.Models;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Group15.EventManager.Domain.CommandHandlers
{
    public class StoreCommandHandler : Handler, IRequestHandler<CreateStoreCommand, bool>
    {
        private readonly IStoreRepository _storeRepository;

        public StoreCommandHandler(IUnitOfWork unitOfWork, IStoreRepository storeRepository) : base(unitOfWork)
        {
            _storeRepository = storeRepository;
        }

        public Task<bool> Handle(CreateStoreCommand request, CancellationToken cancellationToken)
        {
            Store store = new Store()
            {
                Name = request.Name,
                Address = request.Address,
                Region = request.Region,
                City = request.City,
            };

            _storeRepository.Add(store);
            _unitOfWork.Commit();

            return Task.FromResult(true);
        }
    }
}
