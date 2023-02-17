using JsonParseList.Models;
using System.Text.Json;

namespace JsonParseList
{
    internal class Algorithms
    {
        public static string[] DescriptionDetail()
        {
            string path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + @"\JsonFile\Sample.json";
            string responseFromServer = File.ReadAllText(path);

            List<JsonModel> deserializedClass = JsonSerializer.Deserialize<List<JsonModel>>(responseFromServer);
            string description = deserializedClass[0].description.Substring(0, deserializedClass[0].description.Length - 1);
            return description.Split('\n');
        }
    }
}