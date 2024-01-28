using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using Текстовый_конвертер;

Console.WriteLine("Введите путь до файла (вместе с названием) который хотите открыть.");
string path = Console.ReadLine();
string txt = File.ReadAllText(path);
string tx = "Ведьмак \nФэнтези \n318";
Book square = new Book();
square.Name = "Ведьмак";
square.Genre = "Фэнтези";
square.Num_Pages = 318;
Book1 square1 = new Book1();
square.Name = "Ведьмак";
square.Genre = "Фэнтези";
square.Num_Pages = 318;

Console.Clear();
Console.WriteLine("Сохранить файл в одном формате(txt, json, xml) - F1. Закрыть программу - Escape");
Console.WriteLine(txt);


ConsoleKeyInfo key;
key = Console.ReadKey();
if (key.Key == ConsoleKey.F1)
{
    Console.Clear();
    Console.WriteLine("Введите путь до файла (вместе с названием) куда хотите сохранить.");
    string pathe = Console.ReadLine();

    if (pathe.EndsWith(".xml"))
    {

        XmlSerializer xml = new XmlSerializer(typeof(Book1));
        using (FileStream a = new FileStream(pathe, FileMode.OpenOrCreate))
        {
            xml.Serialize(a, square1);

        }
    }
    else if (pathe.EndsWith(".json"))
    {
        string jso = JsonConvert.SerializeObject(square);
        File.WriteAllText(pathe, jso);
    }
    else if (pathe.EndsWith(".txt"))
    {

        File.WriteAllText(pathe, tx);
    }

}
else if (key.Key == ConsoleKey.Escape)
{
    Environment.Exit(0);
}