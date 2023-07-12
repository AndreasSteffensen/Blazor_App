using System.Runtime.CompilerServices;

namespace BlazorApp.Data.Spotify
{
    public class SpotifyService : ISpotifyService
    {
        private readonly HttpClient _httpClient;
        public SpotifyService(HttpClient httpClient) 
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Song>> GetTopSongs(string type, string timeRange, string accessToken)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("bearer", accessToken);

            var response = await _httpClient.GetAsync($"browse/me/top/$type={type}$time_range={timeRange}");

            response.EnsureSuccessStatusCode();

            using var responseStream = await response.Content.ReadAsStreamAsync();

        }
    }
}
