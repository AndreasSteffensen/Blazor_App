namespace BlazorApp.Data.Spotify
{
    public interface ISpotifyAccountService
    {
        Task<string> GetToken(string clientId, string clientSecret);
    }
}
