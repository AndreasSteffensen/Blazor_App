using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BlazorApp.Data.Spotify
{
    public class SpotifyController 
    {
        private readonly ISpotifyAccountService _SpotifyAccountService;
        private readonly IConfiguration _configuration;

        public SpotifyController(ISpotifyAccountService spotify, IConfiguration configuration)
        {
            _SpotifyAccountService = spotify;
            _configuration = configuration;
        }
        public async Task<IActionResult> Index()
        {
            try
            {
                var token = await _SpotifyAccountService.GetToken(_configuration["Spotify:clientId"], _configuration["Spotify:ClientSecret"]);
            }
            catch (Exception ex) 
            {
                Debug.WriteLine(ex);
            }
        }
    }

}
