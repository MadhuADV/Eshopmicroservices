using MediatR;

namespace BuildingBlocks.CQRS;

public interface ICommandHandler<in TCommmad>
    : ICommandHandler<TCommmad, Unit>
    where TCommmad : ICommand<Unit>
{

}
public interface ICommandHandler<in TCommand, TResponse> 
    : IRequestHandler<TCommand, TResponse>
    where TCommand : ICommand<TResponse>
    where TResponse : notnull
{
}
