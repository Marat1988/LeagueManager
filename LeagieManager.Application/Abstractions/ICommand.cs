using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeagueManager.Application.Abstractions
{
    public interface ICommand: IRequest
    {
    }

    public interface ICommand<out TResponse>: IRequest<TResponse>
    {

    }
}
