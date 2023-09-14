using System.Text.Json;
using System.Text.Json.Serialization;

internal class Io
{
    static string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

    public static void Save<T>(T obj)
    {
        var options = new JsonSerializerOptions() { ReferenceHandler = ReferenceHandler.Preserve};
        string json = JsonSerializer.Serialize(obj);
        //TODO Try catch
        using (StreamWriter writer = new(Path.Combine(path, $"{obj.GetType()}.json")))
        {
            writer.WriteLine(json);
        };
    }

    public static T? Load<T>()
    {
        string file = Path.Combine(path, $"{typeof(T)}.json");
        //Prevention before exception
        if (!File.Exists(file)) return default(T);

        //TODO Trycatch
        string json;
        using (StreamReader reader = new StreamReader(file))
        {
            json = reader.ReadToEnd();
        };
        T? obj = JsonSerializer.Deserialize<T>(json);
        return obj;
    }
}