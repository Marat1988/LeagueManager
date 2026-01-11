using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeagueManager.Application.Abstractions
{
    public interface IQuery<out TResponse> : IRequest<TResponse>
    {

    }
}
