// Initialize the list of singers
using PatikafyMusicApp.Models;

List<Singer> singers = new List<Singer>
        {
            new Singer { Name = "Ajda Pekkan", Genre = "Pop", DebutYear = 1968, AlbumSales = "Yaklaşık 20 milyon" },
            new Singer { Name = "Sezen Aksu", Genre = "Türk Halk Müziği / Pop", DebutYear = 1971, AlbumSales = "Yaklaşık 10 milyon" },
            new Singer { Name = "Funda Arar", Genre = "Pop", DebutYear = 1999, AlbumSales = "Yaklaşık 3 milyon" },
            new Singer { Name = "Sertab Erener", Genre = "Pop", DebutYear = 1994, AlbumSales = "Yaklaşık 5 milyon" },
            new Singer { Name = "Sıla", Genre = "Pop", DebutYear = 2009, AlbumSales = "Yaklaşık 3 milyon" },
            new Singer { Name = "Serdar Ortaç", Genre = "Pop", DebutYear = 1994, AlbumSales = "Yaklaşık 10 milyon" },
            new Singer { Name = "Tarkan", Genre = "Pop", DebutYear = 1992, AlbumSales = "Yaklaşık 40 milyon" },
            new Singer { Name = "Hande Yener", Genre = "Pop", DebutYear = 2000, AlbumSales = "Yaklaşık 7 milyon" },
            new Singer { Name = "Hadise", Genre = "Pop", DebutYear = 2005, AlbumSales = "Yaklaşık 5 milyon" },
            new Singer { Name = "Gülben Ergen", Genre = "Pop / Türk Halk Müziği", DebutYear = 1997, AlbumSales = "Yaklaşık 10 milyon" },
            new Singer { Name = "Neşet Ertaş", Genre = "Türk Halk Müziği / Türk Sanat Müziği", DebutYear = 1960, AlbumSales = "Yaklaşık 2 milyon" }
        };

// 1. Singers whose names start with 'S'
var singersStartingWithS = singers.Where(s => s.Name.StartsWith("S")).ToList();
Console.WriteLine("Singers whose names start with 'S':");
singersStartingWithS.ForEach(s => Console.WriteLine(s.Name));
Console.WriteLine();

// 2. Singers with album sales over 10 million
var singersOver10Million = singers.Where(s => ParseSales(s.AlbumSales) > 10_000_000).ToList();
Console.WriteLine("Singers with album sales over 10 million:");
singersOver10Million.ForEach(s => Console.WriteLine(s.Name));
Console.WriteLine();

// 3. Singers who debuted before 2000 and performed pop music
var singersBefore2000Pop = singers
    .Where(s => s.DebutYear < 2000 && s.Genre.Contains("Pop"))
    .OrderBy(s => s.DebutYear)
    .ThenBy(s => s.Name)
    .ToList();
Console.WriteLine("Singers who debuted before 2000 and performed pop music:");
singersBefore2000Pop.ForEach(s => Console.WriteLine($"{s.Name} ({s.DebutYear})"));
Console.WriteLine();

// 4. Singer with the highest album sales
var bestSellingSinger = singers.OrderByDescending(s => ParseSales(s.AlbumSales)).First();
Console.WriteLine("Singer with the highest album sales:");
Console.WriteLine($"{bestSellingSinger.Name} - {bestSellingSinger.AlbumSales}");
Console.WriteLine();

// 5. Singer with the most recent and oldest debut year
var newestSinger = singers.OrderByDescending(s => s.DebutYear).First();
var oldestSinger = singers.OrderBy(s => s.DebutYear).First();
Console.WriteLine("Singer with the most recent debut year:");
Console.WriteLine($"{newestSinger.Name} ({newestSinger.DebutYear})");
Console.WriteLine("Singer with the oldest debut year:");
Console.WriteLine($"{oldestSinger.Name} ({oldestSinger.DebutYear})");
    

    // Helper method to parse album sales
    static int ParseSales(string sales)
{
    // Extract the numeric value from the sales string
    return int.Parse(sales.Replace("Yaklaşık", "").Replace("milyon", "").Trim()) * 1_000_000;
}