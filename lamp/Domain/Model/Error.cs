namespace RaGae.App.Lamp.Domain.Model
{
    public class Error
    {
        public Error() { }

        public Error(string type, string message)
        {
            this.Type = type;
            this.Message = message;
        }

        public string Type { get; set; }
        public string Message { get; set; }
    }
}
