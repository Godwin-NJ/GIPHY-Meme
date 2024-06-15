using GiphyLibrary.Interfaces;
using GiphyLibrary.Models;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiphyLibrary.Services
{
    public class GiphyServices : IGiphyServices
    {
      //  private static IGetRandomGif? _getRandomGif;
        private IConfiguration _configuration;
        public GiphyServices( IConfiguration configuration)
        {
          //  _getRandomGif = getRandomGif;
            _configuration = configuration;
        }

        public async Task<GiphyModel> GetRandomGifBasedOnSearchCritera(string searchCritera)
        {
            var giphyKey = _configuration.GetSection("Giphy_API_Key").Value;
            using (var client = new HttpClient())
            {
                var url = new Uri($"http://api.giphy.com/v1/gifs/search?api_key={giphyKey}&q={searchCritera}&limit=1");
                var response = await client.GetAsync(url);
                string json;
                using (var content = response.Content)
                {
                    json = await content.ReadAsStringAsync();
                }

                var radomGifData = JsonConvert.DeserializeObject<GiphyModel?>(json);

                return radomGifData;
            }
        }
    }
}
