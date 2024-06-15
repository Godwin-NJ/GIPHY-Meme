//using GiphyLibrary.Interfaces;
//using GiphyLibrary.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Newtonsoft.Json;

//namespace GiphyLibrary.Services
//{
//    public class GetRandomGif : IGetRandomGif
//    {
             
//            public async Task<GiphyModel> ReturnRandomGifBasedOnTag(string searchCritera)
//            {
//                const string giphyKey = "";
//                using (var client = new HttpClient())
//                {
//                    var url = new Uri($"http://api.giphy.com/v1/gifs/search?api_key={giphyKey}&q={searchCritera}&limit=1");
//                    var response = await client.GetAsync(url);
//                    string json;
//                    using (var content = response.Content)
//                    {
//                        json = await content.ReadAsStringAsync();
//                    }
                
//                var radomGifData = JsonConvert.DeserializeObject<GiphyModel?>(json);

//                return radomGifData;
//                }
//            }
        
//    }
//}
