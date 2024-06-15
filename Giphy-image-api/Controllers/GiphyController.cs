using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using GiphyLibrary.Services;
using GiphyLibrary.Interfaces;

namespace Giphy_image_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GiphyController : ControllerBase
    {
        private readonly IGiphyServices _giphyServices;
        public GiphyController(IGiphyServices giphyServices) 
        { 
            _giphyServices = giphyServices;
        
        }
        [HttpGet("GetRandomGif")]
        //[Route("v1/giphy/random/{searchCritera}")]
        public async Task<IActionResult> GetRandomGif(string searchCriteria)
        {
            var result = await _giphyServices.GetRandomGifBasedOnSearchCritera(searchCriteria);
            return Ok(result);
        }
    }
}
