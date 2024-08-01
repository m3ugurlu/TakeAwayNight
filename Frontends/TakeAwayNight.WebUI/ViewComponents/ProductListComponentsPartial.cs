using Microsoft.AspNetCore.Mvc;
using TakeAwayNight.WebUI.Services.CatalogServices.ProductServices;

namespace TakeAwayNight.WebUI.ViewComponents
{
    public class ProductListComponentsPartial : ViewComponent
    {
        private readonly IProductService _productService;

        public ProductListComponentsPartial(IProductService productService)
        {
            _productService = productService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _productService.GetAllProductAsync();
            return View(values);
        }
    }
}
