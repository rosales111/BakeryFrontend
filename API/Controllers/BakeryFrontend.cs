using Microsoft.AspNetCore.Mvc;

namespace BakeryFrontend.Controllers
{
    [ApiController] 
    [Route("[controller]")]
    public class BakeryController : ControllerBase
    {
        [HttpGet("cinnamonrolls")]
        public string GetCinnamonRolls()
        {
            BakeryFactory factory = new BakeryFactory();
            Bakery bakery = factory.CreateBakery();
            bakery.OrderCinnamonRoll();
            return "Your cinnamon rolls have begun baking and will be done in 45 minutes.";
        }

        [HttpGet("cake")]
        public string GetCake()
        {
            BakeryFactory factory = new BakeryFactory();
            Bakery bakery = factory.CreateBakery();
            bakery.OrderCake();
            return "Your cake has begun baking and will be done in 50 minutes.";
        }

        [HttpGet("coffee")]
        public string GetCoffee()
        {
            BakeryFactory factory = new BakeryFactory();
            Bakery bakery = factory.CreateBakery();
            bakery.OrderCoffee();
            return "Your coffee has begun brewing and will be done in 5 minutes.";
        }
    }
}
