using System.IO;
using System.Text.Json;

namespace RaGae.App.Lamp.Core
{
    public static class ConfigService
    {
        public static T LoadConfig<T>(string filename) where T : class
        {
            try
            {
                return JsonSerializer.Deserialize<T>(File.ReadAllText(filename));
            }
            catch
            {
                return null;
            }
        }

        public static bool WriteConfig<T>(string filename, T data)
        {
            try
            {
                File.WriteAllText(filename, JsonSerializer.Serialize(data));
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
