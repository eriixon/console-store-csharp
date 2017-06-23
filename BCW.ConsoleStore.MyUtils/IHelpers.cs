using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCW.ConsoleStore.MyUtils
{
    public interface IHelpers
    {
        void SerializeToFile(object value, string path);
        T DeserializeFromFile<T>(string path);
    }
}
