using Newtonsoft.Json;
using System.IO;

namespace BCW.ConsoleStore.MyUtils
{
    public class Helpers : IHelpers
    {
        public T DeserializeFromFile<T>(string path)
        {
            var serialized = File.ReadAllText(path);
            var value = JsonConvert.DeserializeObject<T>(serialized);
            return value;
        }

        public void SerializeToFile(object value, string path)
        {
            var directory = Path.GetDirectoryName(path);
            if (!string.IsNullOrWhiteSpace(directory))
            {
                Directory.CreateDirectory(directory);
            }
            var serialized = JsonConvert.SerializeObject(value);
            File.WriteAllText(path, serialized);
        }
    }
}
