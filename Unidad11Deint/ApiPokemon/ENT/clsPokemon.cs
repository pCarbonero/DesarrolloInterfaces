namespace ENT
{
    public class clsPokemon
    {
        public string name {get; set;}
        public string url {get; set;}

        public clsPokemon(string name, string url)
        {
            this.name = name;
            this.url = url;
        }

        public clsPokemon() { }
    }
}
