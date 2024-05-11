using NArchitecture.Core.Application.Responses;

namespace Application.Features.Denemes.Queries.GetById;

public class GetByIdDenemeResponse : IResponse
{
    public int Id { get; set; }
    public string Name { get; set; }
}