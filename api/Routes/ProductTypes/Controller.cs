using Ecommerce.Share.Controller;
using Ecommerce.Share.GenericRepository;

namespace Ecommerce.Routes.ProductTypes;

[Route("api/products/types")]
public class ProductTypesController : BaseAPIController
{
    private readonly IRepository<ProductType, int> productTypeRepository;

    public ProductTypesController(ILogger<ProductTypesController> logger, IRepository<ProductType, int> productTypeRepository)
        : base(logger)
    {
        this.productTypeRepository = productTypeRepository;
    }

    [HttpGet]
    public async Task<IActionResult> GetProductTypes()
    {
        var productTypes = await productTypeRepository.GetAllAsync();
        return Ok(productTypes);
    }
}