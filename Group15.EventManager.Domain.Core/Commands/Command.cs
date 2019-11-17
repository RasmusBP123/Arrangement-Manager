using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Group15.EventManager.Domain.Core.Commands
{
    public abstract class BaseCommand<TRepsonse> : IRequest<TRepsonse>
    {
    }

    public abstract class Command : BaseCommand<bool>
    {

    }
}
