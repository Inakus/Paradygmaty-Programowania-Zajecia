public class Produkt
{
    public int Id { get; set; }
    public string Nazwa { get; set; }
    public int Cena { get; set; }

    public Produkt()
    {
        Id = 0;
        Nazwa = string.Empty;
        Cena = 0;
    }

    public Produkt(int id, string nazwa, int cena)
    {
        Id = id;
        Nazwa = nazwa;
        Cena = cena;
    }
}

public class Pozycja
{
    public int Id { get; set; }
    public int IdProduktu { get; set; }
    public int Liczba { get; set; }

    public Pozycja()
    {
        Id = 0;
        IdProduktu = 0;
        Liczba = 0;
    }

    public Pozycja(int id, int idProduktu, int liczba)
    {
        Id = id;
        IdProduktu = idProduktu;
        Liczba = liczba;
    }
}


class Program
{
    static void Main(string[] args)
    {
        var produkty = new [] {
            new Produkt {Id = 1, Nazwa = "Dysk HDD", Cena=500},
            new Produkt {Id = 2, Nazwa = "Monitor", Cena=1000},
            new Produkt {Id = 3, Nazwa = "Obudowa", Cena=300},
            new Produkt {Id = 4, Nazwa = "Plyta glowna", Cena=400},
            new Produkt {Id = 5, Nazwa = "Procesor", Cena=800},
        };
        var pozycje = new [] {
            new Pozycja {Id=1, IdProduktu=1, Liczba=2},
            new Pozycja {Id=2, IdProduktu=2, Liczba=3},
            new Pozycja {Id=3, IdProduktu=3, Liczba=1},
            new Pozycja {Id=4, IdProduktu=2, Liczba=2},
            new Pozycja {Id=5, IdProduktu=2, Liczba=1},
            new Pozycja {Id=6, IdProduktu=1, Liczba=3},
            new Pozycja {Id=7, IdProduktu=2, Liczba=3},
        };

        var Najdrozszy = produkty.Max(x => x.Cena);
        Console.WriteLine(Najdrozszy);

        var Powyzej = produkty.Where(x => x.Cena>400).ToArray();

        foreach(var item in Powyzej){
            Console.WriteLine($"{item.Id}, {item.Nazwa}, {item.Cena}");
        }

        var Srednia = produkty.Where(x=> x.Cena < 500).Average(x => x.Cena);
        Console.WriteLine(Srednia);

        var Suma = produkty.Sum(x=> x.Cena);
        Console.WriteLine(Suma);

        var SumaP = produkty.Where(x => x.Nazwa.Substring(0,1)=="P").Sum(x=> x.Cena);
        Console.WriteLine(SumaP);

        

    }
}

