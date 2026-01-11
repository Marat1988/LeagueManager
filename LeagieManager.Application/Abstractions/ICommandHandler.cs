using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeagueManager.Application.Abstractions
{
    public interface ICommandHandler<in TCommand> : IRequestHandler<TCommand> where TCommand : ICommand
    {
    }


    public interface ICommandHandler<in TCommand, TResponse> : IRequestHandler<TCommand, TResponse>
        where TCommand : ICommand<TResponse>
    {
    }
}
