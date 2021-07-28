using System;
using System.IO.Ports;

namespace RaGae.App.Lamp.Domain.Config
{
    public class SerialConfig
    {
        private int baud = 9600;
        private int databits = 8;

        public string Port { get; set; } = string.Empty;

        public int Baud
        {
            get => this.baud;
            set
            {
                if (value < 2400 || value > 38400)
                    throw new ArgumentOutOfRangeException(nameof(Baud));

                this.baud = value;
            }
        }

        public int DataBits
        {
            get => databits;
            set
            {
                if(value < 7 && value > 9)
                    throw new ArgumentOutOfRangeException(nameof(DataBits));

                this.databits = value;
            }
        }

        public Parity Parity { get; set; }
        public StopBits StopBits { get; set; } = StopBits.One;
    }
}