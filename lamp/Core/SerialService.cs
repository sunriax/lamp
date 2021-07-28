using RaGae.App.Lamp.Domain.Config;
using RaGae.App.Lamp.Domain.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Ports;
using System.Linq;
using System.Text.Json;

namespace RaGae.App.Lamp.Core
{
    public delegate void DataHandler(Packet packet);
    public delegate void ErrorHandler(Error error);

    public class SerialService : IDisposable
    {
        public event DataHandler DataHandler;
        public event ErrorHandler ErrorHandler;

        private SerialPort serialPort;

        public SerialService(SerialPort serialPort, SerialConfig serialConfig = null)
        {
            this.serialPort = serialPort;
            this.SerialConfig = serialConfig;

            this.serialPort.DataReceived += SerialPort_DataReceived;
            this.serialPort.ErrorReceived += SerialPort_ErrorReceived;
        }

        public SerialConfig SerialConfig { get; set; }

        public bool Status { get => serialPort.IsOpen; }

        public void Setup()
        {
            if (this.SerialConfig is null)
                return;

            if (serialPort.IsOpen)
                serialPort.Close();

            if (!SerialPort.GetPortNames().Any(p => p.ToLower() == this.SerialConfig.Port.ToLower()))
                throw new KeyNotFoundException(nameof(SerialConfig.Port));

            serialPort.PortName = SerialConfig.Port;
            serialPort.DataBits = SerialConfig.DataBits;
            serialPort.Parity = SerialConfig.Parity;
            serialPort.StopBits = SerialConfig.StopBits;
            serialPort.ReadBufferSize = 8192;
            serialPort.WriteBufferSize = 8192;

            this.Open();
        }

        public void Transmit(int label, Led led)
        {
            if (this.Open())
                serialPort.Write($"[{label}:{led.R},{led.G},{led.B},{led.A},{led.Time}]");
        }

        public void Transmit_Termination()
        {
            if(this.Open())
                serialPort.Write("q");
        }

        public bool Open()
        {
            if (!serialPort.IsOpen)
                try
                {
                    serialPort.Open();
                }
                catch
                {
                    return false;
                }
            return true;
        }


        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort s = sender as SerialPort;

            string data = s.ReadLine().Replace(Environment.NewLine, string.Empty);

            try
            {
                Debug.WriteLine(data);

                Packet p = JsonSerializer.Deserialize<Packet>(data);
                this.DataHandler?.Invoke(p);
            }
            catch
            {
                s.DiscardInBuffer();
            }
        }

        private void SerialPort_ErrorReceived(object sender, SerialErrorReceivedEventArgs e)
        {
            switch (e.EventType)
            {
                case SerialError.Frame:
                    this.ErrorHandler?.Invoke(new Error(nameof(SerialPort), nameof(SerialError.Frame)));
                    break;
                case SerialError.Overrun:
                    this.ErrorHandler?.Invoke(new Error(nameof(SerialPort), nameof(SerialError.Overrun)));
                    break;
                case SerialError.RXOver:
                    this.ErrorHandler?.Invoke(new Error(nameof(SerialPort), nameof(SerialError.RXOver)));
                    break;
                case SerialError.RXParity:
                    this.ErrorHandler?.Invoke(new Error(nameof(SerialPort), nameof(SerialError.RXParity)));
                    break;
                case SerialError.TXFull:
                    this.ErrorHandler?.Invoke(new Error(nameof(SerialPort), nameof(SerialError.TXFull)));
                    break;
            }
        }

        public void Dispose()
        {
            this.serialPort.Dispose();
        }
    }
}
