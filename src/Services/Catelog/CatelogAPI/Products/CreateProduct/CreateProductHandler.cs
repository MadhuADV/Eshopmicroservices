using CatelogAPI.Models;
using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;

namespace CatelogAPI.Products.CreateProduct;

public record CreateProductCommand(string Name, List<string> Category, string Description, string ImageFile, decimal Price)
    : IRequest<CreateProductResult>;
public record CreateProductResult(Guid Id);
internal class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, CreateProductResult>
{
    public Task<CreateProductResult> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        // Bussiness logic to create a Product
        throw new NotImplementedException();
    }
}

