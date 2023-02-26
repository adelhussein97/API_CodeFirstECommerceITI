using APIDTO.Category;
using Application.Contract;
using MediatR;


namespace Application.Features.Category.Queries.GetAllCategories
{
    public class GetAllCategoriesQueryHandler : IRequestHandler<GetAllCategoriesQuery, List<CategoryMinimalDto>>
    {
        private readonly ICategoryRepository category;

        public GetAllCategoriesQueryHandler(ICategoryRepository category)
        {
            this.category = category;
        }
        public async Task<List<CategoryMinimalDto>> Handle(GetAllCategoriesQuery request, CancellationToken cancellationToken)
        {
            return category.GetAllCategories().Select(c => new CategoryMinimalDto { Id=c.Id, Name=c.Name }).ToList();
        }
    }
}
