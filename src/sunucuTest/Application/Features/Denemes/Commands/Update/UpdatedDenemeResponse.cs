using NArchitecture.Core.Application.Responses;

namespace Application.Features.Denemes.Commands.Update;

public class UpdatedDenemeResponse : IResponse
{
    public int Id { get; set; }
    public string Name { get; set; }
}