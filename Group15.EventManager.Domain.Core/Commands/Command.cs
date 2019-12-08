﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Group15.EventManager.Domain.Core.Commands
{
    public abstract class BaseCQ<TResponse> : IRequest<TResponse>
    {
    }

    public abstract class Command : BaseCQ<bool>
    {

    }
}
