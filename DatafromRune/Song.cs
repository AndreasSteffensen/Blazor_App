namespace BlazorApp_1.Data
{
    public class Song
    {
        private int listens = 0;
        private string name = string.Empty;

        public Song() 
        {
            this.Listens = -99;
            this.Name = "Song Titel unset";
        }
        public Song(int listens, string name) 
        {
            this.Listens = listens;
            if (name is not null) 
            {
                this.Name = name;
            }
        }

        public int Listens { get => listens; set => listens = value; }
        public string Name { get => name; set => name = value; }
    }
}
