namespace RaGae.App.Lamp.Domain.Config
{
    public class SystemConfig
    {
        public bool Notification { get; set; }
        public int BallonTime { get; set; } = 5;
        public string BallonTitle { get; set; }
        public string BallonText { get; set; }
    }
}