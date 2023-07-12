namespace BlazorApp.Data.Spotify
{
    public class Song
    {
        private int listens = 0;
        private string name = string.Empty;

        public Song()
        {
            Listens = -99;
            Name = "Song Titel unset";
        }
        public Song(int listens, string name)
        {
            Listens = listens;
            if (name is not null)
            {
                Name = name;
            }
        }

        public int Listens { get => listens; set => listens = value; }
        public string Name { get => name; set => name = value; }
    }
}
