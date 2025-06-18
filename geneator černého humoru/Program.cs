Console.WriteLine("Zadej počet vtipů pro vygenerování: ");
string pocetText = Console.ReadLine();
int pocetVtipu = Convert.ToInt32(pocetText);

var client = new System.Net.Http.HttpClient();

int i = 0;
while (i < pocetVtipu)
{
    var response = client.GetAsync("https://geek-jokes.sameerkumar.website/api?format=text").Result;
    if (response.IsSuccessStatusCode)
    {
        string vtip = response.Content.ReadAsStringAsync().Result;
        Console.WriteLine(vtip);
    }
    else
    {
        Console.WriteLine("Nepodařilo se načíst vtip.");
    }

    Console.WriteLine("-----------------------------------------------");
    System.Threading.Thread.Sleep(2000); // pauza 2 sekundy
    i++;
}

Console.WriteLine("DĚKUJEME ZA VYUŽITÍ GENERÁTORU! :)");