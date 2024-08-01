using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TakeAwayNight.Basket.Dtos;
using TakeAwayNight.Basket.LoginServices;
using TakeAwayNight.Basket.Services;

namespace TakeAwayNight.Basket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketsController : ControllerBase
    {
        private readonly IBasketService _basketService;
        private readonly ILoginService _loginServices;

        public BasketsController(IBasketService basketService, ILoginService loginServices)

        {
            _basketService = basketService;
            _loginServices = loginServices;
        }

        [HttpGet]
        public async Task<IActionResult> GetMyBasketDetail()
        {
            var values = await _basketService.GetBasket(_loginServices.GetUserId);
            return Ok(values);
        }

        [HttpPost]

        public async Task<IActionResult> SaveMyBasket(BasketTotalDto basket)
        {
            basket.UserId = _loginServices.GetUserId;
            await _basketService.SaveBasket(basket);
            return Ok("Sepeteki Değişiklikler Kayıt Edilmiştir.");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteBasket()
        {
            await _basketService.DeleteBasket(_loginServices.GetUserId);
            return Ok("Silme İşlemi Yapıldı!");
        }
    }
}
