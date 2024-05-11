using NArchitecture.Core.Application.Responses;

namespace Application.Features.Denemes.Commands.Delete;

public class DeletedDenemeResponse : IResponse
{
    public int Id { get; set; }
}