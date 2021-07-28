using Microsoft.Extensions.Configuration;
using RaGae.App.Lamp.Core;
using RaGae.App.Lamp.Domain.Config;
using System;
using System.Globalization;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;

namespace RaGae.App.Lamp.Forms
{
    static class Program
    {
        private static SerialConfig serialConfig;
        private static SystemConfig systemConfig;

        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            AppDomain.CurrentDomain.UnhandledException += Application_UnhandledException;

            Thread.CurrentThread.CurrentCulture = CultureInfo.CurrentCulture;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.CurrentUICulture;

            Configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            SerialService = new(SerialPort);

            systemConfig = ConfigService.LoadConfig<SystemConfig>(Configuration.GetValue<string>(nameof(SystemConfig))) ?? new();
            serialConfig = ConfigService.LoadConfig<SerialConfig>(Configuration.GetValue<string>(nameof(SerialConfig))) ?? new();

            try
            {
                SerialService.SerialConfig = SerialConfig;
                SerialService.Setup();
            }
            catch { }

            Timer = new()
            {
                Enabled = true,
                Interval = Configuration.GetValue<int>(nameof(Timer)) * 1000,
            };
            Timer.Start();

            NotifyIcon = new()
            {
                Text = nameof(Lamp),
                Visible = true,
                Icon = Resources.ImageResource.Icon
            };

            Application.Run(new FormMain());

            NotifyIcon.Visible = false;
            NotifyIcon?.Dispose();
            SerialService?.Dispose();
            SerialPort?.Dispose();
            Timer?.Dispose();
        }

        private static void Application_UnhandledException(object sender, UnhandledExceptionEventArgs e) => MessageBox.Show((e.ExceptionObject as Exception)?.Message, Resources.StringResource.GlobalException, MessageBoxButtons.OK, MessageBoxIcon.Error);

        private static SerialPort SerialPort { get; set; } = new();

        public static IConfiguration Configuration { get; private set; }

        public static NotifyIcon NotifyIcon { get; private set; }
        public static System.Windows.Forms.Timer Timer { get; private set; }
        public static SerialService SerialService { get; private set; }

        public static SerialConfig SerialConfig => serialConfig;
        public static SystemConfig SystemConfig => systemConfig;

        public static bool Save()
        {
            bool system = ConfigService.WriteConfig(Configuration.GetValue<string>(nameof(SystemConfig)), SystemConfig);
            bool serial = ConfigService.WriteConfig(Configuration.GetValue<string>(nameof(SerialConfig)), SerialConfig);

            return (system && serial);
        }
    }
}
