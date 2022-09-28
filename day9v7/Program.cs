using day9v7;
using System.Text.Json;

//ReadNamesAndShowRandomNumberOfThem("Names.txt");
//Console.WriteLine("Now Vikings!");
//ReadNamesAndShowRandomNumberOfThem("VikingNames.txt");
var cats = GetCats("Cats.json");
foreach (var cat in cats)
{
    cat.Report();
}

static void ReadNamesAndShowRandomNumberOfThem(string filename)
{
    var fileContents = File.ReadAllLines(filename);

    var random = new Random();
    for (int i = 0; i < random.Next(5, 10); i++)
    {
        var randomName = fileContents[random.Next(fileContents.Length)];
        Console.WriteLine(randomName);
    }
}

static List<Cat> GetCats(string filename)
{
    var json = File.ReadAllText(filename);
    var cats = JsonSerializer.Deserialize<CatsFileContents>(json);
    return cats.Cats;
}
