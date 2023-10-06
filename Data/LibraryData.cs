using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Encodings.Web;

namespace Data
{
    public class LibraryData
    {
        public string Data { get; set; }

        public LibraryData(string data)
        {
            Data = data;
        }

        JsonSerializerOptions jsonOptions = new JsonSerializerOptions
        {
            Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
            WriteIndented = true
        };

        // Сохранение с урока
        public async void Save(string Path)
        {
            using (FileStream fs = new FileStream(Path, FileMode.Append))
            {
                await JsonSerializer.SerializeAsync<LibraryData>(fs, new LibraryData(Data), jsonOptions);
            }
        }

        // Чтение Json
        public void Read(string Path)
        {
            Console.Clear();
            Console.WriteLine("\t\tИстория конвертаций : ");

            string jsonString = File.ReadAllText(Path); // Чтение JSON-строки из файла

            LibraryData mainData = JsonSerializer.Deserialize<LibraryData>(jsonString); // Десериализация JSON-строки в объект MainData

            if (mainData != null)
                Console.WriteLine($"Data: {mainData.Data}");
            else
                Console.WriteLine("Объект не был десериализован.");

            Console.ReadLine();
        }
    }
}
