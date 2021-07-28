namespace RaGae.App.Lamp.Domain.Model
{
    public class Update
    {
        public string Directory { get; set; }
        public string Program { get; set; }
        public string Company { get; set; }
        public string Repository { get; set; }
        public bool Shell { get; set; }
        public bool NoWindow { get; set; }
    }
}