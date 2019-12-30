using Group15.EventManager.Data.Interfaces;
using Group15.EventManager.Data.Repositories;
using Group15.EventManager.Data.UnitOfWork;
using Group15.EventManager.Domain.CommandHandlers;
using Group15.EventManager.Domain.Commands.Store;
using NUnit.Framework;
using System.Threading;
using System.Threading.Tasks;

namespace Tests.Commands.CreateStore
{
    [TestFixture]
    public class CreateStoreCommandTest : CommandTestDatabase
    {
        private IStoreRepository _repository;
        private IUnitOfWork _unitOfWork;

        [SetUp]
        public void StartUp()
        {
            _repository = new StoreRepository(Context);
            _unitOfWork = new UnitOfWork(Context);
        }

        [Test]
        public async Task CreateStore()
        {
            var request = new CreateStoreCommand("Vinbutik");
            var handler = new StoreCommandHandler(_unitOfWork, _repository);

            var result = await handler.Handle(request, CancellationToken.None);
            Assert.AreEqual(true, result);
        }


    }
}
