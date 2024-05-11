using NArchitecture.Core.Application.Dtos;

namespace Application.Features.Denemes.Queries.GetList;

public class GetListDenemeListItemDto : IDto
{
    public int Id { get; set; }
    public string Name { get; set; }
}