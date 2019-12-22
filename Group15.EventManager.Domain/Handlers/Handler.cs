using Group15.EventManager.Data.UnitOfWork;

namespace Group15.EventManager.Domain.Handlers
{
    public class Handler
    {
        protected readonly IUnitOfWork _unitOfWork;

        public Handler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
