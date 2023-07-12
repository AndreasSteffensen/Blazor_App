namespace BlazorApp.Data.Spotify
{
    public interface ISpotifyService
    {
        public Task<IEnumerable<Song>> GetNewSong(string contryCode, int limit, string accessToken);
    }
}
