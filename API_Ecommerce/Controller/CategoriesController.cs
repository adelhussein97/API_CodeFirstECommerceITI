using Application.Features.Category.Queries.GetAllCategories;
using ECommerceDbContext;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Ecommerce.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly IMediator mediator;

        public CategoriesController(IMediator mediator)
        {
         
            this.mediator = mediator;
        }

        // localhost:5282/api/Category
        [HttpGet]
        public IActionResult GetAllCategories(GetAllCategoriesQuery query)
        {
            
            return Ok(mediator.Send(query));

        }
        // localhost:5282/api/CategoryDetails
        [HttpGet("{id}")]
        public IActionResult GetCategoryDetails(int id)
        {
            return Ok();

        }
        [HttpPost]
        public IActionResult AddCategory()
        {
            return Ok();

        }
        [HttpPut("{id}")]
        public IActionResult UpdateCategory()
        {
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteCategory()
        {
            return Ok();
        }
    }
}
