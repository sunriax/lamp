using System;
using System.Collections.Generic;

namespace RaGae.App.Lamp.Domain.Model
{
    public class Packet
    {
        public string Version { get; set; }
        public bool Status { get; set; }
        public bool Config { get; set; }
        public IEnumerable<Led> Mode { get; set; }
        public int Switch { get; set; }
        public int Sensor { get; set; }
    }
}